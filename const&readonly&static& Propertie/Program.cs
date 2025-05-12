using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_readonly_static__Propertie
{

    // 1️ const (Constant)
    // const is used for declaring fixed values that never change.
    // It must be initialized at the time of declaration.
    // Default behavior: It is implicitly static (belongs to class, not instance).
    // Cannot be modified at runtime.

    // public const double pi=3.14;


    // 2️ readonly (Immutable Field)
    // readonly allows assignment only once, either at declaration or inside a constructor.
    // Unlike const, it can be initialized at runtime.

    // public readonly int Employeeid;

    //  public product(int id){
    //      Employeeid=id;
    //  }

    //  public void showid(){
    //      Console.WriteLine($"{Employeeid}");
    //  }

    // 1️ Create a Company class where:

    // const stores "Company Name".

    // readonly stores "Employee ID".

    // static stores "Total Employees".


    // public const string CompanyName="rishabh";
    // public readonly int EmployeeID;
    // public static int TotalEmployees=12;

    // public product(int idd){
    //     EmployeeID=idd;
    // }

    // public static void cs(int newtotal){
    //     TotalEmployees=newtotal;
    // }

    //   public  void show(){
    //       Console.WriteLine($"{CompanyName } {EmployeeID} {TotalEmployees} ");
    //   }

    // 1️ Static Constructor in C#
    // What is it?
    // A static constructor initializes static data members of a class. It runs only once, 
    //before the first use of the class.

    //   public static string version;
    //   static product(){
    //       Console.WriteLine("static constructor");
    //       version="1.1.0";
    //       }

    // 2️ Static Class
    // What is it?
    // A static class is a class that:
    // Cannot be instantiated.
    // Contains only static members (methods, variables, etc).

    // 3 Destructor
    // What is it?
    // A destructor cleans up unmanaged resources (like files, DB connections, etc.) 
    // when an object is no longer in use.



    // 4️ Properties in C#
    // What is a Property?
    // A property provides controlled access to a class field (encapsulation).
    // Instead of using getField() and setField(), we use properties.

    //  private string namee;

    //  public string Namee {
    //      get {return namee;}
    //      set {namee = value ;}

    //  }

    // private int rollno=12;

    // public int Rollno{
    //     get{return rollno;}
    // }

    //  private string empname;
    //  private int empid=101;

    //  public string Name1{
    //      get{return empname;}
    //      set{empname=value;}
    //  }

    //  public int Id{
    //      get{return empid;}
    //  }
    internal class Program
    {
        static void Main(string[] args)
        {

          //  Console.WriteLine(product.pi);

            //     product i=new product(101);
            //     i.showid();


            //     product s=new product(1);
            //     s.show();
            //   //product s1=new product(2);
            //   product.cs(14);
            //   s.show();


            // Console.WriteLine(product.version);

            // Name n=new Name();

            //   n.namee="het";
            //   Console.WriteLine(n.namee);

            //   Name emp = new Name();
            //   emp.Name1 = "ravi";
            //   Console.WriteLine (emp.Name1);
            //   Console.WriteLine(emp.Id);

        }
    }
}
