using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //---LINQ Query Syntax-------------------------------------------------------------------------------------------
                //List<int> l = new List<int> { 5, 4, 7, 9, 6, 2, 3, 4, 5, 7, 6, 1, 2, 5, 4 };
                //var QuerySyntax = from num in l
                //                  where num >= 5
                //                  orderby num
                //                  select num;
                //foreach (var item in QuerySyntax)
                //{
                //    Console.Write(item + " ");
                //}
                //Console.ReadKey();


                //---Method Syntax------------------------------------------------------------------------------------------
                //List<int> l = new List<int> { 5, 4, 7, 9, 6, 2, 3, 4, 5, 7, 6, 1, 2, 5, 4 };
                //var MethodSyntax = l.Where(obj => obj >= 5).ToList();

                //foreach (var item in MethodSyntax)
                //{
                //    Console.Write(item + " ");
                //}
                //Console.ReadKey();


                //---Mixed Syntax-------------------------------------------------------------------------------------------
                //List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //var MixedSyntax = (from obj in intList
                //                   where obj > 5
                //                   select obj).Sum();
                //Console.WriteLine("Sum is : " + MixedSyntax);
                //Console.ReadKey();


                //---Lambda Expression--------------------------------------------------------------------------------------
                //List<string> contries = new List<string>() { "India", "Us", "Australia", "Russia" };
                //IEnumerable<string> res = contries.Select(c=>c);
                //foreach(var item in res)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadKey();


                //Aggregate Function---------------------------------------------------------------------------------------------
                //---Min(), Max(), Sum(), Count(), Aggregate() Function---
                //int[] a = { 8, 5, 2, 4, 9, 6, 1, 3, 7 };
                //int minimumNum = a.Min();
                //int maximumNum = a.Max();
                //int sumNum = a.Sum();
                //int countNum = a.Count();
                //int aggregateNum = a.Aggregate((s1,s2)=>s1+s2);
                //int aggregateNum1 = a.Aggregate(func: Max);
                //Console.WriteLine("Minimum Number is : {0}", minimumNum);
                //Console.WriteLine("Maximum Number is : {0}", maximumNum);
                //Console.WriteLine("Sum of Numbers is : {0}", sumNum);
                //Console.WriteLine("Total Number is : {0}", countNum);
                //Console.WriteLine("Aggregate : {0}", aggregateNum);
                //Console.WriteLine("Aggregate1 : {0}", aggregateNum1);
                //Console.ReadKey();


                //Sorting Operators----------------------------------------------------------------------------------------------
                //---OrderBy Operator-------------------------------------
                //List<Student> objStu = new List<Student>() { 
                //new Student(){Name="Suresh Dasari",Gender="Male",Subjects = new List<string>{ "Mathematics","Physics"} },
                //new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
                //new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
                //new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
                //new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
                //};

                //var studentName = objStu.OrderBy(x => x.Name);
                //var studentNameDescending = objStu.OrderByDescending(x => x.Name);

                //Console.WriteLine("Ascending :");
                //foreach (var student in studentName)
                //{
                //    Console.WriteLine("  " + student.Name);
                //}
                //Console.WriteLine("Descending :");
                //foreach (var student in studentNameDescending)
                //{
                //    Console.WriteLine("  " + student.Name);
                //}
                //Console.ReadKey();


                //---ThenBy Operator-------------------------------------
                //List<Student> ObjStu = new List<Student>()
                //{
                //    new Student() { RoleId=1, Name = "Ak", Gender = "Male", Subjects = new List<string> { "Mathematics","Physics"} },
                //    new Student() { RoleId=2, Name = "Shalu", Gender = "Female", Subjects = new List<string> { "Computers", "Botany" } },
                //    new Student() { RoleId=3, Name = "Rohit", Gender = "Male", Subjects = new List<string> { "Economics", "Operating System", "Java" } },
                //    new Student() { RoleId=4, Name = "Rohit", Gender = "Male", Subjects = new List<string> { "Accounting", "Social Studies", "Chemistry" } },
                //    new Student() { RoleId=5, Name = "Shalu", Gender = "FeMale", Subjects = new List<string> { "English", "Charterd" } }
                //};
                //var studentName = ObjStu.OrderBy(x => x.Name).ThenBy(x => x.RoleId);
                //var studentNameDescending = ObjStu.OrderBy(x => x.Name).ThenByDescending(x => x.RoleId);

                //Console.WriteLine("Ascending : ");
                //foreach (var students in studentName)
                //{
                //    Console.WriteLine("  Name = {0} StudentID = {1}",students.Name,students.RoleId);
                //}
                //Console.WriteLine("Descending : ");
                //foreach (var students in studentNameDescending)
                //{
                //    Console.WriteLine("  Name = {0} StudentID = {1}", students.Name, students.RoleId);
                //}
                //Console.ReadKey();


                //---Reverse Operator-------------------------------------
                //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //Console.WriteLine("Before Reverse : ");
                //foreach(int i in arr)
                //{
                //    Console.Write(i + " ");
                //}
                //IEnumerable<int> arrReverse = arr.Reverse();
                //Console.WriteLine();
                //Console.WriteLine("After Reverse : ");
                //foreach(int i in arrReverse)
                //{
                //    Console.Write(i + " ");
                //}
                //Console.ReadKey();


                //Partition Operators--------------------------------------------------------------------------------------------
                //---TAKE PARTITION OPERATOR------------------------------
                //string[] countries = { "India", "China", "UK", "USA", "Russia", "Australia" };
                //IEnumerable<string> res = countries.Take(5);
                //IEnumerable<string> result = (from x in countries select x).Take(3);
                //foreach(string s in res)
                //{
                //    Console.WriteLine("  " + s);
                //}
                //Console.WriteLine("Query Syntax :");
                //foreach (string s in result)
                //{
                //    Console.WriteLine("  " + s);
                //}
                //Console.ReadKey();


                //---TakeWhile Partition Operator-------------------------
                //string[] countries = { "US", "UK", "Russia", "China", "Australia", "Argentina" };
                //IEnumerable<string> res = countries.TakeWhile(x => x.StartsWith("U"));
                //IEnumerable<string> result = (from c in countries select c).TakeWhile(x => x.StartsWith("U"));
                //foreach (string c in res)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.WriteLine("Query Syntax :");
                //foreach (string c in result)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.ReadKey();


                //---SKIP Partition Operator------------------------------
                //string[] countries = { "US", "UK", "Russia", "China", "Australia", "Argentina" };
                //IEnumerable<string> res = countries.Skip(3);
                //IEnumerable<string> result = (from c in countries select c).Skip(3);

                //foreach(string c in res)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.WriteLine("Query Syntax :");
                //foreach (string c in result)
                //{
                //    Console.WriteLine(" "+c);
                //}
                //Console.ReadKey();


                //---SKIPWhile Partition Operator-------------------------
                //string[] countries = { "US", "UK", "Russia", "China", "Australia", "Argentina" };
                //IEnumerable<string> res = countries.SkipWhile(x => x.StartsWith("U"));

                //foreach(string c in res)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.ReadKey();


                //Conversion Operators-------------------------------------------------------------------------------------------
                //---ToList() Method-------------------------------------------
                //string[] countries = { "US", "UK", "Russia", "China", "Australia", "Argentina" };
                //List<string> res = countries.ToList();
                //List<string> result = (from c in countries select c).ToList();
                //foreach(string c in res)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.WriteLine("Query Syntax : ");
                //foreach (string c in result)
                //{
                //    Console.WriteLine("  "+c);
                //}
                //Console.ReadKey();


                //---ToArray() Method-------------------------------------------
                //string a = "Hello World";
                //char[] arr = a.ToArray();
                //char[] arrRes = (from c in a select c).ToArray();

                //Console.WriteLine(arr[6]);
                //foreach(char c in arr)
                //{
                //    Console.Write(c + " ");
                //}
                //Console.WriteLine();
                //Console.WriteLine("=> Query Syntax :");
                //Console.WriteLine(arr[6]);
                //foreach (char c in arr)
                //{
                //    Console.Write(c + " ");
                //}
                //Console.ReadKey();


                //---ToLookup() Method-----------------------------------------
                //List<Employee> objEmp = new List<Employee>()
                //{
                //    new Employee(){Name= "Yash",Department = "IT",Country="India"},
                //    new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                //    new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                //    new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                //    new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}
                //};
                //var emp = objEmp.ToLookup(x => x.Department);
                //var employee = (from c in objEmp select c).ToLookup(x => x.Department);
                //foreach(var kv in emp)
                //{
                //    Console.WriteLine(kv.Key);
                //    Console.WriteLine("------------");
                //    foreach(var item in emp[kv.Key])
                //    {
                //        Console.WriteLine(item.Name + "\t" + item.Department + "\t" + item.Country);
                //        Console.WriteLine();
                //    }
                //}
                //Console.WriteLine("\nQuery Syntax :");
                //Console.WriteLine("----------------------------------------------------------");
                //foreach (var kv in emp)
                //{
                //    Console.WriteLine(kv.Key);
                //    Console.WriteLine("------------");
                //    foreach (var item in emp[kv.Key])
                //    {
                //        Console.WriteLine(item.Name + "\t" + item.Department + "\t" + item.Country);
                //        Console.WriteLine();
                //    }
                //}
                //Console.ReadKey();

                //---Cast() Method---------------------------------------------
                //ArrayList obj = new ArrayList() { "USA", "Australia", "UK", "India" };
                //IEnumerable<string> res = obj.Cast<string>();
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadKey();

                //ArrayList fruits = new ArrayList() { "Mango","Apple","Lemon","Banana"};
                //Console.WriteLine(fruits);
                //IEnumerable<string> query = fruits.Cast<String>().OrderBy(fruit => fruit).Select(fruit => fruit);
                //foreach(string fru in query)
                //{
                //    Console.WriteLine(fru);
                //}
                //Console.WriteLine(query);
                //Console.ReadKey();


                //---OfType() Method-------------------------------------------
                //ArrayList obj = new ArrayList() { "India", "Australia", "China", "USA", "UK", 1, false, 2};
                //IEnumerable<int> res = obj.OfType<int>();
                //foreach(int c in res)
                //{
                //    Console.WriteLine(c);
                //}
                //Console.ReadKey();


                //---AsEnumrable() Method--------------------------------------
                //int[] arr = { 1, 2, 3, 4, 5, 6 };
                //var result = arr.AsEnumerable();
                //foreach(int item in result)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadKey();


                //---ToDictionary() Method-------------------------------------
                //List<Student> objStu = new List<Student>()
                //{
                //    new Student() { Id=1,Name = "Yash", Gender = "Male", Location = "Rajkot" },
                //    new Student() { Id=2,Name = "Vaishali Tyagi", Gender = "Female", Location="Chennai" },
                //    new Student() { Id=3,Name = "Montu Tyagi", Gender = "Male",Location="Bangalore" },
                //    new Student() { Id=4,Name = "Akshay Tyagi", Gender = "Male", Location ="Vizag"},
                //    new Student() { Id=5,Name = "Arpita Rai", Gender = "Male", Location="Nagpur"}
                //};
                //var a = objStu.ToDictionary(x => x.Id, y => y.Name);
                //foreach(var item in a)
                //{
                //    Console.WriteLine(item.Key + " - " + item.Value);
                //}
                //Console.ReadKey();


                //Element Operators----------------------------------------------------------------------------------------------
                int[] arr = { 5, 7, 6, 3, 1, 4, 8, 9, 2 };

                //---First() Element-------------------------------------------
                //Console.WriteLine(arr.First());
                //int res = (from ele in arr select ele).First();
                //Console.WriteLine("By Query Syntax : " + res);

                //---FirstOrDefault() Element-------------------------------------------
                //int[] arr1 = { };
                //Console.WriteLine("Element From arr : {0}", arr.FirstOrDefault());
                //Console.WriteLine("Element From arr1 : {0}", arr1.FirstOrDefault());
                //int res = (from e in arr select e).FirstOrDefault();
                //int res1 = (from e in arr1 select e).FirstOrDefault();
                //Console.WriteLine("Element From arr by query syntax : {0}", res);
                //Console.WriteLine("Element From arr1 by query syntax : {0}", res1);

                //---Last() Element-------------------------------------------
                //Console.WriteLine(arr.Last());
                //int res = (from e in arr select e).Last();
                //Console.WriteLine("By Query Syntax : " + res);

                //---LastOrDefault() Element-------------------------------------------
                //int[] arr1 = { };
                //Console.WriteLine("Element From arr : {0}",arr.LastOrDefault());
                //Console.WriteLine("Element From arr : {0}",arr1.LastOrDefault());
                //int res = (from e in arr select e).LastOrDefault();
                //int res1 = (from e in arr1 select e).LastOrDefault();
                //Console.WriteLine("Element From arr by query syntax : {0}", res);
                //Console.WriteLine("Element From arr1 by query syntax : {0}", res1);

                //---ElementAt() Element-------------------------------------------
                //Console.WriteLine("Element At Index 2 : {0}", arr.ElementAt(2));
                //int res = (from e in arr select e).ElementAt(3);
                //Console.WriteLine("Element At Index 3 : {0}", res);

                //---ElementAtOrDefault() Element-------------------------------------------
                //Console.WriteLine("Element At Index 2 : {0}", arr.ElementAtOrDefault(2));
                //Console.WriteLine("Element At Index 10 : {0}", arr.ElementAtOrDefault(10));
                //int res = (from e in arr select e).ElementAtOrDefault(2);
                //int res1 = (from e in arr select e).ElementAtOrDefault(10);
                //Console.WriteLine("Element At Index 2 By Query Syntax : {0}", res);
                //Console.WriteLine("Element At Index 10 By Query Syntax : {0}", res1);

                //---Single() Element-------------------------------------------
                //List<Student> objStu = new List<Student>()
                //{
                //    new Student() { Name = "Yash", Gender = "Male", Location = "Rajkot"},
                //    new Student() { Name = "Rohini Tyagi", Gender = "Female", Location="Chennai" },
                //    new Student() { Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },
                //    new Student() { Name = "Sateesh Rastogi", Gender = "Male", Location ="Vizag"},
                //    new Student() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}
                //};
                //int[] objList = { 1 };
                //var res = objList.Single();
                //Console.WriteLine("Element from objStu : {0}", objStu.Single(s=>s.Name == "Yash").Name);
                //Console.WriteLine("Element from objList : {0}", res);

                //---SingleOrDefault() Element---------------------------------
                //List<Student> objStu = new List<Student>()
                //{
                //    new Student() { Name = "Yash", Gender = "Male", Location = "Rajkot"},
                //    new Student() { Name = "Rohini Tyagi", Gender = "Female", Location="Chennai" },
                //    new Student() { Name = "Praveen Alavala", Gender = "Male", Location="Bangalore" },
                //    new Student() { Name = "Sateesh Rastogi", Gender = "Male", Location ="Vizag" },
                //    new Student() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur" }
                //};
                //int[] arr1 = { 1, 2, 3, 4, 5 };
                //Console.WriteLine("Element from objStu : {0}", objStu.SingleOrDefault(s => s.Name == "Yash").Name);
                //Console.WriteLine("Element form arr1 : {0}", arr1.SingleOrDefault(s => s > 5));

                //---DefaultfEmpty() Element---------------------------------
                //int[] a = { };
                //int[] b = { 1, 2, 3, 4, 5 };
                //var res1 = a.DefaultIfEmpty();
                //var res2 = b.DefaultIfEmpty();
                //Console.WriteLine("----List1 with Values----");
                //foreach(var v1 in res1)
                //{
                //    Console.WriteLine(v1);
                //}
                //Console.WriteLine("---List2 without Values---");
                //foreach(var v2 in res2)
                //{
                //    Console.WriteLine(v2);
                //}

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
        //---LINQ Min(), Max(), Sum(), Count(), Aggregate() Function-----------
        //private static int Max(int s1,int s2)
        //{
        //    if (s1 > s2)
        //    {
        //        return s1;
        //    }
        //    else
        //    {
        //        return s2;
        //    }
        //}
    }

    //---LINQ OrderBy Operator---------------------------------------
    //class Student
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public List<string> Subjects { get; set; }
    //}

    //---LINQ ThenBy Operator----------------------------------------
    //class Student
    //{
    //    public int RoleId {get;set;}
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public List<string> Subjects { get; set; }
    //}

    //---ToLookup() Method-------------------------------------------
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //    public string Country { get; set; }
    //}

    //---ToDictionary() Method---------------------------------------
    //class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public string Location { get; set; }
    //}

    //---Single()/SingleOrDefault() Element--------------------------
    //class Student
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public string Location { get; set; }
    //}
}
