using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

          


            string name = " tilak";
            Console.WriteLine(name);

            string s1 = "tilak";
            s1 += " patel";
            Console.WriteLine(s1);

            int num = 100;
            string strnum = num.ToString();
            Console.WriteLine(strnum);

            char[] n = { 'H', 'i', 'i' };
            string word = new string(n);
            Console.WriteLine(word);

            // Why Use StringBuilder ?
// Strings are immutable, meaning every modification creates a new string object in memory.
 // StringBuilder is mutable, making it faster for repeated string modifications.

            StringBuilder sb = new StringBuilder("hi");
            sb.Append(" word");
            Console.WriteLine(sb);

          //  What is a Verbatim String ?
 // Verbatim strings(@) allow multi-line and special-character strings without escape sequences(\).

            string path = @"C:\Users\Documents\file.txt";
            Console.WriteLine(path);

            string message = @"Dear Customer,
Your order has been shipped.
Thanks for shopping with us!";
            Console.WriteLine(message);


          //  Why Use String Interpolation?
// More readable than + concatenation.
// Embedded variables directly inside the string.

            string namess = "tilak";
            int age = 25;
            Console.WriteLine($"My name is {namess} and I am {age} years old.");

            int orderId = 12345;
            double price = 99.99;
            Console.WriteLine($"Order ID: {orderId}, Total Price: {price}");





        }
    }
}
