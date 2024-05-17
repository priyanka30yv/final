using AdoDemos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class CRUDOperation
    {

        static SqlConnection con;
        static SqlCommand cmd;
        static CRUDOperation crud;
      public int CentreId { get; set; }

      public string VaccineName { get; set; }

      public string City { get; set; }

      public int NumberOfPeople { get; set; }
        public static void Main(string[] args)
        {
            Console.WriteLine("want to want to perform");
            Console.WriteLine("1.update");
            Console.WriteLine("2.insert");
            Console.WriteLine("3.select");
            Console.WriteLine("4.delete");
            int choice=Convert.ToInt32(Console.ReadLine()); 
            switch (choice) {
                case 1:
                    crud = updateVaccineDrive();
                    break;
                    case 2:
                    crud = AcceptVaccineDrive();

                    bool ans = insertData(crud);

                    if (ans == true)

                        Console.WriteLine("Record Inserted");

                    else

                        Console.WriteLine("Record Not inserted");
                    break;
                case 3:
                   crud=new CRUDOperation();
                    
                    
                    break;

                case 4:
                   
                    crud = new CRUDOperation();
                    Console.WriteLine("enter which you want to delete ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    bool ans8 = deleteData(a);
                    if (ans8)

                        Console.WriteLine("deleted");

                    else
                        Console.WriteLine("not deleted");
                    break;
                default:
                    Console.WriteLine("invalid input");

                    break;
            } 
        }
       
        public static CRUDOperation AcceptVaccineDrive()

        {

            crud = new CRUDOperation();
            Console.WriteLine("Enter the centre Id");

            crud.CentreId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Vaccine Name");

            crud.VaccineName = Console.ReadLine();

            Console.WriteLine("Enter the City");

            crud.City = Console.ReadLine();

            Console.WriteLine("Enter the Number Of People");

            crud.NumberOfPeople = Convert.ToInt32(Console.ReadLine());

            return crud;
        }
       

      
        public static CRUDOperation updateVaccineDrive()

        {
          
            Console.WriteLine("which you want to update");
          
            Console.WriteLine("city"); 
         
            Console.WriteLine("vaccinename");
           
            Console.WriteLine("numberofpeople");
            string a=Console.ReadLine();
         
            switch (a.ToLower())
            {
                case "city":

                    crud = new CRUDOperation();
                    Console.WriteLine("Enter the City name");

                    string city = Console.ReadLine();

                    Console.WriteLine("Enter center id for which you want to update");
                    int centreid =Convert.ToInt32(Console.ReadLine());   
                    bool ans = UpdateCity(centreid, city);

                    if (ans == true)

                        Console.WriteLine("Record Inserted");

                    else

                        Console.WriteLine("Record Not inserted");
                    break;
            
           
                case "vaccinename":

                    crud = new CRUDOperation();
                    Console.WriteLine("Enter the vaciine name");

                    string name = Console.ReadLine();

                    Console.WriteLine("Enter center id for which you want to update");
                    int centreid1 = Convert.ToInt32(Console.ReadLine());

                    bool ans2 = UpdateName(centreid1,name);
                    if (ans2 == true)
                        Console.WriteLine("Record Inserted");
                    else
                        Console.WriteLine("Record Not inserted");
                    break;
                case "numberofpeople":
                    crud = new CRUDOperation();
                    Console.WriteLine("Enter the number of people");

                    int people = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter center id for which you want to update");
                    int centreid2 = Convert.ToInt32(Console.ReadLine());

                    bool ans3 = UpdateNumberofpeople(centreid2,people);

                    if (ans3 == true)

                        Console.WriteLine("Record Inserted");

                    else

                        Console.WriteLine("Record Not inserted");
                    break;
                default:
                    updateVaccineDrive();
                    break;
                   

            }
            return crud;


        }

        static string GetData(CRUDOperation x)

        {
            SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");



            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string qry = "Select * from VaccineDrive";




            cmd.CommandText = qry;


            SqlDataReader dr = cmd.ExecuteReader();

            string ans = "\nCenter Id\t\tVaccineName\t\tCity\t\tNumber of People";
            while (dr.Read())

            {

                ans = ans + "\n" + dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3];

            }

            return ans;
        }
        static bool insertData(CRUDOperation x)
        {



            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa; password=greysoft");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            string qry = "insert into VaccineDrive values(" + x.CentreId + ", '" + x.VaccineName + "', '" + x.City + "', " + x.NumberOfPeople + ")"; Console.WriteLine(qry);

            cmd.CommandText = qry;

            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)

                return true;

            else

                return false;

        }


  static  bool UpdateCity(int CentreId, string City)
        {
            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "update VaccineDrive set city='" + City + "' where CentreId=" + CentreId + "";
         

            Console.WriteLine(qry);

            cmd.CommandText = qry;
        


            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)
                return true;
            else

                return false;

        }
        static bool UpdateNumberofpeople(int CentreId, int NumberOfPeople)
        {
            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "update VaccineDrive set NumberOfPeople='" + NumberOfPeople + "' where CentreId=" + CentreId + "";


            Console.WriteLine(qry);

            cmd.CommandText = qry;



            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)
                return true;
            else

                return false;

        }


        static bool UpdateName(int CentreId, string VaccineName)
        {
            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "update VaccineDrive set VaccineName='" + VaccineName + "' where CentreId=" + CentreId + "";


            Console.WriteLine(qry);

            cmd.CommandText = qry;



            int ans = cmd.ExecuteNonQuery();

            if (ans == 1)
                return true;
            else

                return false;

        
        }
        static bool deleteData(int centreid)
        {
            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            con.Open();

            cmd = new SqlCommand();

            cmd.Connection = con;

            string qry = "delete from VaccineDrive where CentreId="+centreid+"";


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
