using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Election;
namespace AdoConsoleDemos
{
    internal class crudMain4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****************main 4******************");           Election.databaseOperation db = new Election.databaseOperation();
            string choice;
            Console.WriteLine("C-create\nR--Retrieve\nU--Update\nD--Delete");
            Console.WriteLine("enter a choice");
            choice = Console.ReadLine();

            string msg = "";
            switch (choice)
            {
                case "C":
                 Election.Voter v1 = AcceptCreateRecord();
                    bool ans = db.CreateRecord(v1);
                    if (ans)

                        msg = "record added";
                    else
                        msg = "not added";
                    break;
                case "R":
                    msg = db.ReadRecord();
                    break;
                case "U":
                    Election.ChangeInfo c1 = AcceptChangeRecord();
                    int result = db.UpdateRecord(c1);
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
        private static Election.Voter AcceptCreateRecord()
        {
            Election.Voter v = new Election.Voter();
            Console.WriteLine("enter the voter id");
            v.VoterId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the part number");
            v.PartNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the part name");
            v.PartName = Console.ReadLine();
            Console.WriteLine("enter the serial number");
            v.serialNo = Convert.ToInt32(Console.ReadLine());
            return v;
        }
        private static Election.ChangeInfo AcceptChangeRecord()
        {
            Election.ChangeInfo c = new Election.ChangeInfo();
            Console.WriteLine("enter previous part name");
            c.prevPartName = Console.ReadLine();
            Console.WriteLine("enter new part name");
            c.newPartName = Console.ReadLine();
            return c;
        }
    }
}
