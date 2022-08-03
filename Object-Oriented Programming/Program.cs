using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using First;
//using Second;

namespace Object_Oriented_Programming
{
    class Program //: ProctedTest
    {
        static void Main(string[] args)
        {
            //--Inheritance-------------------------------------------------------------------------------
            //Programmer p1 = new Programmer();
            //Console.WriteLine("Salary : " + p1.salary);
            //Console.WriteLine("Bonus : " + p1.bonus);
            //Console.ReadLine();

            //BabayDog b1 = new BabayDog();
            //b1.eat();
            //b1.bark();
            //b1.Weep();
            //Console.ReadLine();


            //--Aggregation------------------------------------------------------------------------------
            //Address a1 = new Address("G-13,Sec-3", "Noida", "UP");
            //Employee e1 = new Employee(1, "Ramesh", a1);
            //e1.display();
            //Console.ReadLine();


            //--Polymorphism-----------------------------------------------------------------------------
            //Member Overloading--------------------
            //Console.WriteLine(cal.add(4, 5));
            //Console.WriteLine(cal.add(4.9f, 5.1f));
            //Console.ReadLine();

            //Method Overriding--------------------
            //Dog d = new Dog();
            //d.eat();
            //Console.ReadLine();

            //Base Keyword-------------------------
            //Dog d = new Dog();
            //d.showColor();
            //Console.ReadLine();

            //Dog d = new Dog();
            //d.eat();
            //Console.ReadLine();

            //Dog d = new Dog();
            //Console.ReadLine();

            //Polymorphism-------------------------
            //Shape s;
            //s = new Shape();
            //s.draw();
            //s = new Rectangle();
            //s.draw();
            //s = new Circle();
            //s.draw();
            //Console.ReadLine();

            //Sealed-------------------------------
            //class
            //Dog d = new Dog();
            //d.eat();//error
            //d.bark();

            //Method
            //Dog d = new Dog();
            //d.run();
            //d.eat();

            //BabyDog b = new BabyDog();
            //b.eat();
            //b.run();
            //Console.ReadLine();


            //--Abstraction------------------------------------------------------------------------------
            //Abstract Class------------------------------
            //Shape s;
            //s = new rectangle();
            //s.draw();
            //s = new circle();
            //s.draw();
            //Console.ReadLine();

            //Interface-----------------------------------
            //Shape s;
            //s = new rectangle();
            //s.draw();
            //s = new circle();
            //s.draw();
            //Console.ReadLine();


            //--Namespace--------------------------------------------------------------------------------
            //First.Hello h1 = new First.Hello();
            //Second.Hello h2 = new Second.Hello();
            //h1.sayHello();
            //h2.sayHello();
            //Console.ReadLine();

            //Hello h1 = new Hello();
            //Welcome w1 = new Welcome();
            //h1.sayHello();
            //w1.sayWelcome();
            //Console.ReadLine();

            //Access Modifiers / Specifiers----------------

            //Protected-----
            //ProctedTest pt = new ProctedTest();
            //Console.WriteLine("Hello" + pt.name);//Error Protected Protection level
            //pt.Msg("Swami Ayyer");//Error Protected Protection level

            //Program p1 = new Program();
            //Console.WriteLine("Hello " + p1.name);
            //p1.Msg("Swami Ayyer");
            //Console.ReadKey();

            //Internal-----
            //InternalTest it = new InternalTest();
            //Console.WriteLine("Hello "+it.name);
            //it.Msg("Yash Savaliya");
            //Console.ReadKey();

            //Protected Internal-----
            //InternalTest it = new InternalTest();
            //Console.WriteLine("Hello " + it.name);
            //it.Msg("Yash Savaliya");
            //Console.ReadKey();

            //Private1-----
            //PrivateTest pt = new PrivateTest();
            //Console.WriteLine("Hello "+ pt.name); //Error Private Protection Level
            //pt.Msg("Yash Savaliya"); //Error Private Protection Level

            //Private2-----
            //Program p1 = new Program();
            //Console.WriteLine("Hello " + p1.name);
            //p1.Msg("Yash Savaliya");
            //Console.ReadKey();


            //Encapsulation--------------------------------
            //Student st = new Student();
            //st.ID = 101;
            //st.Name = "Yash";
            //st.Email = "ys123456@gmail.com";
            //Console.WriteLine("ID = " + st.ID);
            //Console.WriteLine("Name = " + st.Name);
            //Console.WriteLine("Email = " + st.Email);
            //Console.ReadKey();
        }

        //Private2-----
        //private string name = "Yash";
        //private void Msg(string msg)
        //{
        //    Console.WriteLine("Hello " + msg);
        //}
    }
    //--Inheritance--------------------------------------------------------------------------------------
    //public class Employee
    //{
    //    public float salary = 40000;
    //}
    //public class Programmer : Employee
    //{
    //    public float bonus = 10000;
    //}

    //public class Animal
    //{
    //    public void eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}
    //public class Dog:Animal
    //{
    //    public void bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}
    //public class BabayDog:Dog
    //{
    //    public void Weep()
    //    {
    //        Console.WriteLine("Weeping...");
    //    }
    //}


