using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class UpdateQry
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("enter the previous city");
            string prevcity = Console.ReadLine();

            Console.WriteLine("enter the new city");
            string newcity = Console.ReadLine();

            SqlConnection con;

            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update employee set emplocation='"+newcity+"' where empname='"+prevcity+"'";
            cmd.Connection = con;
            int ans = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} record update", ans);
           
        }
    }
}
