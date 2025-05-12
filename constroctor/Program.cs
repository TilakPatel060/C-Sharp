using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class man
    {
        //default constructor
        public string name;
        public int id;

        public man()
        {
            name = "Hemrajsinh";
            Console.WriteLine("default constructor called");
        }
        // parameterised constructor
        public man(string n, int i)
        {
            name = n;
            id = i;
        }

        public void show()
        {
            Console.WriteLine($"name : {name} , id : {id}");
        }


    }

    internal class constructor
    {

        public static void Main(String[] atrgs)
        {
            man m1 = new man();
            Console.WriteLine(m1.name);

            man m2 = new man("hemrajsinh", 101);
            m2.show();
        }
    }
}
