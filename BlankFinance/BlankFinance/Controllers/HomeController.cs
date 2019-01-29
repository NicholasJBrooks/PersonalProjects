using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult BillsPaid()
        {
            return View(); 
        }

        public ViewResult InputSingleTransaction()
        {
            return View();
        }
    }
}