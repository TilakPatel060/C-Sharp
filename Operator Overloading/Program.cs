using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{

    // What is Operator Overloading in C#?
    // Operator overloading allows custom data types (classes/structs) to define the behavior of standard operators (+, -, *, ==, etc.) for their objects.

    // it lets you use operators with objects, just like you do with basic types like int, string, etc.

    class point
    {
        public int x;
        public int y;


        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static point operator +(point a, point b)
        {
            return new point(a.x + b.x, a.y + b.y);
        }

        public override string ToString()
        {
            return ($"{x} and {y}");
        }

    }



    class Money
    {
        public int rupees;

        public Money(int rupees)
        {
            this.rupees = rupees;
        }

        public static Money operator +(Money m1, Money m2)
        {

            return new Money(m1.rupees + m2.rupees);

        }

        public override string ToString()
        {
            return rupees + "Rs";
        }


    }

    //  Overload Unary Operator ++

    class Unary
    {
        public int value;

        public Unary(int value)
        {
            this.value = value;
        }

        public static Unary operator ++(Unary c)
        {
            return new Unary(c.value + 1);
        }

        public override string ToString()
        {
            return value + "count";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            point p1 = new point(2, 4);
            point p2 = new point(3, 4);

            point result = p1 + p2;
            Console.WriteLine(result);
            // Console.WriteLine(pointObj);

            Money m = new Money(1000);
            Money b = new Money(2000);

            Money total = m + b;
            Console.WriteLine(total);

            Unary u = new Unary(5);
            u++;
            Console.WriteLine(u);
        }
    }
}
