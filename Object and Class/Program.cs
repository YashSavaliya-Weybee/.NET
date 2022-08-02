using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_Class
{
    class Program
    {
        //int id;
        //String name;
        static void Main(string[] args)
        {
            //Program p1 = new Program();
            //p1.id = 101;
            //p1.name = "Yash";
            //Console.WriteLine(p1.id + " " + p1.name);
            //Console.ReadLine();


            //--Program1------------------------------------------
            //Program1 p1 = new Program1();
            //p1.insert(101, "Yash");
            //p1.display();
            //Console.ReadLine();


            //--Constructor---------------------------------------
            //Employee e1 = new Employee(101, "Yash", 10000);
            //Employee e2 = new Employee(102, "Himanshu", 5000);
            //e1.display();
            //e2.display();
            //Console.ReadLine();


            //--Destructor---------------------------------------
            //Employee e1 = new Employee();
            //Employee e2 = new Employee();


            //--Static-------------------------------------------
            //Account.rateOfInterest = 10.5f;
            //Account a1 = new Account(101, "Sonoo");
            //Account a2 = new Account(102, "Mahesh");
            //Account a3 = new Account(103, "Ramesh");
            //a1.display();
            //a2.display();
            //a3.display();
            //Console.WriteLine("Total Objects are: " + Account.count);
            //Console.ReadLine();


            //--Static class-------------------------------------
            //Console.WriteLine("Value of PI is: " + MyMath.PI);
            //Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));
            //Console.ReadLine();


            //--Satatic constructor------------------------------
            //Account a1 = new Account(101,"Yash");
            //Account a2 = new Account(102,"Himanshu");
            //a1.display();
            //a2.display();
            //Console.ReadLine();


            //--Struct----------------------------------------------
            //Rectangle r1 = new Rectangle();
            //r1.height = 50;
            //r1.width = 10;
            //Console.WriteLine("Area of rectangle : " + r1.width * r1.height);
            //Console.ReadLine();

            //Rectangle r2 = new Rectangle(50, 20);
            //r2.areaOfRectangle();
            //Console.ReadLine();


            //--Enum---------------------------------------------
            //int x = (int)Season.winter;
            //int y = (int)Season.fall;
            //Console.WriteLine("Winter "+x);
            //Console.WriteLine("Fall "+y);
            //Console.ReadLine();

            //int a = (int)Days.Sun;
            //int b = (int)Days.Tue;
            //int c = (int)Days.Sat;
            //Console.WriteLine("Sunday " + a);
            //Console.WriteLine("Tuesday " + b);
            //Console.WriteLine("Saturday " + c);
            //Console.ReadLine();

            //foreach (string s in Enum.GetNames(typeof(Days)))  //OR
            //foreach (Days d in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(d);
            //}
            //Console.ReadLine();
        }
    }

    //--Program1-------------------------------------------------
    //public class Program1
    //{
    //    int id;
    //    String name;
    //    public void insert(int i,String n)
    //    {
    //        id = i;
    //        name = n;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id +" "+ name);
    //    }
    //}


    //--Constructor---------------------------------------------
    //public class Employee
    //{
    //    public int id;
    //    public String name;
    //    public float salary;
    //    public Employee(int i, String n, float s)
    //    {
    //        id = i;
    //        name = n;
    //        salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}


    //--Destructor----------------------------------------------
    //public class Employee
    //{
    //    public Employee()
    //    {
    //        Console.WriteLine("Constructor Invoked");
    //    }
    //    ~Employee()
    //    {
    //        Console.WriteLine("Destructor Invoked");
    //        Console.ReadLine();
    //    }
    //}


    //--This---------------------------------------------------
    //public class Employee
    //{
    //    public int id;
    //    public String name;
    //    public float salary;
    //    public Employee(int id, String name, float salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}


    //--Static-------------------------------------------------
    //public class Account
    //{
    //    public int accno;
    //    public String name;
    //    public static float rateOfInterest = 8.8f;
    //    public static int count = 0;
    //    public Account(int accno, String name)
    //    {
    //        this.accno = accno;
    //        this.name = name;
    //        count++;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
    //    }
    //}


    //--Static Class-------------------------------------------
    //public static class MyMath
    //{
    //    public static float PI = 3.14f;
    //    public static int cube(int n) { return n * n * n; }
    //}


    //--Satatic constructor-----------------------------------
    //public class Account
    //{
    //    public int id;
    //    public String name;
    //    public static float rateOfInterest;
    //    public Account(int id, String name)
    //    {
    //        this.id = id;
    //        this.name = name;
    //    }
    //    static Account()
    //    {
    //        rateOfInterest = 9.5f;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + rateOfInterest);
    //    }
    //}


    //--Struct----------------------------------------------
    //public struct Rectangle
    //{
    //    public int width, height;

    //    public Rectangle(int w, int h)
    //    {
    //        width = w;
    //        height = h;
    //    }
    //    public void areaOfRectangle()
    //    {
    //        Console.WriteLine("Area of Rectangle is: " + (width * height));
    //    }
    //}


    //--Enum-------------------------------------------------
    //public enum Season
    //{
    //    //winter, spring, summer, fall
    //    winter = 10, spring, summer, fall
    //}
    //public enum Days
    //{
    //    Sun, Mon, Tue, Wed, Thu, Fri, Sat
    //}
}