    //--Aggregation----------------------------------------------------------------------------------------
    //public class Address
    //{
    //    public string addressLine, city, state;
    //    public Address(string addressLine, string city, string state)
    //    {
    //        this.addressLine = addressLine;
    //        this.city = city;
    //        this.state = state;
    //    }
    //}
    //public class Employee
    //{
    //    public int id;
    //    public string name;
    //    public Address address;
    //    public Employee(int id, string name, Address address)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.address = address;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + address.addressLine + " " + address.city + " " + address.state);
    //    }
    //}


    //--Polymorphism-----------------------------------------------------------------------------------------
    //Member Overloading---------------------------
    //By changing no. of arguments
    //public class cal
    //{
    //    public static int add(int a,int b)
    //    {
    //        return a + b;
    //    }
    //    public static int add(int a,int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //}

    //By changing data type of arguments
    //public class cal
    //{
    //    public static int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public static float add(float a, float b)
    //    {
    //        return a + b;
    //    }
    //}

    //Method Overriding-------------------------
    //public class Animal
    //{
    //    public virtual void eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void eat()
    //    {
    //        Console.WriteLine("Eating Bread...");
    //    }
    //}

    //Base Keyword-----------------------------
    //public class Animal
    //{
    //    public string color = "White";
    //}
    //public class Dog : Animal
    //{
    //    string color = "Black";
    //    public void showColor()
    //    {
    //        Console.WriteLine(base.color);
    //        Console.WriteLine(color);
    //    }
    //}

    //public class Animal
    //{
    //    public virtual void eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void eat()
    //    {
    //        base.eat();
    //        Console.WriteLine("Eating Bread...");
    //    }
    //}

    //public class Animal
    //{
    //    public Animal()
    //    {
    //        Console.WriteLine("animal...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public Dog()
    //    {
    //        Console.WriteLine("dog...");
    //    }
    //}

    //Polymorphism-------------------------
    //public class Shape
    //{
    //    public virtual void draw()
    //    {
    //        Console.WriteLine("drawing...");
    //    }
    //}
    //public class Rectangle : Shape
    //{
    //    public override void draw()
    //    {
    //        Console.WriteLine("drawing rectangle...");
    //    }
    //}
    //public class Circle : Shape
    //{
    //    public override void draw()
    //    {
    //        Console.WriteLine("drawing circle...");
    //    }
    //}

    //Sealed-------------------------------
    //class
    //sealed public class Animal
    //{
    //    public void eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}
    //public class Dog:Animal //Error
    //{
    //    public void bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}

    //Method
    //public class Animal
    //{
    //    public virtual void eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //    public virtual void run()
    //    {
    //        Console.WriteLine("running...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void eat()
    //    {
    //        Console.WriteLine("Eating bread...");
    //    }
    //    public sealed override void run()
    //    {
    //        Console.WriteLine("running very Fast...");
    //    }
    //}
    //public class BabyDog:Dog
    //{
    //    public override void eat()
    //    {
    //        Console.WriteLine("Eating biscuit...");
    //    }
    //    public override void run() //Error
    //    {
    //        Console.WriteLine("running slowely...");
    //    }
    //}


    //--Abstraction------------------------------------------------------------------------------------------
    //Abstract Class----------------------------------
    //public abstract class Shape
    //{
    //    public abstract void draw();
    //}
    //public class rectangle : Shape
    //{
    //    public override void draw()
    //    {
    //        Console.WriteLine("Drawing rectangle...");
    //    }
    //}
    //public class circle : Shape
    //{
    //    public override void draw()
    //    {
    //        Console.WriteLine("Drawing circle...");
    //    }
    //}

    //Interface---------------------------------------
    //public interface Shape
    //{
    //     void draw();
    //}
    //public class rectangle : Shape
    //{
    //    public void draw()
    //    {
    //        Console.WriteLine("Drawing rectangle...");
    //    }
    //}
    //public class circle : Shape
    //{
    //    public void draw()
    //    {
    //        Console.WriteLine("Drawing circle...");
    //    }
    //}


    //Access Modifiers / Specifiers---------------------

    //Protected-----
    //class ProctedTest
    //{
    //    protected string name = "Shashikant";
    //    protected void Msg(string msg)
    //    {
    //        Console.WriteLine("hello " + msg);
    //    }
    //}

    //Internal-----
    //class InternalTest
    //{
    //    internal string name = "Yash";
    //    internal void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}

    //Protected Internal-----
    //class InternalTest
    //{
    //    protected internal string name = "Yash";
    //    protected internal void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}

    //Private1-----
    //class PrivateTest
    //{
    //    private string name = "Yash";
    //    private void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}


    //Encapsulation-------------------------------------
    //class Student
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}
}

//--Namespace------------------------------------------------------------------------------------------
//namespace First
//{
//    public class Hello
//    {
//        public void sayHello() { Console.WriteLine("Hello First Namespace"); }
//    }
//}
//namespace Second
//{
//    public class Hello
//    {
//        public void sayHello() { Console.WriteLine("Hello Second Namespace"); }
//    }
//}

//namespace First
//{
//    public class Hello
//    {
//        public void sayHello() { Console.WriteLine("Hello Namespace"); }
//    }
//}
//namespace Second
//{
//    public class Welcome
//    {
//        public void sayWelcome() { Console.WriteLine("Welcome Namespace"); }
//    }
//}