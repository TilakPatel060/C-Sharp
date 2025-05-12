using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // arithmetic operation
            int a = 12;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a / b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);

            // assiganment operation
            int x = 4;
            x *= 5;
            Console.WriteLine(x);
            //comparison operation
            int nu1 = 20;
            int nu2 = 10;
            Console.WriteLine(nu1 < nu2);
            Console.WriteLine(nu1 > nu2);
            Console.WriteLine(nu1 == nu2);
            Console.WriteLine(nu1 != nu2);

            // Logical Operators
            int ag = 17;
            bool haslicensc = true;

            if (ag >= 18 && haslicensc)
            {
                Console.WriteLine("you can drive");
            }


            //	Ternary Operator (? :)
            // Used for short if-else statements.

            int mark = 25;
            string result = (mark >= 85) ? "pass" : "fail";
            Console.WriteLine(result);


        }
    }
}
