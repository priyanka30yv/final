using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class DelQry
    {

        public static void Main(string[] args)
        {
            SqlConnection con;

            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from employee where empid=1";
            cmd.Connection = con;
            int ans = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} record deleted", ans);
        }
    }
}
