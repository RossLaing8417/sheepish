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

        List<Scenario> ISheepishDataService.GetScenarios()
        {
            return context.Scenarios.ToList();
        }
    }
}
