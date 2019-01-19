﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankFinance.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get;  }

        void SaveTransaction(Transaction transaction);

        Transaction DeleteTransaction(int TransactionId); 
    }
}
