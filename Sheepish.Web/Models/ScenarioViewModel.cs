using Sheepish.Entities;

namespace Sheepish.Web.Models
{
    public class ScenarioViewModel
    {
        public Guid Id { get; set; }

        public string Label { get; set; }

        public string Status { get; set; }

        public float SheepPurchacePricePerKg { get; set; }

        public float SheepPurchaceWeight { get; set; }

        public float SheepPurchaceWeightVariance { get; set; }

        public float SheepSalePricePerKg { get; set; }

        public float SheepSaleWeight { get; set; }

        public float SheepSaleWeightVariance { get; set; }

        public float SheepSlaughterLossPercent { get; set; }

        public float ApproxDailyWeightGain { get; set; }

        public string DailyFeedMethod { get; set; }

        public float DailyFeedAmount { get; set; }

        public float FeedPricePerKg { get; set; }

        public float AdditionalMutiPricePerSheep { get; set; }

        public float AdditionalVaxPricePerSheep { get; set; }

        public ScenarioViewModel() { }
        public ScenarioViewModel(Scenario scenario)
        {
            this.Id = scenario.Id;
            this.Label = scenario.Label;
            this.Status = scenario.Status;
            this.SheepPurchacePricePerKg = scenario.SheepPurchacePricePerKg;
            this.SheepPurchaceWeight = scenario.SheepPurchaceWeight;
            this.SheepPurchaceWeightVariance = scenario.SheepPurchaceWeightVariance;
            this.SheepSaleWeight = scenario.SheepSaleWeight;
            this.SheepSaleWeightVariance = scenario.SheepSaleWeightVariance;
            this.SheepSlaughterLossPercent = scenario.SheepSlaughterLossPercent;
            this.ApproxDailyWeightGain = scenario.ApproxDailyWeightGain;
            this.DailyFeedMethod = scenario.DailyFeedMethod;
            this.DailyFeedAmount = scenario.DailyFeedAmount;
            this.FeedPricePerKg = scenario.FeedPricePerKg;
            this.AdditionalMutiPricePerSheep = scenario.AdditionalMutiPricePerSheep;
            this.AdditionalVaxPricePerSheep = scenario.AdditionalVaxPricePerSheep;
        }

        public ScenarioViewModel SetDefaults()
        {
            this.SheepPurchacePricePerKg = 45.0f;
            this.SheepPurchaceWeight = 25.0f;
            this.SheepPurchaceWeightVariance = 0.0f;
            this.SheepSalePricePerKg = 90.0f;
            this.SheepSaleWeight = 50.0f;
            this.SheepSaleWeightVariance = 0.0f;
            this.SheepSlaughterLossPercent = 50.0f;
            this.ApproxDailyWeightGain = 0.416666667f;
            this.DailyFeedMethod = "PerWeight";
            this.DailyFeedAmount = 0.3f;
            this.FeedPricePerKg = 3.5f;
            this.AdditionalMutiPricePerSheep = 14.0f;
            this.AdditionalVaxPricePerSheep = 24.0f;

            return this;
        }

        public void SetEntityProperties(Scenario scenario)
        {
            scenario.Label = this.Label;
            scenario.SheepPurchacePricePerKg = this.SheepPurchacePricePerKg;
            scenario.SheepPurchaceWeight = this.SheepPurchaceWeight;
            scenario.SheepPurchaceWeightVariance = this.SheepPurchaceWeightVariance;
            scenario.SheepSalePricePerKg = this.SheepSalePricePerKg;
            scenario.SheepSaleWeight = this.SheepSaleWeight;
            scenario.SheepSaleWeightVariance = this.SheepSaleWeightVariance;
            scenario.SheepSlaughterLossPercent = this.SheepSlaughterLossPercent;
            scenario.ApproxDailyWeightGain = this.ApproxDailyWeightGain;
            scenario.DailyFeedMethod = this.DailyFeedMethod;
            scenario.DailyFeedAmount = this.DailyFeedAmount;
            scenario.FeedPricePerKg = this.FeedPricePerKg;
            scenario.AdditionalMutiPricePerSheep = this.AdditionalMutiPricePerSheep;
            scenario.AdditionalVaxPricePerSheep = this.AdditionalVaxPricePerSheep;
        }

        public Scenario ToEntity()
        {
            var scenario = new Scenario();
            SetEntityProperties(scenario);
            return scenario;
        }
    }
}
