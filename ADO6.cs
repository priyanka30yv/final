using System.Data.SqlClient;
using System.Data;
using System;

 using System;

using System.Data;

using System.Data.SqlClient;

namespace AdoDemos

{

    class Ado6

    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Enter the Previous City");

            string cty1 = Console.ReadLine();

            Console.WriteLine("Enter the New City");

            string cty2 = Console.ReadLine();

            bool ans=UpdateData(cty1, cty2);

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
          

            string qry = "update VaccineDrive set city=@p1 where city=@p2";

            cmd.CommandText = qry;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20);

            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20); 
            cmd.Parameters["@p1"].Value = CityNew;

            cmd.Parameters["@p2"].Value = CityPrevious;

            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)

                return true;

            else

                return false;

        }
    }

} 
