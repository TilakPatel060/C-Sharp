using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace singleton
{
    // 1. What is a Private Constructor?
    // Meaning:
    // A private constructor is a constructor that cannot be accessed outside the class.

    // Why use it?
    // To restrict object creation from outside.

    // Common in Singleton or Static utility classes.
    //public class myclass {

    //    private myclass() { 
    //      Console.WriteLine("Constructor called");
    //    }

    //    public static int add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //}


    // 2. Singleton Pattern in C#
    // Meaning:
    // Singleton ensures a class has only one object (instance) throughout the application.

    // Why use it?
    // When you want a single point of access — like:

    // Database connection

    // Logger

    // Configuration manager

    // Caching service

    public class printer {
        
        private static printer first = null;

        private printer()
        {
            Console.WriteLine("Constructor called");
        }
        public static printer getfirst()
        {
            if (first == null)
            { 
                first= new printer();
            }
            return first;
        }

        public void print(string doc)
        {
            Console.WriteLine( doc);

        }
    }










    internal class Program
    {
        static void Main(string[] args)
        {

           // myclass c = new myclass();

          //  Console.WriteLine(myclass.add(1, 2));

            Console.WriteLine(printer.getfirst());


        }
    }
}
