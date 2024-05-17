using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class crudMain3
    {
        public static void Main(string[] args)
        {
            databaseOperation db = new databaseOperation();
            string choice;
            Console.WriteLine("C-create\nR--Retrieve\nU--Update\nD--Delete");
            Console.WriteLine("enter a choice");
            choice = Console.ReadLine();
           
            string msg = "";
            switch (choice)
            {
                case "C":
                    Voter v = new Voter();
                    Console.WriteLine("enter the voter id");
                    v.VoterId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the part number");
                    v.PartNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the part name");
                    v.PartName = Console.ReadLine();
                    Console.WriteLine("enter the serial number");
                    v.serialNo = Convert.ToInt32(Console.ReadLine());
                    bool ans = db.CreateRecord(v);
                    if (ans)

                        msg = "record added";
                    else
                        msg = "not added";
                    break;
                case "R":
                    msg = db.ReadRecord();
                    break;
                case "U":
                    ChangeInfo c = new ChangeInfo();
                    Console.WriteLine("enter previous part name");
                    c.prevPartName = Console.ReadLine();
                    Console.WriteLine("enter new part name");
                    c.newPartName = Console.ReadLine();
                    int result = db.UpdateRecord(c);
                    msg = result.ToString() + "record updated";
                    break;
                case "D":
                    int result1 = db.deleteRecord(1);
                    msg = result1.ToString() + "record deleted";
                    break;
                default:
                    break;
            }
            Console.WriteLine(msg);

        }
    }
}
