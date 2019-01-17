using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class ImportController : Controller
    {
        public ViewResult BankOfAmerica()
        {
            return View();
        }

        public ViewResult BetterBankingAndTrust()
        {
            return View();
        }

        public ViewResult Chase()
        {
            return View();
        }

        public ViewResult AmericanExpress()
        {
            return View();
        }
    }
}