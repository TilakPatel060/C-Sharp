using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

// using school.students;
// using school.teacher;
// using school.utility;

// using compney.hr.payroll;
// using school.teacher.maths;

// What is a Namespace in C#?
// A namespace is a way to organize code.It acts like a folder or container that holds
// related classes, interfaces, structs, enums, and delegates to avoid name conflicts.

//namespace ConsoleApp10
//{

//    class calculator { 

//         public int add(int a, int b)
//        {
//            return a + b;
//        }


//    }



//    //public class  discount
//    //{
//    //    public double getdiscount(double price,double discount)
//    //    {
//    //        double discountprice = price * discount / 100;
//    //        return discountprice;
//    //    }
//    //}
//    internal class Program
//    {

//        static void Main(string[] args)
//        {


//           ConsoleApp10. calculator c = new ConsoleApp10. calculator();
//           Console.WriteLine( c.add(10, 20));

//            //discount d = new discount();
//            //double price = 1000;
//            //double discount = 10;
//            //double discountprice = d.getdiscount(price, discount);
//            //Console.WriteLine("Discounted price is: " + discountprice);


//        }
//    }
//}

// What are Nested Namespaces in C#?
// A namespace is like a folder that groups related classes, methods, etc.

// A nested namespace is a namespace inside another namespace — like a folder inside another folder.




//namespace compney.hr.payroll
//   {
//            class salary {

//                public void printsalary()
//                {
//                    Console.WriteLine("salary is 10000");
//                }

//            }



//}





//    internal class program
//{
//    static void Main(string[] args)
//    {
//        compney.hr.payroll.salary s = new compney.hr.payroll.salary();
//        s.printsalary();
//    }
// }

// Practice:
// ✅ Create a nested namespace School.Teacher.Maths and a class Algebra. Call the method SolveEquation() from Main().

//namespace school.teacher.maths { 

//    class algebra
//    {
//        public void SolveEquation()
//        {
//            Console.WriteLine("solving equation");
//        }
//    }

//}

//internal class program1
//{
//    static void Main(string[] args)
//    {
//        school.teacher.maths.algebra a = new school.teacher.maths.algebra();
//        a.SolveEquation();
//    }
//}

// Step 1: Namespace with Multiple Classes

//namespace school.students { 

//    public class student
//    {
//        public string name { get; set; }
//        public int rollno { get; set; }

//        public void display() {
//            Console .WriteLine($"name:{name} and rollno:{rollno}");
//        }
//    }


//    public class studentrecord { 

//        public void show()
//        {
//            Console.WriteLine("student acadmic recode");
//        }
//    }


//}


//namespace school.teacher
//{

//    public class teachers
//    {

//        public string name;

//        public void display()
//        {
//            Console.WriteLine($"name:{name}");
//        }

//    }
//}

//namespace school.utility
//{

//    public class helper
//    {

//        public static void greet()
//        {
//            Console.WriteLine("welcome to shcool manegemant system");
//        }



//    }
//}

//namespace school.mainapp
//{

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            helper.greet();

//            student s = new student { name = "Tilak", rollno = 23 };
//          s.display();
//            studentrecord sr = new studentrecord();
//            sr.show();

//            teachers t=new teachers { name = "sachin"};
//            t.display();


//        }
//    }
//}


// What Is "Adding Reference of One Project to Another"?
// In large applications, you often split your code into multiple projects (modules) to keep things clean, reusable, and easy to manage.
// To use code from one project (like a class library) inside another(like a console/web app), you must add a reference.

     namespace ConsoleApp10
{

    public class book {
         
        public string title()
        {
            return "C# programming";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }



}
