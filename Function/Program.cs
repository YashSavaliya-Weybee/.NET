using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        //--Function----------------------------------------------------
        //public string ShowString(string message)
        //{
        //    Console.WriteLine("Inside ShowString function");
        //    return message;
        //}
        //public void Show(string message)
        //{
        //    Console.WriteLine("hello, "+message);
        //}


        //--Function Call By value--------------------------------------
        //public void Show(int val)
        //{
        //    val *= val;
        //    Console.WriteLine("Value inside function " + val);
        //}


        //--Function Call By Reference---------------------------------
        //public void Show(ref int val)
        //{
        //    val *= val;
        //    Console.WriteLine("Value inside function " + val);
        //}


        //--Out Parameter----------------------------------------------
        //public void Show(out int val)
        //{
        //    int square = 5;
        //    val = square;
        //    val *= val;
        //}
        static void Main(string[] args)
        {
            //Function-------------------------------------------------
            //Program program = new Program();
            //program.Show("Yash");
            //string message = program.ShowString("Yash");
            //Console.WriteLine(message);
            //Console.ReadLine();


            //--Function Call By value---------------------------------
            //int val = 50;
            //Program program = new Program();
            //Console.WriteLine("Value before callnfg function " + val);
            //program.Show(val);
            //Console.WriteLine("Value after calling function " + val);
            //Console.ReadLine();


            //--Function Call By Reference-----------------------------
            //int val = 50;
            //Program program = new Program();
            //Console.WriteLine("Value before Calling function " + val);
            //program.Show(ref val);
            //Console.WriteLine("Value after calling function " + val);
            //Console.ReadLine();


            //--Out Parameter----------------------------------------------
            //int val = 50;
            //Program program = new Program();
            //Console.WriteLine("Value before passing out variable " + val);
            //program.Show(out val);
            //Console.WriteLine("Value after passing out variable " + val);
            //Console.ReadLine();
        }
    }
}
