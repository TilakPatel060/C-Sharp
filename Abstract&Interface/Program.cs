using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{

    // What is an Abstract Class in C#?
    // An abstract class is a class that cannot be instantiated (you can't create objects of it directly). 
    // It’s meant to be inherited by other classes.

    // It may contain abstract methods (without body) and non-abstract methods (with implementation).




    // abstract class Animal{

    //     public abstract void makevoice();


    //     public void eat(){
    //         Console.WriteLine("eating");
    //     }

    // }
    // {


    // }
    // class dog:Animal{

    //     public override void makevoice(){
    //         Console.WriteLine("whow");
    //     }
    // }



    //     abstract class vehicle{

    //       public abstract void StartEngine();

    //       public  void FuelCapacity(){
    //           Console.WriteLine("Fuel capacity varies by vehicle type.");
    //       }

    //     }

    //     class car:vehicle{

    //         public override void StartEngine(){
    //             Console.WriteLine("Car engine started with key.");
    //         }
    //     }


    //   class bike:vehicle{
    //       public override void StartEngine() {
    //           Console.WriteLine("Bike engine started with kick.");
    //       }

    //   }


    //  What is an Interface in C#?
    // An interface is like a contract that only contains method signatures (no implementation).
    // Any class that imp lements the interface must define all the methods.

    // Create an interface IPrintable with a method Print(). Implement it in two classes: Invoice and Report.

    // Each class should print its own type of message.

    //   interface IPrintable{
    //       void Print();

    //   }

    //   class Invoice:IPrintable{
    //       public void Print(){
    //           Console.WriteLine("hi");
    //       }
    //   }
    //   class Report:IPrintable{
    //       public void Print(){
    //           Console.WriteLine("hello");
    //       }
    //   } 

    // struct point{

    //     public int a;
    //     public int b;
    //   // public int add;

    //     public point(int a,int b){
    //         this.a=a;
    //         this.b=b;
    //     }

    //     public void show(){
    //         Console.WriteLine($"{a} {b}");
    //     }

    // public int add{

    //     get{
    //         return Add;
    //     }
    //     set{
    //         dd=value;
    //     }
    // }

    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //   Animal mydog=new dog();
            //   mydog.makevoice();
            //     mydog.eat();

            //   vehicle myvehicle=new car();
            //   myvehicle.StartEngine();
            //   myvehicle.FuelCapacity();

            //   vehicle myvehicle1= new bike();
            //   myvehicle1.StartEngine();
            //   myvehicle1.FuelCapacity();

            //   IPrintable p=new Invoice();
            //   IPrintable l=new Report();

            //   p.Print all concept with more example and give practice  but first example explain line by line what is need why is use all
            //   l.Print();

            //   point p=new point(10,20);
            //   p.show();
            // p.add=78;
            // Console.WriteLine(p.add);

        }
    }
}
