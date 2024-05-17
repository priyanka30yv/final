using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class PRIYANKAYADAV_ADOpractical2_
    {
        public static void Main(string[] args)
        {
            SqlConnection con;

            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("select * from Employee1",con);
          cmd.CommandType=CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[1].ToString());

                Console.WriteLine(dr[3].ToString());
         
                Console.WriteLine("**********************************");
            }
        }
    }
}