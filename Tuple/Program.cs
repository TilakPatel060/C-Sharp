using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    // Example 1: Returning Multiple Values from a Method

    class x
    {
        public static Tuple<int, int> getsum(int a, int b)
        {
            int sum = a + b;
            int product = a * b;
            return System.Tuple.Create(sum, product);

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // A Tuple is a data structure that allows you to store a group of values(of different types)
            //   in a single object without creating a custom class.

            var mytupale = System.Tuple.Create(1, "Hello", 3.14);

            Console.WriteLine(mytupale.Item1);
            Console.WriteLine(mytupale.Item2);
            Console.WriteLine(mytupale.Item3);

            var result = x.getsum(10, 20);
            Console.WriteLine("Sum: " + result.Item1);
            Console.WriteLine("Product: " + result.Item2);

           // Real - World Example: Student Record

            var student = System.Tuple.Create("John Doe", 20, "Computer Science");
            Console.WriteLine("Name: " + student.Item1);
            Console.WriteLine("Age: " + student.Item2);
            Console.WriteLine("Major: " + student.Item3);

          

        }
}
}
    
