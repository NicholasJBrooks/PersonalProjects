using System;
using System.Linq;

namespace BlankFinance.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get;  }

        void SaveTransaction(Transaction transaction);

        Transaction DeleteTransaction(Guid TransactionId); 
    }
}
