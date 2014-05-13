using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDAL
    {
         System.Data.DataSet getRows(string sqlQuery, string rowsName);
         void actionsRows(string sqlQuery);
    }
}
