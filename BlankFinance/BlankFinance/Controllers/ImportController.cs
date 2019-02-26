using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFinance.Models;
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

        public IActionResult ImportSingleTransaction(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                repository.SaveTransaction(transaction);
                TempData["Message"] = $"{transaction.Description} has been saved";
                return Redirect("Home/Index"); 
            }
            return View(); 
        }

        public ViewResult ImportCSVFIle()
        {
            return View(); 
        } 

    }
}