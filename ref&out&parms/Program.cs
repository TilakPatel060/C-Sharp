using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_parms
{

   
    internal class Program
    {
        public static void reference(ref int y)
        {
            y = y * 10;
        }

        static void output(out int x)
        {
            x = 10;
        }
        static void getinfo(out string name, out int age, out string city)
        {
            name = "tilak";
            age = 25;
            city = "surat";
        }
        public static int AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        //Calculating Total Price of Products

        public static int totalprice(params int[] Price)
        {
            int tp = 0;
            foreach (int Prices in Price)
            {
                tp += Prices;
            }
            return tp;
        }
        //Create a method GreetPeople that takes multiple names as input and greets them.

        static void greets(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // Calculate Average Using params
        public static double Averagenum(params double[] number)
        {
            if (number.Length == 0) return 0;
            int sum = 0;
            foreach (int num in number)
            {
                sum = sum + num;
            }

            return (double)sum / number.Length;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(AddNumbers(5, 10, 15));
            Console.WriteLine(AddNumbers(1, 2, 3, 4, 5, 6));


            //Console.WriteLine(totalprice(899,999,23,33,33,33,22,3,3));
            greets("hello", "raj", "keshe ho", "? ");

            Console.WriteLine(Averagenum(4, 2, 5, 6, 3, 2, 56, 34, 35));
        }
    }
}
