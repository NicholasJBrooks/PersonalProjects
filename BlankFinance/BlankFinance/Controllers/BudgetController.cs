using BlankFinance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace BlankFinance.Controllers
{
    public class BudgetController : Controller
    {
        private ITransactionRepository repository;

        public BudgetController(ITransactionRepository repo)
        {
            repository = repo; 
        }

        public IActionResult MonthlyBudget()
        {
            XmlDocument Budget;
            BudgetModel Model = new BudgetModel();
            
            return View();
        }
    }
} 