using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // Normal declaration of enum
        enum monthname
        {
            january = 1,
            february,
            march,
            april,
            may,
            june,
            july,
            agust,
            september,
            octmber,
            december
        }

        enum orderlist
        {
            panding = 1,
            processing,
            shipped,
            delivered
        }

        enum cartype
        {
            sedan,
            suv,
            buggati,
            curve
        }

        static void Main(string[] args)
        {
            // Assign an enum value
            monthname thismonth = monthname.march;
            Console.WriteLine(thismonth);

            // Get the numeric value of an enum
            int monthnum = (int)monthname.march;
            Console.WriteLine(monthnum);

            // Convert an integer to an enum
            monthname somemonth = (monthname)4;
            Console.WriteLine(somemonth);

            // Loop through all and print
            Console.WriteLine("Enter the month:");
            foreach (monthname month in Enum.GetValues(typeof(monthname)))
            {
                Console.WriteLine(month);
            }

            Console.WriteLine(orderlist.shipped);
            Console.WriteLine((int)orderlist.processing);

            // Convert to string
            orderlist status = orderlist.shipped;
            Console.WriteLine(status.ToString());

            Console.WriteLine(cartype.suv);
            Console.WriteLine((int)cartype.curve);

            foreach (cartype type in Enum.GetValues(typeof(cartype)))
            {
                Console.WriteLine(type);
            }
            cartype convert = (cartype)3;
            Console.WriteLine(convert);

        }
    }
}