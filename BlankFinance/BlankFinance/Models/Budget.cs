using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml; 

namespace BlankFinance.Models
{
    public class Budget
    {
        public Guid BudgetId { get; set; }

        public string BudgetXML { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUsed {get; set;}
    }
}
