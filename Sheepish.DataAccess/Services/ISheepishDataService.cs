using Sheepish.Entities;

namespace Sheepish.DataAccess.Services
{
    public interface ISheepishDataService
    {
        public List<Scenario> GetScenarios();
        public Scenario GetScenario(Guid id);
        public void AddScenario(Scenario scenario);
        public void UpdateScenario(Scenario scenario);
        public void DeleteScenario(Guid id);
        public void CompleteScenario(Guid id);
    }
}
