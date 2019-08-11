﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankFinance.Models
{
    public class BudgetSection
    {
        public string Name { get; set; }
        public decimal ActualTotal { get; set; }
        public decimal ExpectedTotal { get; set; }
    }
}
