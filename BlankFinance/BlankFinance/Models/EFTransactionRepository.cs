using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

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

        public void ClearRepository(IQueryable<Transaction> transactions)
        {
            foreach (Transaction temp in transactions)
            {
                context.Transactions.Remove(temp); 
            }
        }

        public Transaction DeleteTransaction(Transaction transaction)
        {
            context.Transactions.Remove(transaction);

            return transaction; 
        }

        public void SaveAll(IQueryable<Transaction> trans)
        {
            foreach (Transaction temp in trans)
            {
                SaveTransaction(temp);
            }
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
