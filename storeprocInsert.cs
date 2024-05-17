using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class storeprocInsert
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc2";
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 50);
            cmd.Parameters["@p1"].Value = 199;
            cmd.Parameters["@p2"].Value = "rutik";
            cmd.Parameters["@p3"].Value = "south";
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans == 1)
                Console.WriteLine("inserted");
            else
                Console.WriteLine("not inserted");


        }
    }
}
