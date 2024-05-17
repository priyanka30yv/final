using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AdoConsoleDemos
{
    internal class storeprocUpdate
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc3";
          
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 50);
            cmd.Parameters["@p1"].Value = "roshani";
            cmd.Parameters["@p2"].Value = "rutik";
            
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans == 1)
                Console.WriteLine("updated");
            else
                Console.WriteLine("not updated");
        }
    }
}
