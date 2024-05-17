using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class storeporcDelete
    {
        public static void Main()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc4";

            cmd.Parameters.Add("@p1", SqlDbType.Int);
            
            cmd.Parameters["@p1"].Value = 2;
           

            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans == 1)
                Console.WriteLine("deleted");
            else
                Console.WriteLine("not deleted");
        }
    }
}
