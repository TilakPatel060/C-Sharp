using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



namespace anonymous
{
  //  An Anonymous Method is a method without a name.
  // It is written directly where a delegate expects a method.

   // Real-World Example 1:
  // Sending Notification Using Delegate and Anonymous Method

     delegate void notify(string message);


    // ✅ Practice 1:
    // Write an anonymous method to print the square of a number.

    public delegate int square(int num);


    // Anonymous Types
    // Definition:
    // An Anonymous Type creates a class automatically with read-only properties —
    // without you manually defining a class.

    // Real-World Example 2:
    // Creating an Anonymous Student Object



   // What is an Object Initializer in C#?
  // An object initializer allows you to create an object and assign values to its properties in a single statement,
  // without needing a constructor.


    public class objinit
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            notify n = delegate (string message)
            {
                Console.Write(message);
            };

            n("baby i'm wating for you");

            square s = delegate (int num)
            {
                return num * num;
            };

            Console.WriteLine(s(5));

            var student = new { name = "tilak", age = 18, city = "anand" };
            Console.WriteLine($" name:{student.name} age:{student.age} city:{student.city}");

            //  ✅ Practice 2:
            // Create an anonymous type to store book details(Title, Price) and display them.

            var book = new { title = "x", price = 2000 };
            Console.WriteLine($" title:{book.title} price:{book.price}");

            objinit o = new objinit
            {
               name= "tilak",
                age = 18,
                city = "anand"
            };
            Console.WriteLine($"{o.name} {o.age} {o.city}");
        }
    }
}
