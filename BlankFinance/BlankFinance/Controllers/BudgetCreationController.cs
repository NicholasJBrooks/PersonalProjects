using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class BudgetCreationController : Controller
    {
        public IActionResult LoadBudget()
        {

            return View();
        }

        public IActionResult SaveBudget()
        {
            return View();
        }
    }
}