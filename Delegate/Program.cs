using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static Delegate.calculator;
using static Delegate.multicast;
using static Delegate.y;



// What is a Delegate ?
// A delegate in C# is a type that represents references to methods with a particular parameter list and return type.
// It allows methods to be passed as parameters, enabling event-driven programming and providing a flexible way to call methods indirectly.

namespace Delegate
{
    public delegate void mydelegate(string name);

    class x {

        public static void display(string name)
        {
            Console.WriteLine($"hello {name}");
        }

        public static void show(string name) {

            Console.WriteLine(name);
        }
    }
    public class y
    {

        public delegate void myname(string greet);

        public static void greetineglish(string egreet)
        {

            Console.WriteLine($"hello {egreet}");
        }

        public static void greetinHindi(string hgreet)
        {
            Console.WriteLine($"namaste {hgreet}");

        }
    }
    // . Using Delegate for Callbacks
    // A more practical use of delegates is when passing methods as parameters(callbacks).

     class calculator
    {
        public delegate int Operation(int a, int b); // Changed return type to int  

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int mul(int a, int b)
        {
            return a* b;
        }

        public static void calculate(int a, int b, Operation operation)
        {
            int result = operation(a, b); // This now works because Operation returns int  
            Console.WriteLine(result);
        }
    }

    // 3. Multicasting with Delegates
    // Delegates can also be "multicast", meaning they can call multiple methods with a single delegate invocation.

    public class multicast {

        public delegate void mymulticast(string massge);

        public void email(string massge)
        {
            Console.WriteLine($"email {massge}");
        }
        
        public void sms(string massge)
        {
            Console.WriteLine($"sms {massge}");
        }


    }








    internal class Program
    {
        static void Main(string[] args)
        {

            //x y = new x();
            //mydelegate d = new mydelegate(y.display);
            //d("Tilak");



            mydelegate greet = x.show;
            greet("hello");

            greet = x.display;
            greet("hi");

            myname greetineglish = y.greetineglish;
            myname greet1 = greetineglish;
            greet1("good mornaing");

            greet1 = y.greetinHindi;
            greet1("shubh prabhat");


           // Operation c = add ;
           calculator.calculate(2, 3, add);
            calculator.calculate(2, 3, mul);

            // Multicasting

            multicast m = new multicast();
            mymulticast d = m.email;
            d += m.sms; // Add sms method to the delegate invocation list

            d("multicast was here");
        }
    }
}
