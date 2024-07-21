using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheepish.Entities.Scenario
{
    public class Scenario
    {
        [Key]
        [Column(Order = 1)]
        public uint Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Status { get; set; }

        [MaxLength(256)]
        public string Label { get; set; }
    }
}
