using BlankFinance.Models;
using BlankFinance.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Linq;

namespace BlankFinance.Controllers
{
    public class ImportController : Controller
    {
        private ITransactionRepository repository;
        private CSVConverter Converter = new CSVConverter(); 

        public ImportController(ITransactionRepository repo)
        {
            repository = repo; 
            
        }


        public ViewResult ImportList()
        {
            return View(repository.Transactions);
        }

        public ViewResult ChooseFile() => View("ChooseFile");

        public ViewResult InputSingleTransaction() => View();

        public IActionResult ImportSingleTransaction(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                repository.SaveTransaction(transaction);
                TempData["Message"] = $"{transaction.Description} has been saved";
                return Redirect("ImportList"); 
            }
            return View(); 
        }

        [HttpPost]
        public ViewResult ImportCSVFile(ChooseFileViewModel model)
        {

            Collection<Transaction> transactions = Converter.DesktopTransactions(model.File);
            
            return View("ImportList", transactions.AsQueryable()); 
        }
        
        [HttpPost]
        public ActionResult SaveToTransactionDB(IQueryable<Transaction> transactions)
        {
            repository.SaveAll(transactions);
            repository.ClearRepository(transactions); 

            return View("ImportList");
        }

    }
}