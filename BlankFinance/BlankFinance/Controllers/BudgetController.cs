using BlankFinance.Models;
using BlankFinance.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Xml;

namespace BlankFinance.Controllers
{
    public class BudgetController : Controller
    {
        private ITransactionRepository repository;
        private DataAccessLayer dataAccessLayer;

        public BudgetController(ITransactionRepository repo, IConfiguration configuration)
        {
            repository = repo;
            dataAccessLayer = new DataAccessLayer(configuration); 
        }

        public IActionResult MonthlyBudget()
        {
            Budget budget = new Budget();
            budget = dataAccessLayer.GetBudget();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(budget.BudgetXML); 

            if (xmlDocument.HasChildNodes)
            {
                foreach (XmlNode node in xmlDocument.ChildNodes)
                {
                    if (node.Name == "Column")
                    {
                        BudgetColumn column = new BudgetColumn();
                        
                    }
                }
            }
            return View(budget);
        }

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