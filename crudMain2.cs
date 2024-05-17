using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class crudMain2
    {
        public static void Main(string[] args)
        {
            databaseOperation db = new databaseOperation();
            string choice;
            Console.WriteLine("C-create\nR--Retrieve\nU--Update\nD--Delete");
            Console.WriteLine("enter a choice");
            choice = Console.ReadLine();
            int vid=0, pno=0, sr=0;
          
            string pn="";
            string msg = "";
            switch (choice)
            {
                case "C":
                    Console.WriteLine("enter the voter id");
                     vid=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the part number");
                    pno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the part name");
                    pn = Console.ReadLine();
                    Console.WriteLine("enter the serial number");
                    sr = Convert.ToInt32(Console.ReadLine());
                    bool ans = db.CreateRecord(vid,pno,pn,sr);
                    if (ans)

                        msg = "record added";
                    else
                        msg = "not added";
                    break;
                case "R":
                    msg = db.ReadRecord();
                    break;
                case "U":
                    string prevpartName, newpartName;
                    Console.WriteLine("enter previous part name");
                    prevpartName = Console.ReadLine();
                    Console.WriteLine("enter new part name");
                    newpartName = Console.ReadLine();
                    int result = db.UpdateRecord(prevpartName,newpartName);
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
