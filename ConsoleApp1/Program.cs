using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class car{
        public string brand = "bugati";
        public int year = 2021;
      public double price = 2000000.00;

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //  Displaying Boolean Values


            bool content = true;
            bool nocontent = false;

            Console.WriteLine("it's provide content", content);
            Console.WriteLine("it's not provide content", nocontent);

            int num = 15;
            bool even = (num % 2 == 0);
            Console.WriteLine("num is even? " + even);
                
            //    Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool adult = (age >= 18);
            //Console.WriteLine("are you adult " + adult);

            //Console.WriteLine("enter two number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //bool equal = num1 == num2;
            //Console.WriteLine("equal num " + equal);

            //Console.WriteLine("enter a word");
            //string word = Console.ReadLine();
            //bool dotnet = (word == "dotnet");
            //Console.WriteLine(dotnet);

            //  Integer Types
            int age = 25;
            Console.WriteLine("age is - " + age);
            long phno = 9106499954;
            Console.WriteLine("enter your long data type - " + phno);
            short idno = 6171;
            Console.WriteLine("enter a short datatype - " + idno);

            //Console.WriteLine("ENTER PRICE 1 AND 2 ");
            //int price1 = Convert.ToInt32(Console.ReadLine());
            //int price2 = Convert.ToInt32(Console.ReadLine());
            //int totalprice = Convert.ToInt32(price1 + price2);
            //Console.WriteLine("TOTAL PRICE " + totalprice);

            //Console.WriteLine("entre length of rectangal");
            //int lengtg = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("entre width of rectangal");
            //int width = Convert.ToInt32(Console.ReadLine());
            //int area = Convert.ToInt32(lengtg * width);
            //Console.WriteLine("area of rectangal " + area);

            long num1 = 230000;
            long num2 = 12000;
            long total = (num1 * num2);
            Console.WriteLine(total);


            // Floating-Point Types
            //Temperature Conversion
            //Console.WriteLine("enter temperature in celsius");
            //float tempcelsius = float.Parse(Console.ReadLine());
            //float tempfahrenhit = (tempcelsius * 9 / 5) + 32;
            //Console.WriteLine("Convert in fahrenhit " + tempfahrenhit);

            //Console.WriteLine("enter your amount in usd");
            //double usd = Convert.ToDouble(Console.ReadLine());
            //double inr = usd * 82.5;
            //Console.WriteLine(inr);

            //Console.Write("Enter radius of the circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double area = Math.PI * radius * radius;
            //Console.WriteLine("Area of the Circle: " + area);

            decimal bel = 240050.23m;
            Console.WriteLine(bel);

            char singal = 'c';
              Console.WriteLine(singal);


            // referance type

            // string type

            //Console.WriteLine("enter your firstname");
            //string firstname = Console.ReadLine().Trim();
            //Console.WriteLine(firstname);
            //Console.WriteLine("enter your lastname");
            //string lastname = Console.ReadLine();
            //Console.WriteLine(lastname);

            //string fullname = char.ToUpper(firstname[0]) + firstname.Substring(1) + " " + char.ToUpper(lastname[0]) + lastname.Substring(1);
            //Console.WriteLine(fullname);
            Console.ReadLine();

            //object type
            object obj1 = 10;
            object obj2 = "dotnet";
            object obj3 = 10.5;
            object obj4 = true;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);

            // array datatype
            string[] citys = { "new york", "london", "surat" };
            Console.WriteLine(citys[0]);
            Console.WriteLine(citys[1]);
            Console.WriteLine(citys[2]);

            // class datatype
            car c = new car();
            Console.WriteLine(c.brand);
            Console.WriteLine(c.year);
            Console.WriteLine(c.price);


        }
    }
}
