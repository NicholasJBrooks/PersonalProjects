using BlankFinance.Models;
using BlankFinance.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class ImportController : Controller
    {
        private ITransactionRepository repository;

        public ImportController(ITransactionRepository repo)
        {
            repository = repo; 
        }


        public ViewResult ImportList()
        {
            ImportListViewModel model = new ImportListViewModel
            {
                //   Transactions = repository.Transactions.ToList()
            };
            return View(model);
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
        public ViewResult ImportCSVFile(IFormFile fileResult)
        {
            return View(); 
        } 

    }
}