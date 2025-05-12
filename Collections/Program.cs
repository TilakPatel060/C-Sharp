using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    class student {

        public int id;
        public string name;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //   What are Collections in C#?
            // Collections in C# are groups of related objects stored and managed together.
            // They offer flexible, resizable, and type - safe ways to store data(unlike arraysWhat is a Generic Collection?


          //  A Generic Collection allows you to define a type - safe collection — meaning it stores a specific type
          //  of object only.



            //  1.List < T >
            // Ordered, resizable, supports index access.

            List<string> name = new List<string>();
            name.Add("tilak");
            name.Add("patel");
            name.Remove("tilak");
            Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);

            List<string> product = new List<string>();
            product.Add("laptop");
            product.Add("mobile");
            product.Add("tablet");

            foreach (string s in product)
            {
                Console.WriteLine(s);
            }

            //  2.Dictionary < TKey, TValue >
            // Key - value pair store(like a mini-database).

            Dictionary<string, int> student = new Dictionary<string, int>();
            student.Add("tilak", 1);
            student.Add("patel", 2);
            student.Add("raj", 3);
            // student.Add("raj", 4); 

            Console.WriteLine(student["tilak"]);
            Console.WriteLine(student["patel"]);
            Console.WriteLine(student["raj"]);
            // Console.WriteLine(student[1]);
            //Console.WriteLine(student["raj"]);

                       //var also works
            foreach (KeyValuePair<string, int> s in student)
            {          
                Console.WriteLine(s.Key + " " + s.Value);
            }

            Console.WriteLine(student.ContainsKey("raj"));


           // 3.Queue < T >
            // FIFO(First - In, First - Out).

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("tilak");
            queue.Enqueue("patel");
            //Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            //foreach(string s in queue)
            //{
            //    Console.WriteLine(s);
            //}


           // 4.Stack < T >
            // LIFO(Last - In, First - Out).

            Stack<string> stack = new Stack<string>();
            stack.Push("rohit");
            stack.Push("rman");

            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            foreach(string s in stack)
            {
                Console.WriteLine(s);
            }

          //  5.HashSet < T >
          // No duplicates, unordered.

            HashSet<int> ints= new HashSet<int>();
            ints.Add(1);
            ints.Add(1);
            ints.Add(3);
            Console.WriteLine(ints.Count);


           // What is ArrayList?
 // ✅ ArrayList is a non - generic collection in C# that can store any type of data (int, string, object, etc.)
 // in a single list.
              

            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add("tilak");
            ar.Add(3.14);
            ar.Add(true);

            Console.WriteLine(ar[0]);
            Console.WriteLine(ar[1]);
            Console.WriteLine(ar[2]);
            Console.WriteLine(ar[3]);


            // Object Initializer with a List

            //    What is an Object Initializer?
            // An object initializer lets you create and assign values to an object(or list of objects) in a single statement,
            //    without needing multiple lines.

            List<student> students = new List<student>
{
    new student { id = 1, name = "Tilak" },
    new student { id = 2, name = "Ravi" },
    new student { id = 3, name = "Amit" }
    };
            foreach (student s in students)
            {
                Console.WriteLine(s.id + " " + s.name);
            }
            



                    

        }
    }
}
