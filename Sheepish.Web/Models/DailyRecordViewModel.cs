using Sheepish.Entities;

namespace Sheepish.Web.Models
{
    public class DailyRecordViewModel
    {
        public int Id { get; set; }

        public int ScenarioId { get; set; }

        public uint Day { get; set; }

        public float DayCosts { get; set; }

        public DailyRecordViewModel() { }
        public DailyRecordViewModel(DailyRecord record)
        {
            this.Id = record.Id;
            this.ScenarioId = record.ScenarioId;
            this.Day = record.Day;
            this.DayCosts = record.DayCosts;
        }
    }
}
