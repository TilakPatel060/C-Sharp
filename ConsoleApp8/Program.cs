using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Employee
    {
        public virtual void Work()  
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Manager : Employee
    {
        public override void Work()  
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.Work();  

            Manager mgr = new Manager();
            mgr.Work();

        }
    }
}
