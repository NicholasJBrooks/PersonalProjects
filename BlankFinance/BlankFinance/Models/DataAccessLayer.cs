using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Xml;
using System.Data;
using System.Data.SqlTypes;
using System.Collections.ObjectModel;

namespace BlankFinance.Models.Interfaces
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private IConfiguration Configuration;
        public string connectionString;
        public SqlMapper mapper; 

        public DataAccessLayer(IConfiguration config)
        {
            Configuration = config;
            connectionString = Configuration["ConnectionStrings:BFTransactions:ConnectionString"];
            mapper = new SqlMapper(); 
        }
        public Budget GetBudget()
        {
            Budget budget = new Budget();
            SqlConnection _sqlConnectionForBlankFinance;

            using (_sqlConnectionForBlankFinance = new SqlConnection(connectionString))
            {
                _sqlConnectionForBlankFinance.Open();
                SqlString xml = null;

                //Create a command to execute 
                SqlCommand _sqlCommand = new SqlCommand();
                _sqlCommand.CommandText = "SELECT * FROM Budgets";
                _sqlCommand.CommandType = CommandType.Text;
                _sqlCommand.Connection = _sqlConnectionForBlankFinance;

                /* Data Reader Demo */
                //Execute the command and store the data result-set into a data reader 
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();

                //Read each record from data reader at a time  
                if (_sqlReader.HasRows)
                {
                     xml = _sqlReader.GetString(0);
                }
                if (xml != null)
                {
                     budget.BudgetXML = xml.Value;
                }
               
                _sqlReader.Close();

                ///* Data Adaptor and Dataset Demo */
                ////Execute the command and store the data result-set into a data table of a dataset 
                //DataSet _dataSet = new DataSet();
                //SqlDataAdapter _sqlDataAdaptor = new SqlDataAdapter();
                //_sqlDataAdaptor.SelectCommand = _sqlCommand;
                //_sqlDataAdaptor.Fill(_dataSet);           
            }
            return budget;
        }

        public Collection<Type> GetTypes() 
        {
            Collection<Type> types = new Collection<Type>();
            SqlConnection _sqlConnectionForBlankFinance;

            using (_sqlConnectionForBlankFinance = new SqlConnection(connectionString))
            {
                _sqlConnectionForBlankFinance.Open();

                //Create a command to execute 
                SqlCommand _sqlCommand = new SqlCommand();
                _sqlCommand.CommandText = "SELECT * FROM Types";
                _sqlCommand.CommandType = CommandType.Text;
                _sqlCommand.Connection = _sqlConnectionForBlankFinance;

                /* Data Reader Demo */
                //Execute the command and store the data result-set into a data reader 
                using (SqlDataReader _sqlReader = _sqlCommand.ExecuteReader()) 
                {
                    //Read each record from data reader at a time  
                    if (_sqlReader.HasRows)
                    {
                        while (_sqlReader.Read()) 
                        {
                            mapper.MapTransaction(_sqlReader); 
                        }
                    }
                }      
            }

            return types;
        }

        public Collection<Type> GetCategories()
        {
            return null;
        }
    }
}
