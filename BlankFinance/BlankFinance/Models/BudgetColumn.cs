using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlankFinance.Models
{
    public class BudgetColumn
    {
        string ColumnName { get; set; }
        Collection<BudgetRow> Rows { get; set; }
    }
}
