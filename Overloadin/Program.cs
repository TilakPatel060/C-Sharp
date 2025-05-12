using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadin
{

    //  1️ Constructor Overloading in C#
    // Constructor overloading means having multiple constructors in the same class with different parameters.
    // It helps in flexible object creation.

    //   public string name;
    //   public int age;
    //   public double salary;
    //   Employee(){
    //       name="lalu";
    //       age=20;
    //       salary=50000;
    //   }

    //   Employee(string name,int age){
    //       this.name=name;
    //       this.age=age;
    //   }
    //     Employee(string name,int age,double salary){
    //         this.name=name;
    //         this.age=age;
    //         this.salary=salary;
    //     }

    //     public void show(){
    //         Console.WriteLine($"name: {name} age:{age} salary:{salary}");
    //     }


    // 2️ Method Overloading in C#
    // Method overloading means multiple methods with the same name but different parameters.
    // Helps in code reusability and makes code readable.


    //   public int add(int x, int y){
    //       return x+y;
    //   }

    //   public int add(int x, int y,int z){
    //       return x+y+z;
    //   }

    //   public double add(double x, double y){
    //       return x+y;
    //   }

    //  4️ Default Arguments in Overloading
    // Default arguments allow methods to have optional parameters.
    // If no value is provided, the default value is used.

    // public void say(string greet = "hello"){
    //     Console.WriteLine(greet);
    // }

    // 5️ Ambiguous Situation in Overloading
    // Sometimes, the compiler gets confused about which method to call.

    // public void shows(int a,float b){
    //     Console.WriteLine("int to float");
    // }

    // public void shows(float a, int b){
    //     Console.WriteLine("float to int");
    // }

    // 6 Real-World Example: Online Shopping System
    // Overloaded constructors for different ways of creating a product.
    // Overloaded methods for different ways to calculate a discount.


    //  public string name;
    //  public double price;

    //  product(){
    //      name="xyz";
    //      price=300;
    //  }

    //  product(string name){
    //      this.name=name;
    //      price=100;
    //  }

    //  product(string name,double price){
    //      this.name=name;
    //      this.price=price;
    //  }

    //  public double getdiscount(double discount){
    //      return discount=price-(price*discount/100);
    //  }

    //  public double getdiscount(double discount , double addiscount){
    //      double firstdiscount=price-(price*discount/100);
    //      return firstdiscount-(firstdiscount*addiscount/100);
    //  }

    //  public void showdis(){
    //      Console.WriteLine($"name: {name} and price: {price}");
    //  }

    internal class Program
    {
        static void Main(string[] args)
        {


            // Employee e1=new Employee();
            // e1.show();

            // Employee e2=new Employee("parth",21);
            // e2.show();

            // Employee e3=new Employee("jay",12,34000);
            // e3.show();

            //     Employee sum=new Employee();
            //   int total=sum.add(10,20);
            //     Console.WriteLine(total);

            //     Employee sum1=new Employee();
            //     Console.WriteLine(sum1.add(30,23,7));
            //     Console.WriteLine(sum1.add(21,12));

            // Employee says=new Employee();
            // says.say();

            // Employee s=new Employee();
            // s.shows(10.0f,20);


            //     product p=new product("laptop",100);
            //     p.showdis();

            //   Console.WriteLine(p.getdiscount(10));
            //     Console.WriteLine(p.getdiscount(10,5));

        }
    }
}
