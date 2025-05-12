using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Function_Delegate
{
    // What is a Function Delegate in C#?
    // A function delegate is a reference type that can hold the reference to a method,
    // just like a pointer to a function in C or C++.

   

   // Specifically refers to a method that returns a value



   public delegate double math(double a, double b);

    class cal { 
    
        public static double mul(double a, double b) => a * b;
        public static double add(double a, double b) => a + b;


    }






    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(cal.mul(20, 3));
            Console.WriteLine(cal.add(20, 3));

        }
    }
}
