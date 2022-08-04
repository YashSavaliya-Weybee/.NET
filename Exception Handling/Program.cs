using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Try/Catch------------------------------------------------------------------------
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int x = a / b;
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }

            //Console.WriteLine("Rest of the code");
            //Console.ReadKey();


            //---Finally-------------------------------------------------------------------------
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int x = a / b;
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block is Executed");
            //}
            //Console.WriteLine("Rest of the code");
            //Console.ReadKey();


            //---User-Defined Exceptions--------------------------------------------------------
            //try
            //{
            //    Console.WriteLine("Enter age : ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    validate(age);
            //    Console.ReadKey();
            //}
            //catch(InvalidAgeException e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("Rest of the Code");
            //Console.ReadKey();


            //---Checked and Unchecked----------------------------------------------------------
            //checked
            //{
            //    int val = int.MaxValue;
            //    Console.WriteLine(val + 2); // Error : 'Arithmetic operation resulted in an overflow.'

            //}
            //Console.ReadKey();

            //unchecked
            //{
            //    int val = int.MaxValue;
            //    Console.WriteLine(val + 2); 

            //}
            //Console.ReadKey();


            //---SystemException----------------------------------------------------------------
            //try
            //{
            //    int[] arr = new int[5];
            //    arr[10] = 50;
            //}
            //catch(SystemException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadKey();
        }

        //---User-Defined Exceptions------------------------------------------------------------
        //static void validate(int age)
        //{
        //    if (age < 18)
        //    {
        //        throw new InvalidAgeException("Sorry, Age is less than 18");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You are {0}", age);
        //    }
        //}
    }

    //---User-Defined Exceptions---------------------------------------------------------------
    //public class InvalidAgeException : Exception
    //{
    //    public InvalidAgeException(string message):base(message)
    //    {

    //    }
    //}
}
