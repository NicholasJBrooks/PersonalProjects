using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace BlankFinance.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get;  }

        void SaveAll(Collection<Transaction> transactions);

        void SaveTransaction(Transaction transaction);

        Transaction DeleteTransaction(Guid TransactionId); 
    }
}
