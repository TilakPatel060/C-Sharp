using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingandunboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // What is Boxing and Unboxing ?
           int num = 40;
            object obj = num; // boxing
            Console.WriteLine(obj);
            Console.WriteLine(num);

            object obj1 = 50;
            int num1 = (int)obj1; // unboxing
            Console.WriteLine(num1);
            Console.WriteLine(obj1);

            ArrayList list = new ArrayList();
            int x = 28;
            list.Add(x); // boxing
            int y = (int)list[0]; // unboxing
            Console.WriteLine(y);
            Console.WriteLine(list[0]);
        }
    }
}
