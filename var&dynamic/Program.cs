using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  var implicit type

            // var is a implicitly typed variable that allows the compiler to determine its type at compile time.
            // It reduces code redundancy while maintaining strong typing.
            // Once assigned, var cannot change its type.

            var num = 10;
            var massage = "alert";
          //  var x; wrong , need a initalization

          // massage = 10; // Cannot change type from int to string

            var a = 10;       // int
            var b = 10.5;     // double
            var c = 10.5f;    // float
            var d = 10.5m;    // decimal
            Console.WriteLine(a.GetType());

            var num1 = new int[] { 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(num1);


            // What is dynamic in C#?
            // dynamic is a special keyword in C# that allows variables to change types at runtime.
            // It bypasses compile-time type checking and lets you assign any type of value to the variable.
            // It is resolved at runtime, unlike var, which is resolved at compile-time.

            dynamic data = 10;
            Console.WriteLine(data);
            data = "hello";
            Console.WriteLine(data);  // can change at runtime
        }
    }
}
