using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        //Passing array to function---------------------------------------------------
        //static void printArray(int[] arr)
        //{
        //    Console.WriteLine("Print Array element");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //--Params-------------------------------------------------------------------
        //public void Show(params int[] val) // Params Paramater  
        //{
        //    for (int i = 0; i < val.Length; i++)
        //    {
        //        Console.WriteLine(val[i]);
        //    }
        //}
        static void Main(string[] args)
        {

            //--Array-----------------------------------------------------------------
            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 40;
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //int[] arr = new int[] { 10, 20, 30, 40 };
            //int[] arr = { 10, 20, 30, 40 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();

            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //Passing array to function-----------------------------------------------
            //int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            //int[] arr2 = { 12, 23, 44, 11, 54 };
            //printArray(arr1);
            //printArray(arr2);
            //Console.ReadLine();


            //--Multidimensional Array------------------------------------------------
            //int[,] arr = new int[3,3]= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] arr = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  
            //int[,] arr = new int[3, 3];
            //arr[0, 1] = 10;
            //arr[1, 2] = 20;
            //arr[2, 0] = 30;
            //for(int i =0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();


            //--Jagged Arrays------------------------------------------------------
            //int[][] arr = new int[2][];

            //arr[0] = new int[4];
            //arr[1] = new int[6];

            //arr[0] = new int[4] { 11, 21, 56, 78 };
            //arr[1] = new int[6] { 42, 61, 37, 41, 59, 63 };

            //arr[0] = new int[] { 1, 2, 3 };
            //arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //--Params------------------------------------------------------------
            //Program program = new Program(); 
            //program.Show(2, 4, 6, 8, 10, 12, 14);
            //Console.ReadLine();


            //--Array class-------------------------------------------------------
            //int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            //int[] arr2 = new int[6];

            //Console.WriteLine("length of first array: " + arr.Length);

            //printArray(arr);
            //Console.WriteLine("Index position of 25 is " + Array.IndexOf(arr, 25));
            //Array.Sort(arr);
            //Console.Write("First array elements: ");
            //printArray(arr);

            //Console.WriteLine("Index position of 25 is " + Array.IndexOf(arr, 25));

            //printArray(arr2);
            //Array.Copy(arr, arr2, arr.Length);
            //printArray(arr2);

            //printArray(arr);
            //Array.Reverse(arr);
            //printArray(arr);
            //Console.ReadLine();


            //--Command Line Arguments---------------------------------------------
            //Console.WriteLine("Argument length: " + args.Length);
            //Console.WriteLine("Supplied Arguments are:");
            //foreach (Object obj in args)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.Read();
        }
    }
}
