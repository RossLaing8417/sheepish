using Sheepish.DataAccess.Context;
using Sheepish.Entities;

namespace Sheepish.DataAccess.Services
{
    public class SheepishDataService : ISheepishDataService
    {
        private readonly ApplicationDbContext context;

        public SheepishDataService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Scenario> GetScenarios()
        {
            return context.Scenarios.ToList();
        }

        public Scenario GetScenario(Guid id)
        {
            return context.Scenarios.Find(id);
        }
    }
}
