using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class PRIYANKAYADAV_ADOpractical1_
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a id");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a employee name");
            string b = Console.ReadLine();
            Console.WriteLine("enter a employee designation");
            string c = Console.ReadLine();
            Console.WriteLine("enter a employee location");
        
            string d = Console.ReadLine();

            SqlConnection con;

            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Employee1 values('"+a+"','"+b+"','"+c+"','"+d+"')";
            cmd.Connection = con;
            int ans = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} record added", ans);
        }
    }
}
