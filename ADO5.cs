using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace revision

{

    class VaccineDrive

    {

        public int CentreId { get; set; }

        public string VaccineName { get; set; }

        public string City { get; set; }

        public int NumberOfPeople { get; set; }

        public VaccineDrive() { }

    }

}

namespace AdoDemos

{

    class Ado5

    {

        public static void Main(string[] args)

        {

            revision.VaccineDrive obj = AcceptVaccineDrive();

            bool ans = insertData(obj);

            if (ans == true)

                Console.WriteLine("Record Inserted");
            else
                Console.WriteLine("Record Not inserted");

        }
        static bool insertData(revision.VaccineDrive x)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "insert into VaccineDrive values (@p1,@p2,@p3,@p4)";
            cmd.CommandText = qry;

            cmd.Parameters.Add("@p1", SqlDbType.Int);

            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20);

            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 20);

            cmd.Parameters.Add("@p4", SqlDbType.Int);

            cmd.Parameters["@p1"].Value = x.CentreId;

            cmd.Parameters["@p2"].Value = x.VaccineName; cmd.Parameters["@p3"].Value = x.City;

            cmd.Parameters["@p4"].Value = x.NumberOfPeople;

            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)

                return true;

            else

                return false;
        }
    

        public static revision.VaccineDrive AcceptVaccineDrive()

        {

            revision.VaccineDrive v1 = new revision.VaccineDrive();
            Console.WriteLine("Enter the centre Id");

            v1.CentreId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Vaccine Name");

            v1.VaccineName = Console.ReadLine();

            Console.WriteLine("Enter the City");

            v1.City = Console.ReadLine();

            Console.WriteLine("Enter the Number Of People");

            v1.NumberOfPeople = Convert.ToInt32(Console.ReadLine());

            return v1;
        }
    }
}



