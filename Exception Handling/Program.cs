using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{

    //  What is Exception Handling?
    // Exception Handling is a mechanism to handle runtime errors gracefully without crashing the program.
    // C# provides keywords like try, catch, finally, and throw for handling errors.

    //   Create a method WithdrawAmount(double balance, double amount)

    // If amount > balance, throw an exception "Insufficient Balance"

    // Else, print remaining balance

    // Use try-catch to handle it in Main()

    public class bank { 
    
         public static void withdraw(double balance, double amount)
        {
            if (amount > balance)
            {
                throw new Exception("Insufficient Balance");

            }
            else
            {
                double remaining = balance - amount;
                Console.WriteLine("Remaining balance is: " + remaining);
            }
        }


    }

    public class m
    { 
       public static void chackage(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("age must be less than 18");
            }
            else
            {
                Console.WriteLine("you are eligible to vote");
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    Console.WriteLine("enter a num");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    int result= 100 / num;
            //    Console.WriteLine("result is: " + result);

            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("you cannot divide by zero");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("enter a valide num");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("genral error" + ex. Message);
            //}

            double currentBalance = 1000;
            double withdrawAmount = 1800;

            try
            {
                bank.withdraw(currentBalance, withdrawAmount);
            }
            catch (Exception)
            {
                Console.WriteLine("transaction failed");
            }


            finally
            {
                Console.WriteLine("thank you for banking with us");
            }


            try
            {
                m.chackage(12);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
            }

        }
    }
}
