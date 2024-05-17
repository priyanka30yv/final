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
    internal class Program
    {
        static void Main(string[] args)
        {
            
                SqlConnection con;
         
                con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("select * from Employee",con);
            cmd.CommandType = CommandType.Text; 
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString());

                Console.WriteLine(dr[1].ToString());
                Console.WriteLine(dr[2].ToString());
                Console.WriteLine(dr[3].ToString());
                Console.WriteLine("**********************************");
            }
        }
        }
    }

