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
    }
}
