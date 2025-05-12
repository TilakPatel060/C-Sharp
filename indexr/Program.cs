
using System;
using System.Collections.Generic;

// Simple Indexer Example: BookShelf

// class BookShelf {

//     private string[] books = new string[5];

//     public string this[int index]
//     {

//         get{return books[index];}
//         set{books[index] = value;}

//     }

// }

// Real-World Example 1: WeekDays class

// public class WeekDay {

// 	private string[] day= new string[7];


// 	public string this[int index1] {
// 		get{
// 			if (index1 >= 0 && index1 < day.Length)
// 				return day[index1];
// 			else
// 				return "Invalid Day";
// 		}
// 		set{
// 			if (index1 >= 0 && index1 < day.Length)
// 				day[index1] = value;
// 		}

// 	}

// }

// Real-World Example 2: MarksList Class

// public class MarksList {
// 	private int[] mark=new int[5];

// 	public int this [int index2] {
// 		get{
// 			if( index2>=0 && index2< mark.Length) {
// 				return mark[index2];
// 			}
// 			else
// 				return -1 ;

// 		}

// 		set{
// 			if(index2>=0 && index2< mark.Length) {
// 				mark[index2]=value ;
// 			}

// 		}
// 	}


// Create a class StudentList that stores 10 student names using a string array.

// Use a basic indexer to get/set student names.

// Add validation for index range.

// Print all students using a for loop.

// 	public class StudentList {

// 		private string[] names= {"raj","hemraj","moksha","meena","meet","lalu","piyush","krimisha","kartik","parth"};

// 		public string this[int index3] {

// 			get{
// 				if(index3<names.Length) {
// 					return names[index3];
// 				}
// 				else
// 					return "Invalid"
// 					;
// 			}

// 			set{
//                  if(index3 < names.Length){
//               names[index3] = value;
//               }
// 			}
// 		}
// 	}


//    Why Use Multiple Indexers (Different Data Types)?
// Sometimes, in a single class, you may want to access data using different types of keys.

//  Example Use Case:
// Imagine you're building a City Directory:

// You want to access the city name by index (like an array)

// And also get city code by name

//  One class, two ways of access = multiple indexers with different types



//   public class CityDirectory{

//         private string[] city={"Anand","surat","vadodara","ahmdavad","bhavnagar"};

//         private Dictionary<string,int> citycode=new Dictionary<string,int>(){

//             {"Anand",1},
//             {"surat",2},
//             {"vadodara",3},
//              {"ahmdavad",4},
//              {"bhavnagar",5}
//         };

//         public string this[int index6] {
//             get{
//                 if(index6<city.Length){
//                     return city[index6];
//                 }
//                 else
//                 return "Invalid";
//                 ;}
//             set{
//                 if(index6<city.Length){
//                   city[index6]=value;
//                 }
//                 ;}
//         }

//         public int this[string index7]{
//              get{
//                  if(citycode.ContainsKey(index7)){
//                      return citycode[index7];
//                  }
//                  else 
//                  return -1;
//                  ;}
//             set{

//                      citycode[index7] = value;
//                 ;}
//         }



//     }


// Practice Tasks for You
// Task 1: StudentDirectory
//  Array: Store student names

// Dictionary: Store student roll number by name

// Indexer 1: this[int index] → returns student name

// Indexer 2: this[string name] → returns roll number

// public class StudentDirectory{

//     private string[] sname={"raj","het","jay"};

//     private Dictionary<string,int> sroll=new Dictionary<string,int>(){

//         {"raj",1},
//         {"het",2},
//         {"jay",3}

//     };

//     public string this[int index]{
//         get{
//             return sname[index];

//             ;}
//         set{
//             sname[index] = value;
//           ; }
//     }

//     public int this[string index1]{
//         get{
//             if(sroll.ContainsKey(index1)){
//                 return sroll[index1];
//             }
//             else
//              return -1;
//           ;}
//         set{
//             sroll[index1]=value;

//         ;}
//     }

// }


// What Is Indexer Overloading?
//  like methods, you can overload indexers by:

// Changing parameter types (int, string, etc.)

// Changing number of parameters

// 1 Let's Start With an Example and Explain Line by Line
// Scenario: Library class with indexer overload
// We want:

// this[int] → Get book name by index

// this[string] → Get book price by book name

//   class book{
//       public string name { get; set;}
//       public double price { get; set; }

//       public book(string name , double price){
//           this.name= name;
//           this.price=price;
//       }
//   }

//   class Library{

//       private List<book> books=new List<book>(){
//           new book("c#",2300),
//           new book("Asp.net",500),
//           new book("entity framework",300)
//       };

//       public string this [int index]{
//           get{
//               if(index<books.Count){
//                   return books[index].name;
//               }
//               else
//               return "Invalid"
//               ;}
//       }

//       public double this [string index2]{

//           get
//           {
//               foreach (book b in books){
//              if(b.name == index2)
//                  return b.price;
//               }
//               return -1;
//           }

//       }


//   }


//  Real-World Example 1: 📱 Contact Manager App
// You want to:

// Get contact name by index → contacts[0] returns "Rahul"

// Get contact number by name → contacts["Rahul"] returns "9876543210"


class contact
{

    public string name { get; set; }
    public string phone { get; set; }

    public contact(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }

}
class contactmanager
{

    private List<contact> contacts = new List<contact>(){
          new contact("Rahul","9876543210"),
          new contact("het","9875362930"),
          new contact("jit","7483402894")
      };

    public string this[int index]
    {

        get
        {
            if (index >= 0 && index < contacts.Count)
            {
                return contacts[index].name;
            }
            else
                return "Invalid"
           ;
        }


    }


    public string this[string index1]
    {
        get
        {
            foreach (contact c in contacts)
            {
                if (c.name == index1)
                    return c.phone;
            }
            return "Invalid";
        }
    }


}








class HelloWorld
{
    static void Main()
    {

        //  BookShelf shelf=new BookShelf();
        //  shelf[0]="c# basic concept";
        //  shelf[1]="oop concept";

        //  Console.WriteLine(shelf[0]);
        //  Console.WriteLine(shelf[1]);

        // 			WeekDay d=new WeekDay();
        // 			d[0]="sunday";
        // 			Console.WriteLine(d[0]);
        // 			Console.WriteLine(d[8]);

        // 			MarksList m= new MarksList();
        // 			m[0]=21;
        // 			m[1]=51;
        // 			m[2]=71;
        // 			m[4]=12;

        // 			for(int i=0 ; i<5; i++) {

        // 				Console.WriteLine(m[i]);
        // 			}
        //Console.WriteLine(m[0]);
        // Console.WriteLine(m[4]);

        //	StudentList s= new StudentList();
        //	Console.WriteLine(s[10]);

        // 		for(int i=0;i<10;i++){
        // 		    Console.WriteLine(s[i]);
        // 		}

        // 		CityDirectory c=new CityDirectory();
        // 		Console.WriteLine(c["surat"]);

        // 		StudentDirectory s=new StudentDirectory();
        // 		Console.WriteLine(s[2]);


        //   Library l=new Library();

        //   Console.WriteLine(l[0]);
        //   Console.WriteLine(l["c#"]);

        contactmanager c = new contactmanager();

        Console.WriteLine(c[0]);
        Console.WriteLine(c["Rahul"]);





    }

}