using System;
using System.Data;
using System.Data.SqlClient;
using System.Data;

using System.Data.SqlClient;

namespace AdoDemos

{

    class Ado3

    {

        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update vaccinedrive set city=@p1 where city=@p2";
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20);

            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20);

            cmd.Parameters["@p1"].Value = "Bhopal ";
            cmd.Parameters["@p2"].Value = "Mandasaur";

            int ans = cmd.ExecuteNonQuery();

            Console.WriteLine("{0} records updated", ans);
        }
    }
}
