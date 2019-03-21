using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace BlankFinance.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get;  }

        void SaveAll(IQueryable<Transaction> transactions);

        void ClearRepository(IQueryable<Transaction> transactions); 

        void SaveTransaction(Transaction transaction);

        Transaction DeleteTransaction(Transaction transaction); 
    }
}
