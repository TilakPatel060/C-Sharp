using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Access_Modifiers;

namespace Access_Modifiers
{

    //public class emp {

    //    public string name;
    //    public void work()
    //    {
    //        Console.WriteLine($"name:{name}");

    //    }
    
    //}


    public class bankacc {

        private double balance = 100;

        public void deposite(double amount)
        {
            if (amount > 0)

                balance += amount;

        }

                public double getbalance() {

                    return balance;
        }



    }

    public class acc {
    
        public void tryacssess()
        {
           bankacc b=new bankacc();
            
          b.deposite(100);
            Console.WriteLine(b.getbalance());
        }
    
    }



    public class animal {

        protected string sound;

        public void makesound()
        {
            Console.WriteLine(sound);
        }




    }
    public class dog : animal { 
    
        public dog()
        {
            sound = "bark";
        }

    }

    public class outsideclass { 
       
        public void tryacc()
        {
            animal a = new animal();
            //  Console.WriteLine(a.sound);
        }

    }

    internal class internalclass { 
    
       internal void processdata()
        {
            Console.WriteLine("process data");
        }

    }

    public class baseclass {

        protected internal string data = "shared data";


    }

    public class derivedclass : baseclass {
    
       public void main()
        {
            Console.WriteLine(data);
        }

    }









}




internal class Program
    {
        static void Main(string[] args)
        {

          //emp e = new emp { name="raj"};
          //  e.work();

        //   bankacc b=new bankacc();

        //b.deposite(100);


        //Console.WriteLine(b.getbalance());

        dog d=new dog();
        d.makesound();

        acc ac=new acc();
       ac.tryacssess();

        internalclass ic = new internalclass();
        ic.processdata();


        derivedclass dc = new derivedclass();
        dc.main();

    }
    }

