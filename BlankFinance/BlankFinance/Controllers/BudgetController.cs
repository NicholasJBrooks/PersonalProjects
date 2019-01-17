using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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