using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System;

using System.Data;

using System.Data.SqlClient;

namespace AdoDemos

{

    class Ado7

    {

        public static void Main(string[] args)

        {
            Console.WriteLine("Enter the Previous City");

            string cty1 = Console.ReadLine();

            Console.WriteLine("Enter the New City");

            string cty2 = Console.ReadLine();

            bool ans = UpdateData(cty1, cty2);

            if (ans == true)

                Console.WriteLine("Record Updated");

            else

                Console.WriteLine("Record Not Updated");
        }

        static bool UpdateData(string CityPrevious, string CityNew)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "update VaccineDrive set city='" + CityNew + "' where city='" + CityPrevious + "'";

            Console.WriteLine(qry);

            cmd.CommandText = qry;

            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)
                return true;
            else

                return false;

     


      

    }

}

}