using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Var_and_dynamic
{

    class x {
        public static void Test()
        {
            var product = new { Id = 101, Name = "Laptop" }; 
            Console.WriteLine(product.Name);

            dynamic item = "Welcome";
            Console.WriteLine(item);

            item = 12345; 
            Console.WriteLine(item + 5); 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

         //   1.var Keyword in C#
// Meaning:
          //  var is statically typed — the type is decided at compile time.

  // The compiler looks at the right-hand side to infer the type.

            var name = "tilak patel";
            var age = 23;

            Console.WriteLine($"Name: {name} age: {age}");

            // You must assign value during declaration because compiler needs the type.
            //var value;
            // value = 10;


            // Here, product is an anonymous type, and var helps us store it.
            var product = new { name = "xyz", price = 300 };
            Console.WriteLine($"Product Name: {product.name} Price: {product.price}");


          //  2.dynamic Keyword in C#
// Meaning:
        //    dynamic is dynamically typed — type is resolved at runtime, not compile time.

 // You can change the type at runtime.

 // Useful when you're working with unknown or flexible data types (like from JSON, Reflection, COM APIs, etc.).
   
            dynamic item = "Hello";
            Console.WriteLine(item); 
            item = 100; 
            Console.WriteLine(item);
            item = true;
            Console.WriteLine(item);

            x.Test();

        }
    }
}
