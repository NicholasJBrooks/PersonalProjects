using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}