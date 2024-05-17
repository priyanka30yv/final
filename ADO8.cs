using System;
using System.Data.SqlClient;
using System.Data;

using System.Data.SqlClient;

namespace AdoDemos

{

    class Ado8

    {
        public static void Main(string[] args)
        {

            Ado8 obj = new Ado8();

            Console.WriteLine("Enter City Name");

            string cty = Console.ReadLine();

            string result = GetData(cty);

            Console.WriteLine(result);

        }

        static string GetData(string City)

        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");



            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string qry = "Select * from VaccineDrive where city=@p1";




            cmd.CommandText = qry;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20);
            cmd.Parameters["@p1"].Value = City;

            SqlDataReader dr = cmd.ExecuteReader();

            string ans = "\nCenter Id\t\tVaccineName\t\tCity\t\tNumber of People";
            while (dr.Read())

            {

                ans = ans + "\n" + dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3];

            }

            return ans;
        }
    }
}