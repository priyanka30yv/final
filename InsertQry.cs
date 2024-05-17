using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class InsertQry
    {
        public static void Main(string[] args)
        {
            SqlConnection con;

            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Employee values(6,'manisha','trainer','ahmedabad')";
            cmd.Connection = con;
            int ans=cmd.ExecuteNonQuery();
            Console.WriteLine("{0} record added",ans);
        }
    }
}
