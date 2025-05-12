using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    // class parentclass {

    //     public void show(){

    //       Console.WriteLine("from parentclass ") ;
    //     }



    // }


    // class childclass : parentclass {

    //     public void showc(){
    //         Console.WriteLine("from childclass");
    //     }
    // }

    // Scenario: You’re building an Employee Management System

    // class Employee{

    //     public string name;
    //     public int salary;

    //     public void show(){
    //       Console.WriteLine($"Name:{name} and salary: {salary}");
    //     }
    // }

    // class manager : Employee{
    //     public string department;

    //     public void showm(){
    //         Console.WriteLine($"department:{department}");
    //     }
    // }

    // Practice Task (Try It Yourself):
    // Create a program with:

    // A base class Vehicle with method Start().

    // A child class Car that inherits from Vehicle and adds method Drive(). 

    // class Vehicle {

    //     public void Start(){
    //         Console.WriteLine("Vehicle started.");

    //     }
    // }
    // class car : Vehicle{
    //     public void Drive(){
    //         Console.WriteLine("Car is now driving.");
    //     }
    // }


    //  Create a multilevel program with:

    // class Animal → method Eat()

    // class Dog : Animal → method Bark()

    // class Puppy : Dog → method Weep()

    // class Animal{

    //     public void Eat()
    // {
    //     Console.WriteLine("Animal is eating");
    // }    
    // }

    // class Dog : Animal {

    //     public void Bark(){
    //     Console.WriteLine("Dog is barking");
    //     }
    // }

    // class Puppy:Dog{
    //     public void Weep(){
    //         Console.WriteLine("Puppy is weeping");
    //     }
    // }


    // What is Hierarchical Inheritance?
    // Hierarchical Inheritance means: ➡️ One base class is inherited by multiple derived classes.

    // // Base class
    // class Employee
    // {
    //     public void ShowCompany()
    //     {
    //         Console.WriteLine("Company: TechCorp");
    //     }
    // }

    // // Derived class 1
    // class Manager : Employee
    // {
    //     public void ManageTeam()
    //     {
    //         Console.WriteLine("Manager manages team.");
    //     }
    // }

    // // Derived class 2
    // class Developer : Employee
    // {
    //     public void WriteCode()
    //     {
    //         Console.WriteLine("Developer writes code.");
    //     }
    // }


    // What is a Has-A Relationship?
    // In object-oriented programming, a Has-A relationship means that one class contains an object of another class. 
    // It is also known as Composition or Aggregation.

    // class Engine{

    //     public void Start(){
    //         Console.WriteLine("Engine started");
    //     }
    // }

    // class car {
    //     private Engine engine = new Engine();
    //     public void startcar(){
    //         Console.WriteLine("car started");
    //         engine.Start();
    //     }
    // }

    // Another Example: Person Has-A Address

    //  class Address{
    //      public string city="Anand";
    //      public string zip="388580";

    //  }

    //  class Person{
    //   public  Address address=new Address();
    //      public string name ="Ajay";
    //  }


    //  Make a class Computer that Has-A Processor.

    // class Processor{
    //      public string brand="intal";
    //     public string core ="8";

    //     public void ShowProcessor(){
    //         Console.WriteLine($"brand:{brand} and core: {core} ");

    // }
    // }
    // class Computer{

    //     public string model="asus vivobook";
    //   public Processor p=new Processor();

    //     public void showmodel(){
    //         Console.WriteLine($"model:{model}");
    //         p.ShowProcessor();
    //     }

    //     }
    internal class Program
    {
        static void Main(string[] args)
        {
            //   childclass o=new childclass();
            //   o.showc();
            //   o.show();

            //   manager m=new manager();
            //   m.department=".Net";
            //   m.showm();
            //   m.name="hem's";
            //   m.salary=20000;
            //   m.show();

            //  car  c = new car();
            //  c.Drive();
            //  c.Start();

            //  Puppy p=new Puppy();
            //  p.Bark();
            //  p.Eat();
            //  p.Weep();

            //  Manager mgr = new Manager();
            //         Developer dev = new Developer();

            //         Console.WriteLine("Manager Info:");
            //         mgr.ShowCompany();
            //         mgr.ManageTeam();

            //         Console.WriteLine("\nDeveloper Info:");
            //         dev.ShowCompany();
            //         dev.WriteCode();


            //   car mycar = new car();
            //   mycar.startcar();

            //   Person myperson=new Person();
            //   Console.WriteLine(myperson.name);
            //   Console.WriteLine($"{myperson.address.city}");

            //   Computer ca=new Computer();
            //   ca.showmodel();

        }
    }
}
