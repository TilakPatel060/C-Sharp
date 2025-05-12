using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{

   //  What are Partial Classes?
   // Definition:
  //Partial classes allow you to split a class into multiple files or multiple parts — but at compile time,
  //C# combines them into one single class.
    public partial class student {

        public string name;
        public int rollno;


        public void display()
        {
            Console.WriteLine($"name is {name} and rollno is {rollno}");
        }

    }

    public partial class student {
    
    
          public void show()
        {
            Console.WriteLine(name);
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {

            student s= new student();
            s.name = "sachin";
            s.rollno = 1;
            s.show();
            s.display();

        }
    }
}
