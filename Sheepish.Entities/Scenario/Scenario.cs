using System.ComponentModel.DataAnnotations;

namespace Sheepish.Entities
{
    public class Scenario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Label { get; set; }

        [Required]
        [MaxLength(32)]
        public string Status { get; set; }

        [Required]
        public uint SheepPurchaceAmount { get; set; }

        [Required]
        public float SheepPurchacePricePerKg { get; set; }

        [Required]
        public float SheepPurchaceWeight { get; set; }

        public float SheepPurchaceWeightVariance { get; set; }

        [Required]
        public float SheepSalePricePerKg { get; set; }

        [Required]
        public float SheepSaleWeight { get; set; }

        [Required]
        public float SheepSlaughterLossPercent { get; set; }

        [Required]
        public float ApproxDailyWeightGain { get; set; }

        [Required]
        [MaxLength(32)]
        public string DailyFeedMethod { get; set; }

        [Required]
        public float DailyFeedAmount { get; set; }

        [Required]
        public float FeedPricePerKg { get; set; }

        [Required]
        public float AdditionalMutiPricePerSheep { get; set; }

        [Required]
        public float AdditionalVaxPricePerSheep { get; set; }

        // Calculated Fields
        public float InitialCosts { get; set; }
        public float TotalCosts { get; set; }
        public float TotalSheepSaleWeight { get; set; }
        public float TotalCarcassSaleWeight { get; set; }
        public float TotalSalePrice { get; set; }
    }
}
