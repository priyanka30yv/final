using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class storeprocaddition
    {
        public static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "addnum";
            cmd.Parameters.Add("@num1", SqlDbType.Int);
            cmd.Parameters.Add("@num2", SqlDbType.Int);
            cmd.Parameters.Add("@ans", SqlDbType.Int);

            cmd.Parameters["@num1"].Value = 12; 
            cmd.Parameters["@num2"].Value = 12;
            cmd.Parameters["@ans"].Direction = ParameterDirection.Output;
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            int data = (int)cmd.Parameters["@ans"].Value;
            Console.WriteLine("{0}", data);
            Console.WriteLine(ans.ToString());
            con.Close();
        }
    }
}
