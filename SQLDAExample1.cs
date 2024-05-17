using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoConsoleDemos
{
    internal class SQLDAExample1
    {
        public static void Main(string[] args)
        {


         SqlConnection   con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from employee",con);
            DataSet ds=new DataSet();   
            adapter.Fill(ds);
            Console.WriteLine(ds.Tables[0].Rows.Count);
            Console.WriteLine("name :\n" + ds.Tables[0].Rows[3][1]);
            Console.WriteLine("***************************");
            Console.WriteLine("name :\n" + ds.Tables[0].Rows[3]["EmpName"]);


        }
    }
}
