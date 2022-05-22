using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_conectionSQL
    {
        private readonly string connectionstring;
        public DAO_conectionSQL()
        {
            connectionstring = "Server = COMPU-ZO\\SQLEXPRESS; DataBase= MyCompany; integrated security= true";
            //connectionstring = "Server = ZOELNOTEBOOK; DataBase= MyCompany; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
