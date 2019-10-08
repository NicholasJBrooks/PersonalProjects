using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml; 

namespace BlankFinance.Models.Interfaces
{
    public interface IDataAccessLayer
    {
        Budget GetBudget(); 
    }
}
