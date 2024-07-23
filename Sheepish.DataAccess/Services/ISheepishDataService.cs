using Sheepish.Entities;

namespace Sheepish.DataAccess.Services
{
    public interface ISheepishDataService
    {
        public List<Scenario> GetScenarios();
        public Scenario GetScenario(Guid id);
    }
}
