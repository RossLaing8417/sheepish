using Sheepish.Entities;

namespace Sheepish.DataAccess.Services
{
    public interface ISheepishDataService
    {
        public List<Scenario> GetScenarios();
        public Scenario GetScenario(int id);
        public void AddScenario(Scenario scenario);
        public void UpdateScenario(Scenario scenario);
        public void DeleteScenario(int id);
        public void CompleteScenario(int id);
    }
}
