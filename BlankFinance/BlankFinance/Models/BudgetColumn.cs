﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlankFinance.Models
{
    public class BudgetColumn
    {
        public string ColumnName { get; set; }
        public decimal ActualTotal { get; set; }
        public decimal ExpectedTotal { get; set; }
        public Collection<BudgetRow> Rows { get; set; }
    }
}
