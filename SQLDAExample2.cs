using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class SQLDAExample2
    { public static void Main() {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"GreysoftEmp");
            da.SelectCommand.CommandText = "select * from singer";
            da.Fill(ds, "greysoftSinger");
            Console.WriteLine(ds.Tables["GreysoftEmp"].Rows[3][1].ToString());
            Console.WriteLine("**********************************");
            Console.WriteLine(ds.Tables["greysoftSinger"].Rows[1][1].ToString());
            for(int i = 0; i < ds.Tables["GreysoftEmp"].Rows.Count; i++)
            {
                Console.WriteLine("employee id :{0}\n", ds.Tables[0].Rows[i][0].ToString());
                Console.WriteLine("employee name : {0}\n", ds.Tables[0].Rows[i][1].ToString());
                Console.WriteLine("employee designation :{0}\n", ds.Tables[0].Rows[i][2].ToString());
                Console.WriteLine("employee location :{0}\n", ds.Tables[0].Rows[i][3].ToString());
                Console.WriteLine("***********************");
            }
            Console.WriteLine("***********************");
            for (int i = 0; i < ds.Tables["greysoftSinger"].Rows.Count; i++)
            {
                Console.WriteLine("singer id :{0}\n", ds.Tables[1].Rows[i][0].ToString());
                Console.WriteLine("singer name :{0}\n", ds.Tables[1].Rows[i][1].ToString());
                Console.WriteLine("singer type :{0} \n", ds.Tables[1].Rows[i][2].ToString());
                Console.WriteLine("***********************");
            }
        }
    }
}
