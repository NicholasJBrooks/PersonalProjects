using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


namespace BlankFinance.Models
{
    public class BudgetViewModel
    {
        public Collection<BudgetRow> Rows { get; set; }
        
    }
}
