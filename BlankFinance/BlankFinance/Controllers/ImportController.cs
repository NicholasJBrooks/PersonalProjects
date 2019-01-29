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
        public ViewResult ImportSingleTransaction(Transaction transaction)
        {

            return View(); 
        }

        public ViewResult ImportCSVFIle()
        {
            return View(); 
        } 

    }
}