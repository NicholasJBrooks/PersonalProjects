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
        static private Collection<Transaction> viewTransactions = new Collection<Transaction>();
        private CSVConverter Converter = new CSVConverter();

        public ImportController(ITransactionRepository repo)
        {
            repository = repo;
        }


        public ViewResult ImportList()
        {
            return View(viewTransactions.AsQueryable());
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
            viewTransactions = Converter.DesktopTransactions(model.File);

            return View("ImportList", viewTransactions.AsQueryable());
        }

        [HttpPost]
        public ActionResult SaveToTransactionDB()
        {
            repository.SaveAll(viewTransactions.AsQueryable());
            repository.ClearRepository(viewTransactions.AsQueryable());
            viewTransactions = new Collection<Transaction>();

            return View("ImportList", viewTransactions.AsQueryable());
        }

        public Collection<Transaction> ConvertToDictionaryValue(Collection<Transaction> transactions) 
        {
            foreach (Transaction ta in transactions) 
            {
               
            }
            return transactions; 
        } 
         
    }
}