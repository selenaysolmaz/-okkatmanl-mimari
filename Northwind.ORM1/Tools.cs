using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ORM1
{
    public class Tools
    {
        //1.yol
        //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        //2.yol
        //private static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        //public static SqlConnection Baglanti
        //{
        //    get { return baglanti; }
        //}
        //3.yol
        //UI projesinde App.config içerisine bağlantı parametresi eklenir.

        internal static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);


        internal static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                int affected = cmd.ExecuteNonQuery();
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
                return (affected > 0);

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

    }

}
