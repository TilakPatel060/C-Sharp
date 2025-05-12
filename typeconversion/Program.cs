using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Implicit Conversion (Automatic, No Data Loss)
            // convert a samll data type to big data type

            int price = 2300;
            double finalprice = price;
            Console.WriteLine(finalprice);

            // Explicit Conversion (Manual, Possible Data Loss)
            // convert a large datatype to small data type

            double temperature = 36.5;
            int roundedtemp = (int)temperature;
            Console.WriteLine(roundedtemp);

            // Problem: A shopping website stores the quantity of items as int, but the total price should be double for accuracy.

            int quantity = 3;
            double itemperprice = 49.99;

            double totprice = quantity * itemperprice;
            Console.WriteLine(totprice);

            // The bank's system calculates available balance as double,
            // but ATMs only dispense whole currency notes (int).
            double avlbalance = 34000.23;
            int cashwithdrow = (int)avlbalance;
            Console.WriteLine(cashwithdrow);

            // Problem: A website asks for the user's age as input (string),
            // but needs to verify it as int.

            Console.WriteLine("enter your age");
            string userinput = Console.ReadLine();

            int input = Convert.ToInt32(userinput);
            Console.WriteLine(input);


        }
    }
}
