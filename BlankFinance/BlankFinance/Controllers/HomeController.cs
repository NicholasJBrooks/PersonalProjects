using Microsoft.AspNetCore.Mvc;

namespace BlankFinance.Controllers
{
    public class HomeController : Controller
    {
       // private EFTransactionRepository repository;

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult BillsPaid()
        {
            return View(); 
        }

    }
} 