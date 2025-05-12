using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class student
    {
        private string name;
        public int age;
        public int id;
        public int x;
        public int y;
        public int z;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public student(string name)
        {
            this.name = name;
        }
       public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int add(int x, int y)
        {
            return x + y;
        }

        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }


        internal class Program
        {

            static void Main(string[] args)
            {

                
                student s1 = new student("Jane", 20);
                Console.WriteLine(s1.add(10, 20));
                Console.WriteLine(s1.add(10, 20, 30));
                s1.show();

                s1.name = "John Doe";
                Console.WriteLine(s1.name);
                
            }
        }
    }
}
