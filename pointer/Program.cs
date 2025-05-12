using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pointer in c# unsafe

            unsafe
            {
                int num = 10;
                int* ptr = &num;
                Console.WriteLine(*ptr);
            }
          //  Pointer Arithmetic
            unsafe
            {
                int[] arr = { 10, 20, 30 };
                fixed (int* p = arr)
                {
                    Console.WriteLine(*p);
                    Console.WriteLine(*(p + 1));
                }
            }

            unsafe
            {
                int x = 42;
                int* p = &x;
                int** pp = &p;
                Console.WriteLine(**pp);

            }
            unsafe
            {
                int num = 10;
                int* ptr = &num;

                Console.WriteLine(num);
                Console.WriteLine((ulong)ptr);
                Console.WriteLine(*ptr);
            }
        }
    }
}
