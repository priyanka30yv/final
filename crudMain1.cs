using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class crudMain1
    {
        public static void Main(string[] args)
        {
            databaseOperation db=new databaseOperation();
            string choice;
            Console.WriteLine("C-create\nR--Retrieve\nU--Update\nD--Delete");
            Console.WriteLine("enter a choice");
            choice=Console.ReadLine();
            string msg = "";
            switch (choice)
            {
                case "C":
                    bool ans = db.CreateRecord(1, 99, "meera road", 299);
                    if (ans)

                        msg = "record added";
                    else
                        msg = "not added";
                    break;
                case "R":
                    msg = db.ReadRecord();
                    break;
                case "U":
                    int result = db.UpdateRecord("meera road", "mumbai");
                    msg=result.ToString()+"record updated";
                    break;
                case "D":
                    int result1 = db.deleteRecord(1);
                    msg=result1.ToString()+"record deleted";
                    break;
                default:
                    break;
            }
            Console.WriteLine(msg);

        }
    }
}
