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
            var scenario = context.Scenarios.Find(id);
            if (scenario is null)
            {
                throw new NullReferenceException($"Guid: {id}");
            }
            return scenario;
        }

        public void AddScenario(Scenario scenario)
        {
            scenario.Status = "Configuring";
            context.Scenarios.Add(scenario);
            context.SaveChanges();
        }

        public void UpdateScenario(Scenario scenario)
        {
            context.Scenarios.Update(scenario);
            context.SaveChanges();
        }

        public void DeleteScenario(Guid id)
        {
            var scenario = GetScenario(id);
            context.Scenarios.Remove(scenario);
            context.SaveChanges();
        }

        public void CompleteScenario(Guid id)
        {
            var scenario = GetScenario(id);
            if (scenario is null)
            {
                throw new NullReferenceException($"Guid: {id}");
            }

            scenario.Status = "Completed";
            context.Scenarios.Update(scenario);

            // context.SaveChanges();
        }
    }
}
