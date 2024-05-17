using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace AdoConsoleDemos
{
    internal class storeprocRead
    {
        public static void Main(string[] args)
        {
            SqlConnection con=new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc1";
            cmd.Parameters.Add("@p1",SqlDbType.VarChar,50);
            cmd.Parameters["@p1"].Value = "classical";
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {

                Console.WriteLine("singer id : " + dr[0].ToString()+ "\nsinger name : " + dr[1].ToString()+ "\nsong type : " + dr[2].ToString());

            }

        }
    }
}
