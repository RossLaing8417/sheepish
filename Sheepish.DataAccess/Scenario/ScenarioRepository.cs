using Microsoft.EntityFrameworkCore;
using Sheepish.DataAccess.Context;
using Sheepish.Entities;
using Sheepish.Entities.ViewModels;

namespace Sheepish.DataAccess
{
    public class ScenarioRepository
    {
        public List<ScenarioDisplayViewModel> GetScenarios()
        {
            using (var context = new ApplicationDbContext())
            {
                List<Scenario> scenarios = new List<Scenario>();
                scenarios = context.Scenarios.AsNoTracking().ToList();
            }
        }
    }
}
