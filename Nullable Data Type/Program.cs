using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  What is a Nullable Data Type?
            // Nullable types allow value types (int, double, bool, etc.) to hold null values.
            // This is useful when dealing with databases, API responses, or optional values.
            // Nullable types are declared using ? or Nullable<T>.


            // How to Declare Nullable Data Types
            int? age = null;
            double? price = 99.99;
            Nullable<int> mark = null;  // Another way to declare
            Console.WriteLine(age);
            Console.WriteLine(price);
            Console.WriteLine(mark);


            // Checking for Null (HasValue & GetValueOrDefault)

            // Use .HasValue to check if a nullable variable contains a value.
            // Use .Value to retrieve the actual value 
            //  Use .GetValueOrDefault() to provide a default value when null.

            int? number = null;
            if (number.HasValue)
            {
                Console.WriteLine(number.Value);
            }
            else
            {
                Console.WriteLine("number is null");
            }

            int defultnumber = number.GetValueOrDefault(100);
            Console.WriteLine(defultnumber);

            //  Null Coalescing Operator (??)

            // The ?? operator provides a default value when the nullable variable is null.

            int? count = null;
            int finalcount = count ?? 10;
            Console.WriteLine(finalcount);


        }
    }
}
