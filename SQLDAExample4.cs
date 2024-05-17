using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class SQLDAExample4
    {
        public static void Main()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");

            SqlDataAdapter da = new SqlDataAdapter("select * from singer where songtype='classical'", con);
          DataSet s=new DataSet();
            da.Fill(s,"song1");
            da.SelectCommand.CommandText = "select * from singer where songtype='bollywood'";
            da.Fill(s,"song2");
            for(int i = 0; i < s.Tables["song1"].Rows.Count; i++)
            {
                Console.WriteLine("id :" + s.Tables["song1"].Rows[i][0].ToString());
                Console.WriteLine("singer name :" + s.Tables["song1"].Rows[i][1].ToString());
                Console.WriteLine("song type :" + s.Tables["song1"].Rows[i][2].ToString());
               
            }
            for (int j = 0; j < s.Tables["song2"].Rows.Count; j++)
            {
                Console.WriteLine("id :" + s.Tables["song2"].Rows[j][0].ToString());
                Console.WriteLine("singer name :" + s.Tables["song2"].Rows[j][1].ToString());
                Console.WriteLine("song type :" + s.Tables["song2"].Rows[j][2].ToString());

            }

        }
    }
}
