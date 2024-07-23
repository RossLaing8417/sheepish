using Sheepish.Entities;

namespace Sheepish.Web.Models
{
    public class ScenarioViewModel
    {
        public Guid Id { get; set; }

        public string Label { get; set; }

        public string Status { get; set; }

        public string CalculationMethod { get; set; }

        public float SheepCostPerKg { get; set; }

        public float SheepPurchaceWeight { get; set; }

        public float SheepPurchaceWeightVariance { get; set; }

        public float SheepSellWeight { get; set; }

        public float SheepSellWeightVariance { get; set; }

        public float SheepSlaughterLossPercent { get; set; }

        public float ApproxDailyWeightGain { get; set; }

        public float DailyFeedMethod { get; set; }

        public float DailyFeedValue { get; set; }

        public float FeedCostPerKg { get; set; }

        public float AdditionalMutiCostPerSheep { get; set; }

        public float AdditionalVaxCostPerSheep { get; set; }

        public ScenarioViewModel() { }
        public ScenarioViewModel(Scenario scenario)
        {
            this.Id = scenario.Id;
            this.Label = scenario.Label;
            this.Status = scenario.Status;
            this.CalculationMethod = scenario.CalculationMethod;
            this.SheepCostPerKg = scenario.SheepCostPerKg;
            this.SheepPurchaceWeight = scenario.SheepPurchaceWeight;
            this.SheepPurchaceWeightVariance = scenario.SheepPurchaceWeightVariance;
            this.SheepSellWeight = scenario.SheepSellWeight;
            this.SheepSellWeightVariance = scenario.SheepSellWeightVariance;
            this.SheepSlaughterLossPercent = scenario.SheepSlaughterLossPercent;
            this.ApproxDailyWeightGain = scenario.ApproxDailyWeightGain;
            this.DailyFeedMethod = scenario.DailyFeedMethod;
            this.DailyFeedValue = scenario.DailyFeedValue;
            this.FeedCostPerKg = scenario.FeedCostPerKg;
            this.AdditionalMutiCostPerSheep = scenario.AdditionalMutiCostPerSheep;
            this.AdditionalVaxCostPerSheep = scenario.AdditionalVaxCostPerSheep;
        }

        public void SetEntityProperties(Scenario scenario)
        {
            scenario.Id = this.Id;
            scenario.Label = this.Label;
            scenario.Status = this.Status;
            scenario.CalculationMethod = this.CalculationMethod;
            scenario.SheepCostPerKg = this.SheepCostPerKg;
            scenario.SheepPurchaceWeight = this.SheepPurchaceWeight;
            scenario.SheepPurchaceWeightVariance = this.SheepPurchaceWeightVariance;
            scenario.SheepSellWeight = this.SheepSellWeight;
            scenario.SheepSellWeightVariance = this.SheepSellWeightVariance;
            scenario.SheepSlaughterLossPercent = this.SheepSlaughterLossPercent;
            scenario.ApproxDailyWeightGain = this.ApproxDailyWeightGain;
            scenario.DailyFeedMethod = this.DailyFeedMethod;
            scenario.DailyFeedValue = this.DailyFeedValue;
            scenario.FeedCostPerKg = this.FeedCostPerKg;
            scenario.AdditionalMutiCostPerSheep = this.AdditionalMutiCostPerSheep;
            scenario.AdditionalVaxCostPerSheep = this.AdditionalVaxCostPerSheep;
        }
    }
}
