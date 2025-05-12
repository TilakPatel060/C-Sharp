using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lambda
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // What is a Lambda Expression in C#?
            // A lambda expression is a short, inline way to write an anonymous method(a method without a name).

            // It’s defined using the => (lambda operator), often called the goes-to operator.

            // Expression Lambda

            Func<int,int,int> add= (a, b) => a + b;
            Console.WriteLine(add(10, 20));

            Func<int, int, int> mul = (a, b) => a * b;
            Console.WriteLine(mul(10, 20));

            // 2.No Parameters Lambda

              Action name = () => Console.WriteLine("Hello World");
            name();

           // 3.One Parameter Lambda

            Action <string> na =name1 => Console.WriteLine(name1);
            na("Hello duniya");


            // Real - World Example: Filtering Data

            List<int> num = new List<int> {1,2,3,4,5,6,7,8,9 };
            List<int> evennum= num.Where(n=> n%2 == 0).ToList();
            foreach (int item in evennum)
            {
                Console.WriteLine(item);
            }

           // Real - World Example: Sorting Names

            List<string> nam=new List<string> {"raj","amit","rohit" };
            nam.Sort((a,b) => a.CompareTo(b));

            foreach (string item in nam)
            {
                Console.WriteLine(item);
            }




        }
    }
}
