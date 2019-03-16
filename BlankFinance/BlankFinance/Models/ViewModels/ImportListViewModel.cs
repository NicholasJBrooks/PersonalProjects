using System.Collections.Generic;

namespace BlankFinance.Models.ViewModels
{
    public class ImportListViewModel
    {
        public List<Transaction> Transactions  {get; set;}
        public string ReturnUrl { get; set; }
    }
}
