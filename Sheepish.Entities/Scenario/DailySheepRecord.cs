using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheepish.Entities
{
    public class DailySheepRecord
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("DailyRecord")]
        public int DailyRecordId { get; set; }
        public virtual DailyRecord DailyRecord { get; set; }

        public uint SheepId { get; set; }

        public float Weight { get; set; }

        public float FeedWeight { get; set; }

        public float FeedCost { get; set; }
    }
}
