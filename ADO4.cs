using System.Data.SqlClient;
using System;

using System;

using System.Data;

using System.Data.SqlClient;
using System.Configuration;//added

namespace AdoDemos

{

    class VaccineDrive

    {

        public int CentreId { get; set; }

        public string VaccineName { get; set; }

        public string City { get; set; }

        public int NumberOfPeople { get; set; }

        public VaccineDrive() { }

    }

    class Ado4A

    {

        public static void Main(string[] args)

        {

            VaccineDrive obj = AcceptVaccineDrive();

            bool ans =insertData(obj);

            if (ans == true)

                Console.WriteLine("Record Inserted");

            else

                Console.WriteLine("Record Not inserted");

        }
        static bool insertData(VaccineDrive x)
        {



            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa; password=greysoft");
            SqlCommand cmd = new SqlCommand();
            con.Open(); 
            cmd.Connection = con;

            string qry = "insert into VaccineDrive values(" + x.CentreId + ", '" + x.VaccineName + "', '" + x.City + "', " + x.NumberOfPeople + ")"; Console.WriteLine(qry);

            cmd.CommandText = qry;

            int ans = cmd.ExecuteNonQuery();

            if (ans==1)

                return true;

            else

                return false;

        }

        public static VaccineDrive AcceptVaccineDrive()

        {

            VaccineDrive v1 = new VaccineDrive();
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
