using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp10;


namespace ConsoleApp12
{


    //Convert car name to uppercase with extension method
    //public static class stringextension
    //{

    //    public static string ToUpperCase(this string input)
    //    {
    //        return input.ToUpper();
    //    }


    //}

    //public class student
    //{
    //    public string name { get; set; }
    //    public int mark { get; set; }
    //}
    //public static class studentextension
    //{

    //    public static bool pass(this student s)
    //    {
    //        return s.mark >= 50;
    //    }
    //}

    // Task 1: Create an extension method for int that checks if a number is even.
    //public static class intextension
    //{
    //    public static bool iseven(this int num)
    //    {
    //        return num % 2 == 0;
    //    }
    //}

    // Create an extension method for List<int> to calculate the average of all numbers.

    public static class listextension
    {
        public static double avg(this List<int> ints)
        { 
            if (ints.Count == 0) return 0;
             return ints.Average();

        }

    }

        internal class Program
        {
            static void Main(string[] args)
            {

                //book b = new book();
                //Console.WriteLine(b.title());

                //string car = "toyota";
                //Console.WriteLine(car.ToUpperCase());


                //student sd = new student { name = "Tilak", mark = 60 };
                //Console.WriteLine(sd.pass());

                //int num = 4;
                //Console.WriteLine(num.iseven());

                List<int> i = new List<int> { 1, 2, 3, 4, 5 };
                Console.WriteLine(i.Average());
            }
        }
    }

