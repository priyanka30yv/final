using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class SQLDAExample3
    {
        public static void Main()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");

            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "GreysoftEmp");
            da.SelectCommand.CommandText = "select * from singer";
            da.Fill(ds, "greysoftSinger");
            ds.Tables[0].WriteXml("D:\\TRGDemos\\employee.xml");
            ds.Tables[1].WriteXml("D:\\TRGDemos\\singer.xml");
            Console.WriteLine("xml created");
        }
    }
}
