using System;
using System.Data.SqlClient;
using System.Data;
using revision;

namespace AdoDemos
{
    class Ado2

    {
        public static void Main(string[] args)

        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into VaccineDrive values(@p1,@p2,@p3,@p4)";
            cmd.Parameters.Add("@p1",SqlDbType.Int); 
            cmd.Parameters.Add("@p2",SqlDbType.VarChar,20);
            cmd.Parameters.Add("@p3",SqlDbType.VarChar,20);

            cmd.Parameters.Add("@p4",SqlDbType.Int);

            cmd.Parameters["@p1"].Value = 99;

            cmd.Parameters["@p2"].Value = "Moderna";

            cmd.Parameters["@p3"].Value = "Mandasaur";

            cmd.Parameters["@p4"].Value = 99000;

           int ans=cmd.ExecuteNonQuery();  

            Console.WriteLine("{0} records inserted", ans);
        }
    }
}
