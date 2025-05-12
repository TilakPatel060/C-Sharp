using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_Overriding_OverHiding
{

    // What is the base keyword in C#?
    // The base keyword is used to access members (methods, properties, or constructors)
    // of the base (parent) class from within a derived (child) class.

    // Real-World Example: Employee → Manager

    //   public class Employee{

    //       public string name;

    //      public Employee(string name){
    //         this.name=name;
    //      }

    //      public void showemp(){
    //          Console.WriteLine(name);
    //      }


    //   }

    //   public class manager : Employee {
    //       public string department;

    //       public manager(string name , string department) : base(name) {
    //           this.department=department;
    //       }

    //       public void showemp(){
    //          base. showemp();
    //           Console.WriteLine(department);
    //       }
    //   }


    //  Create a class Vehicle with a method Start().

    // Create a derived class Car that overrides Start() and uses base.Start() inside it.

    //   public class Vehicle{

    //       public virtual void  start() {
    //           Console.WriteLine("Vehicle is start");
    //       }

    //   }

    //   public class car : Vehicle {
    //       public override void  start(){
    //           base.start();
    //           Console.WriteLine("car also Vehicle");

    //       }
    //   }

    //  Create a class Person with a constructor. 
    // Then create Student class that calls base constructor using base().

    //   public class Person{
    //         public string zender;
    //      public  Person(string zender){
    //           this.zender=zender;
    //           Console.WriteLine(zender);
    //       }
    //   }

    //   public class Student:Person{
    //       public string name;
    //       public Student(string zender,string name ) : base(zender){
    //       Console.WriteLine(name);

    //       }
    //   }

    // What is Method Overriding?
    /// Method Overriding means providing a new implementation of a base class method 
    //  in a derived class, using the same method name and signature.

    // Used when we want to customize or extend behavior of the base class method.

    public class notification
    {

        public virtual void send()
        {
            Console.WriteLine("send generalnotificaton");
        }

    }

    public class email : notification
    {
        public override void send()
        {
            Console.WriteLine("send emailnotification");
        }
    }

    public class sms : notification
    {
        public new void send()
        {
            Console.WriteLine("send smsnotification");
        }
    }


    // 2. Method Hiding (Over Hiding) using new
    // If you don’t want to override, but just want to hide the base method, use the new keyword.

    // public class Person{
    //     public  void work(){
    //         Console.WriteLine("Person is working");
    //     }
    // }

    // public class Student:Person{
    //     public new void work(){
    //         Console.WriteLine("student is study");
    //     }
    // }
    internal class Program
    {
        static void Main(string[] args)
        {

            //   manager m=new manager("tilak","it");
            //   m.showemp();

            //   car c= new car();
            //   c.start();

            // Student s=new Student("male","Tilak");

            //   sms s=new sms();
            //   s.send();

            //   email e=new email();
            //   e.send();

            //   notification n=new sms();
            //   n.send();

            notification n = new email();
            n.send(); // Overriding: will call EmailNotification.Send()

            notification ns = new sms();
            ns.send(); // Hiding: will call Notification.Send()

            sms s = new sms();
            s.send(); // Calls SMSNotification.Send()

            //   Student su=new Student();
            //   su.work();

            //   Person p = new Student();
            //   p.work();
        }
    }
}
