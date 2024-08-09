using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheepish.Entities
{
    public class DailyRecord
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Scenario")]
        public int ScenarioId { get; set; }
        public virtual Scenario Scenario { get; set; }

        [Required]
        public uint Day { get; set; }

        [Required]
        public float DayCosts { get; set; }
    }
}
