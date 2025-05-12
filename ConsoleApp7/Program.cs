using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class  employee
    {
        public string name;
        public double salary;
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name},salary:{salary}");
        }
    }

    class manager : employee
    {
        public string department;

        public void show()
        {

            base.DisplayInfo();

            // Console.WriteLine(department);
        }

        


        internal class Program
        {
            static void Main(string[] args)
            {
                manager m = new manager();
                m.department = ".net";
                m.show();

                m.name = "raj";
                m.salary= 100;
                m.DisplayInfo();

            }
        }
    }
}
