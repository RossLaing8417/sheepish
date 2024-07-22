using System.ComponentModel.DataAnnotations;

namespace Sheepish.Entities
{
    public class Scenario
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Label { get; set; }

        [Required]
        [MaxLength(32)]
        public string Status { get; set; }

        [Required]
        [MaxLength(32)]
        public string CalculationMethod { get; set; }

        [Required]
        public float SheepCostPerKg { get; set; }

        [Required]
        public float SheepPurchaceWeight { get; set; }

        public float SheepPurchaceWeightVariance { get; set; }

        [Required]
        public float SheepSellWeight { get; set; }

        public float SheepSellWeightVariance { get; set; }

        [Required]
        public float SheepSlaughterLossPercent { get; set; }

        [Required]
        public float ApproxDailyWeightGain { get; set; }

        [Required]
        public float DailyFeedMethod { get; set; }

        [Required]
        public float DailyFeedValue { get; set; }

        [Required]
        public float FeedCostPerKg { get; set; }

        [Required]
        public float AdditionalMutiCostPerSheep { get; set; }

        [Required]
        public float AdditionalVaxCostPerSheep { get; set; }
    }
}
