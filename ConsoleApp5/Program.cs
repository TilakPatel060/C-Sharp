using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{

    // 1️ Create a Student class with Name and Age properties. Initialize and print values.

    //class std
    //{
    //    public string name;
    //    public int age;


    //    public void print()
    //    {
    //        Console.WriteLine(name + "" + age);
    //    }
    //}

    // 2️ Implement a Calculator class with Add(), Subtract(), and Multiply() methods.

    //class Calculator
    //{

    //    public int add(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    public int sub(int x, int y)
    //    {
    //        return x - y;
    //    }
    //    public int mul(int x, int y)
    //    {
    //        return x * y;
    //    }
    //    public int div(int x, int y)
    //    {
    //        return x / y;
    //    }
    //}

    // 4️ Write a Product class with a constructor that initializes Name, Price, and Quantity.

    //class product
    //{


    //    public product(string name, double Price, int Quantity)
    //    {
    //        Console.WriteLine($"{name} {Price} {Quantity}");
    //    }
    //}

    // 5️ Implement a Movie class with Title, Director, and ReleaseYear properties.

    //class Movie
    //{

    //    public string Title;
    //    public string Director;
    //    public int ReleaseYear;

    //}


    //A restaurant can take orders and calculate the bill.

    //class order
    //{

    //    public void takeorder(string dish, int Quantity)
    //    {
    //        Console.WriteLine($"{dish} X {Quantity}");
    //    }

    //    public double billcount(int Quantity, double Price)
    //    {
    //        return Quantity * Price;
    //    }

    //}

    // Static vs Instance Members
    //  Static members belong to the class, not objects.
    // Instance members belong to an object.

    //class squre
    //{
    //    public static double pi = 3.14;
    //    int number;

    //    public static double sq(double x)
    //    {

    //        return x * x;
    //    }

        // Properties (Encapsulation)
        // Properties protect fields and provide controlled access.
        // get and set methods allow reading and modifying values safely.

        class person
    {

        private int age;

        public int Age
        {

            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("age is nagative");
                }
            }
        }

        //class bankacc
        //{

        //    private double balance;

        //    public bankacc(double initialbal)
        //    {
        //        balance = initialbal;
        //    }

        //    public void deposit(double amount)
        //    {
        //        balance = balance + amount;
        //        Console.WriteLine(balance);
        //    }

        //    public void withdrawal(double amount)
        //    {

        //        if (balance >= amount)
        //        {
        //            balance = balance - amount;
        //            Console.WriteLine(balance);
        //        }
        //        else
        //        {
        //            Console.WriteLine("enter valide amount");
        //        }


        //    }

        //}

        // What is a Class in C#?
        // A class is a blueprint or template for creating objects.
        // It defines properties (data) and methods (behaviors/actions).
        // Classes help in code reusability and encapsulation.
        class student
        {

            public string fname;
            public string lname;
            public int rollno;
            public int age;

            // Using Constructors
            // A constructor is a special method that runs when an object is created.
            // It initializes the object’s properties.

            public student(string fname, string lname, int rollno, int age)
            {
                this.fname = fname;
                this.lname = lname;
                this.rollno = rollno;
                this.age = age;
            }




            //    public void display()
            //    {
            //        Console.WriteLine($" firstname{ fname} lastname{ lname} {rollno} {age}");
            //}


        }

        //   public string name;

        //   public student(){
        //       name="raj";
        //       Console.WriteLine("create name");
        //   }


        //   public string details;

        //   public student(string studentdetails){
        //       details=studentdetails;
        //   }

        //   public student(student s){
        //       details=s.details;
        //   }


        //   public void showname(){
        //       Console.WriteLine(details);


        //   Practice 1: Book Copy
        // 🔹 Create a class Book with:

        // Properties: title, author

        // One constructor to set values

        // A copy constructor to copy book details

        // Method to display book info

        //   public string title;
        //   public string author;

        //   public book(string Title , string Author){
        //       title=Title;
        //       author=Author;
        //   }

        //   public book(book b){
        //       title=b.title;
        //       author=b.author;
        //   }

        //   public void show(){
        //       Console.WriteLine(title+""+author);
        //   }


        // public static string companyname;

        //   static company(){
        //       companyname="rishabh";
        //       Console.WriteLine("static constructor");
        //   }

        //   public  static void show(){
        //       Console.WriteLine(companyname);
        //   }

        //   Practice: Bank Static Info
        // 🔹 Problem Statement:

        // Create a class Bank with:

        // A static field bankName

        // A static constructor to initialize bankName to "Global Trust Bank"

        // A static method ShowBankName() to display the bank name

        //   public static string bankName;

        //   static bank(){
        //   bankName="Global Trust Bank";
        // }

        // public static void show(){
        //     Console.WriteLine(bankName);


        // this Keyword in C#
        // The this keyword refers to the current instance of the class.
        // It helps to avoid variable name conflicts and call other constructors.

        //public string name;
        //public double price;

        //public product() : this("unknown", 0.0) { }

        //public product(string name, double price)
        //{
        //    this.name = name;
        //    this.price = price;
        //}

        //public void show()
        //{
        //    Console.WriteLine(name + "" + price);
        //}



    }
    internal class Program
        {


            static void Main(string[] args)
            {

            //    std d = new std();
            //    d.name = "Nadim ";
            //    d.age = 12;

            //    d.print();


            //Calculator cal = new Calculator();
            ////  cal.add(2,3);
            ////  cal.sub(3,4);
            ////  cal.mul(4,2);
            //Console.WriteLine(cal.add(2, 3));
            //Console.WriteLine(cal.sub(2, 3));
            //Console.WriteLine(cal.mul(2, 3));
            //Console.WriteLine(cal.div(12, 3));

            //product w = new product("ketan", 999, 4);

            //Movie m = new Movie();
            //m.Title = "moneyheist";
            //m.Director = "Álex Pina";
            //m.ReleaseYear = 2021;

            //Console.WriteLine($"{m.Title} {m.Director} {m.ReleaseYear}");

            //order myorder = new order();
            //myorder.takeorder("pav bhaji", 2);
            //double bill = myorder.billcount(2, 100);
            //Console.WriteLine(bill);

            // Represents a bank account with deposit and withdrawal operations.


            //bankacc b = new bankacc(150);
            //b.deposit(500);
            //b.withdrawal(100);


            // Accessing static members
            //Console.WriteLine(squre.pi);
            //Console.WriteLine(squre.sq(4));

            // Accessing instance members
            //squre s = new squre();
            //s.number = 34;

            //Console.WriteLine(s.number);


            //   What is an Object ?
            // An object is an instance of a class.
            //  It represents a real-world entity.
            // Objects are created using the new keyword.

            // student std = new student(" Tilak", " patel", 20, 20);
            //std.fname = "Tilak";
            //std.lname = "patel";
            //std.rollno = 23;
            //std.age = 20;

            //  Console.WriteLine($" firstname{std.fname} lastname{std.lname} {std.rollno} {std.age}");

            // std.display();

            //person p = new person();
            //p.Age = 12;

            //Console.WriteLine(p.Age);

            //   student std = new student("work is good");
            //   student std1 = new student(std);

            // book mybook= new book("money heist " , "alex pain");
            // book mybook1=new book(mybook);

            // mybook.show();
            // mybook1.show();

            // company.show();
            // company.show();

            // bank.show();


            //product p1 = new product();
            //p1.show();

            //product p2 = new product("laptop", 23000);
            //p2.show();




        }
        }
    }

