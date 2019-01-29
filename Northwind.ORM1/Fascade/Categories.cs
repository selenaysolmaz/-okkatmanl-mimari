using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Northwind.ORM1.Entity;

namespace Northwind.ORM1.Fascade
{
    public class Categories
    {
        //Connection tanımlanır.
        //select,insertiupdate,delete metodları yazılır.
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("listCategories", Tools.baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Insert(Category c)
        {
            SqlCommand cmd = new SqlCommand("insertCategory", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catName", c.CategoryName);
            cmd.Parameters.AddWithValue("@catDesc", c.Description);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
