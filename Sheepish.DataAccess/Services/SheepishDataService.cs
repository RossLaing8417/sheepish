using Sheepish.DataAccess.Context;
using Sheepish.Entities;

namespace Sheepish.DataAccess.Services
{
    public class SheepishDataService : ISheepishDataService
    {
        private readonly ApplicationDbContext db_context;

        public SheepishDataService(ApplicationDbContext context)
        {
            this.db_context = context;
        }

        public List<Scenario> GetScenarios()
        {
            return db_context.Scenarios.ToList();
        }

        public Scenario GetScenario(int id)
        {
            var scenario = db_context.Scenarios.Find(id);
            if (scenario is null)
            {
                throw new NullReferenceException($"Id: {id}");
            }
            return scenario;
        }

        public void AddScenario(Scenario scenario)
        {
            scenario.Status = "Configuring";
            db_context.Scenarios.Add(scenario);
            db_context.SaveChanges();
        }

        public void UpdateScenario(Scenario scenario)
        {
            db_context.Scenarios.Update(scenario);
            db_context.SaveChanges();
        }

        public void DeleteScenario(int id)
        {
            var scenario = GetScenario(id);
            db_context.Scenarios.Remove(scenario);
            db_context.SaveChanges();
        }

        public void CompleteScenario(int id)
        {
            var scenario = GetScenario(id);
            if (scenario is null)
            {
                throw new NullReferenceException($"Int: {id}");
            }

            var random = new Random();
            var sheep_records = new List<DailySheepRecord>((int)scenario.SheepPurchaceAmount);

            for (uint day = 1; ; day += 1)
            {
                float total_weight = 0.0f;

                var record = new DailyRecord
                {
                    Scenario = scenario,
                    Day = day,
                    DayCosts = 0.0f,
                };

                if (day == 1)
                {
                    for (uint i = 1; i <= scenario.SheepPurchaceAmount; i++)
                    {
                        var weight = SheepInitialWeight(scenario, random);
                        var feed_weight = SheepFeedWeight(scenario, weight);
                        var feed_cost = feed_weight * scenario.FeedPricePerKg;

                        sheep_records.Add(new DailySheepRecord
                        {
                            DailyRecord = record,
                            SheepId = i,
                            Weight = weight,
                            FeedWeight = feed_weight,
                            FeedCost = feed_cost,
                        });

                        total_weight += weight;
                        record.DayCosts += InitialSheepCost(scenario, weight) + feed_cost;
                    }
                }
                else
                {
                    for (int i = 0; i < sheep_records.Count; i++)
                    {
                        // WARNING: Magic number alert (applying 10% random above or below)
                        var weight = sheep_records[i].Weight
                            + (scenario.ApproxDailyWeightGain * (1.1f - ((float)random.NextDouble() * 0.2f)));
                        var feed_weight = SheepFeedWeight(scenario, weight);
                        var feed_cost = feed_weight * scenario.FeedPricePerKg;

                        sheep_records[i] = new DailySheepRecord
                        {
                            DailyRecord = record,
                            SheepId = sheep_records[i].SheepId,
                            Weight = weight,
                            FeedWeight = feed_weight,
                            FeedCost = feed_cost,
                        };

                        total_weight += weight;
                        record.DayCosts += feed_cost;
                    }
                }

                db_context.DailySheepRecords.AddRange(sheep_records);
                db_context.DailyRecords.Add(record);

                // WARNING: Magic number alert (selling sheep when average weight is > 98% of the sell weight)
                if (total_weight / scenario.SheepPurchaceAmount >= 0.98f * scenario.SheepSaleWeight)
                {
                    break;
                }
            }

            scenario.Status = "Completed";
            db_context.Scenarios.Update(scenario);

            db_context.SaveChanges();
        }

        private float SheepInitialWeight(Scenario scenario, Random random)
        {
            if (scenario.SheepPurchaceWeightVariance == 0.0f)
            {
                return scenario.SheepPurchaceWeight;
            }

            var variance = ((scenario.SheepPurchaceWeightVariance * 2) * (float)random.NextDouble()) - scenario.SheepPurchaceWeightVariance;

            return scenario.SheepPurchaceWeight + variance;
        }

        private float InitialSheepCost(Scenario scenario, float weight)
        {
            return (weight * scenario.SheepSalePricePerKg)
                + scenario.AdditionalMutiPricePerSheep
                + scenario.AdditionalVaxPricePerSheep;
        }

        private float SheepFeedWeight(Scenario scenario, float weight)
        {
            switch (scenario.DailyFeedMethod)
            {
                case "PerWeight":
                    return weight * scenario.DailyFeedAmount;
                case "FixedAmount":
                    return scenario.DailyFeedAmount;
                default:
                    throw new Exception($"Invalid feed method: {scenario.DailyFeedMethod}");
            }
        }
    }
}
