using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring and Initializing 1D Arrays

            // int[] num=new int[5]; //{23,12,4,3,42};
            //   int[] mark={34,33,21,211,12};
            //   mark[1]=1;
            //     Console.WriteLine(mark[1]);

            // foreach(int marks in mark){
            //     Console.WriteLine("studant  " + (marks));
            // }

            // Storing Employee Salaries

            // double[] salary={25000,20000,23500,21000,3400};
            // Console.WriteLine(salary[2]);
            //     foreach(double salarys in salary){
            //       Console.WriteLine(salarys);
            //   }
            // for (int i = 0; i < salary.Length; i++)
            //         {
            //             Console.WriteLine("Employee :"+ salary[i]);
            //         }

            // Two-Dimensional (2D) Arrays
            // Definition: A grid-like structure with rows and columns.
            //Example Use Case: A chessboard, seating arrangement, or timetable.

            //   int[,] matrix = new int[2,3]{{1,2,3},{5,4,7}};
            //   Console.WriteLine(matrix[0,2]);
            //   foreach (int matrixs in matrix) {
            //       Console.WriteLine(matrixs);
            // }

            // for(int i=0;i<2;i++){
            //     for(int j=0;j<3;j++){
            //         Console.WriteLine(matrix[i,j]);
            //     }
            //     Console.WriteLine();
            // }

            //   int[,] table={{2,34,23},{12,43,32}};

            //  // Console.WriteLine(table[0,2]);

            //   for(int i=0;i<2;i++){
            //       for(int j=0;j<3;j++){
            //           Console.WriteLine(table[i,j]+" ");
            //       }
            //       Console.WriteLine();
            //   }
            //   foreach(int tables in table){
            //       Console.WriteLine(tables);
            //   }

            // Real-World Example: Cinema Seat Booking

            // string[,] Cinemaset=
            // {
            //   {"A1","A2","A3"},
            //   {"B1","B2","B3"},
            //   {"C1","C2","C3"}
            // };

            // Console.WriteLine("seating arrangement"); 
            //     for(int i=0;i<3;i++){
            //         for(int j=0;j<3;j++){
            //         Console.WriteLine(Cinemaset[i,j]);
            //     }

            //         Console.WriteLine();

            //     }

            // Jagged Arrays (Array of Arrays)
            // Definition: A jagged array is an array of arrays, where each inner array can have different lengths.
            //  Example Use Case: Different number of students in each classroom.

            int[][] jaggedarr = new int[4][]
       {
                 new int[] {1, 2, 3},
                 new int[] {1, 2},
                 new int[] {1} ,
                 new int[] {5,4,3}
       };
            Console.WriteLine(jaggedarr[1][1]);
            foreach (int[] innerArray in jaggedarr)
            {
                foreach (int value in innerArray)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            } 


            //  Classrooms with Different Students

            string[][] studant = new string[3][];
            studant[0] = new string[] { "raj", "HET" };
            studant[1] = new string[] { "dhaval", "dhruv" };
            studant[2] = new string[] { "nency", "vaibhav" };

            for (int i = 0; i < studant.Length; i++)
            {
                Console.WriteLine(studant);
                foreach (string studants in studant[i])
                {
                    Console.WriteLine(studants);
                }
                Console.WriteLine();
            }


            // Write a program to store the prices of 5 products using a 1D array.

            // int[] price={299,599,199,99,999};
            // for(int i=0;i<price.Length;i++){
            //     Console.WriteLine($"products{i+ 1}:{price[i]}");
            // }

            //Create a 2D array representing a 4x3 matrix and display the elements.

            // int[,] matrix={{1,2,3},{4,5,6},{7,8,9},{10,11,12}};
            // for(int i=0;i<4;i++){
            //     for(int j=0;j<3;j++){
            //         Console.WriteLine(matrix[i,j]);
            //     }
            //     Console.WriteLine();
            // }


            // Implement a jagged array where each row represents a city, 
            // and each city has a different number of hotels.

            string[][] cityahotal = new string[][]{
            new string[]{"Hotel A", "Hotel B", "Hotel C"},
             new string[]{"Hotel R", "Hotel E"},
              new string[]{"Hotel Y"}
        };
            for (int i = 0; i < cityahotal.Length; i++)
            {
                for (int j = 0; j < cityahotal[i].Length; j++)
                {
                    Console.WriteLine(cityahotal[i][j]);
                }
                Console.WriteLine();
            }

            // Multi-Dimensional Arrays (3D & More)
            // 3D arrays store data in three dimensions (useful for storing 3D models, colors, or 3D grids).
            int[,,] cube ={
             { {1, 2}, {3, 4} },
             { {5, 6}, {7, 8} }
        };
            //Console.WriteLine(cube[1, 0, 1]); 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(cube[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
