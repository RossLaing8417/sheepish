using Microsoft.AspNetCore.Mvc;

namespace Sheepish.Web.Controllers
{
    public class ScenarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
