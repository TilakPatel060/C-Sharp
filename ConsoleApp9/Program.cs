using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    public  class product
    {
        public static string name;
        static product()
        {
            Console.WriteLine("static constructor");
            name = "laptop";
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            
           // Console.WriteLine(product.name);
        }
    }
}
