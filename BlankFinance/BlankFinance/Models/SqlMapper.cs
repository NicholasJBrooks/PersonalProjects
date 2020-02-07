using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BlankFinance.Models
{
    public class SqlMapper
    {
        public SqlMapper()
        {

        }

        public Transaction MapTransaction(SqlDataReader reader)
        {
            Transaction transaction = new Transaction();
            DateTime DateTemp;
            Decimal AmountTemp;

            transaction.TransactionId = Guid.Parse(reader["Id"].ToString());

            transaction.Type = reader["Type"].ToString();
            transaction.Description = reader["Description"].ToString();
            transaction.Category = reader["Category"].ToString();

            DateTime.TryParse(reader["Date"].ToString(), out DateTemp);
            transaction.Date = DateTemp;

            Decimal.TryParse(reader["Amount"].ToString(), out AmountTemp);
            transaction.Amount = AmountTemp;

            return transaction;

        }

        public Type MapType(SqlDataReader reader) 
        {
            Type type = new Type();

            type.Id = Guid.Parse(reader["Id"].ToString());
            type.Name = reader["Name"].ToString();

            return type;
        }
    }
}
