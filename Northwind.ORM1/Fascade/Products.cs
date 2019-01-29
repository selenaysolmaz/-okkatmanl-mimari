using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Northwind.ORM1.Fascade
{
    public class Products
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("listProducts", Tools.baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
