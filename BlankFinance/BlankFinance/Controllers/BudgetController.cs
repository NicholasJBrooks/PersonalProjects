using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult MonthlyBudget()
        {
            return View();
        }
    }
}