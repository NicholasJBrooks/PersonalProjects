using System;
using System.Collections.Generic;
using System.Linq;
using BlankFinance.Models;
using System.Threading.Tasks;

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

        public Transaction DeleteTransaction(int TransactionId)
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
