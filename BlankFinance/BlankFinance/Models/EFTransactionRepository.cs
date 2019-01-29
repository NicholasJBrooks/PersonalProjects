using System;
using System.Collections.Generic;
using System.Linq;
using BlankFinance.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer; 

namespace BlankFinance.Models
{
    public class EFTransactionRepository: ITransactionRepository
    {
        private ApplicationDBContext context;

        public EFTransactionRepository(ApplicationDBContext ctx)
        {
            this.context = ctx;
        }

        public IQueryable<Transaction> Transactions => context.Transactions;

        public Transaction DeleteTransaction(Guid TransactionId)
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(Transaction transaction)
        {
            if (transaction.TransactionId == Guid.Empty)
            {
                context.Transactions.Add(transaction);
            }
            else
            {
                Transaction dbEntry = context.Transactions.FirstOrDefault(t => t.TransactionId == transaction.TransactionId);
                if (dbEntry != null)
                {
                    dbEntry.Amount = transaction.Amount;
                    dbEntry.Date = transaction.Date;
                    dbEntry.Description = transaction.Description;
                    dbEntry.Category = transaction.Category;
                    dbEntry.Type = transaction.Type;
                }
            }
            context.SaveChanges(); 
        }
    }
}
