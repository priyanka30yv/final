using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class SQLDAExample5
    {
        public static void Main(string[]args)
        {
            DataSet d=new DataSet();
            d.ReadXml("D://TRGDemos//emp.xml");
            Console.WriteLine("the number of table are {0}", d.Tables.Count);
            for(int i=0; i<d.Tables[0].Rows.Count;i++) {
                Console.WriteLine("{0} is from {1}", d.Tables[0].Rows[i]["EmpName"],
                d.Tables[0].Rows[i]["City"]);
                Console.WriteLine("{0}", d.Tables[0].Rows[i]["empid"]);

            }

        }
    }
}
