using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //---List--------------------------------------------------------------------------------------------------------
            //var li = new List<string>() { "Yash", "Himanshu", "Bhargav", "Viren", "Yash" };
            //var li = new List<string>();
            //li.Add("Yash");
            //li.Add("Himanshu");
            //li.Add("Bhargav");
            //li.Add("Viren");
            //li.Add("Yash");

            //foreach (string st in li)
            //{
            //    Console.WriteLine(st);
            //}
            //Console.ReadKey();


            //---HashSet-----------------------------------------------------------------------------------------------------
            //var hs = new HashSet<string>() { "Yash", "Himanshu", "Bhargav", "Viren", "Yash" };
            //var hs = new HashSet<string>();
            //hs.Add("Yash");
            //hs.Add("Himanshu");
            //hs.Add("Bhargav");
            //hs.Add("Viren");
            //hs.Add("Yash");

            //foreach (string i in hs)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


            //---SortedSet---------------------------------------------------------------------------------------------------
            //var ss = new SortedSet<string>() { "Yash", "Himanshu", "Bhargav", "Viren", "Yash" };
            //var ss = new SortedSet<string>();
            //ss.Add("Yash");
            //ss.Add("Himanshu");
            //ss.Add("Bhargav");
            //ss.Add("Viren");
            //ss.Add("Yash");

            //foreach(string s in ss)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();


            //---Stack-------------------------------------------------------------------------------------------------------
            //var st = new Stack<string>();
            //Stack<string> st = new Stack<string>();
            //st.Push("Yash");
            //st.Push("Himanshu");
            //st.Push("Bhargav");
            //st.Push("Viren");
            //st.Push("Yash");

            //foreach(string s in st)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Peek Element : " + st.Peek());
            //Console.WriteLine("Pop Element : " + st.Pop());
            //Console.WriteLine("After pop, Peek Element : " + st.Peek());
            //Console.ReadKey();


            //---Queue-------------------------------------------------------------------------------------------------------
            //var que = new Queue<string>();
            //Queue<string> que = new Queue<string>();
            //que.Enqueue("Yash");
            //que.Enqueue("Himanshu");
            //que.Enqueue("Bhargav");
            //que.Enqueue("Viren");
            //que.Enqueue("Yash");

            //foreach (string s in que)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Count : " + que.Count());
            //Console.WriteLine("Peek Element : " + que.Peek());
            //Console.WriteLine("Dequeue Element : " + que.Dequeue());
            //Console.WriteLine("after Dequeue, Peek Element : " + que.Peek());
            //Console.WriteLine("Count : " + que.Count());
            //que.Clear();
            //Console.WriteLine("Count : " + que.Count());
            //Console.ReadKey();


            //---LinkedList--------------------------------------------------------------------------------------------------
            //var ll = new LinkedList<string>();
            //ll.AddLast("Yash");
            //ll.AddLast("Himanshu");
            //ll.AddLast("Bhargav");
            //ll.AddLast("Viren");
            //ll.AddLast("Yash");
            //ll.AddFirst("King");

            //LinkedListNode<string> node = ll.Find("Bhargav");
            //ll.AddBefore(node, "Pragnesh");
            //ll.AddAfter(node, "Jhonty");

            //foreach (string l in ll)
            //{
            //    Console.WriteLine(l);
            //}
            //Console.ReadKey();


            //---Dictionary--------------------------------------------------------------------------------------------------
            //Dictionary<int,string> dic = new Dictionary<int, string>();
            //dic.Add(1, "Yash");
            //dic.Add(2, "Himanshu");
            //dic.Add(3, "Bhargav");
            //dic.Add(4, "Viren");

            //foreach(KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine(kv.Key + " : " + kv.Value);
            //}
            //Console.ReadKey();

            //---SortedDictionary--------------------------------------------------------------------------------------------
            //SortedDictionary<int, string> sdic = new SortedDictionary<int, string>();
            //sdic.Add(1, "Yash");
            //sdic.Add(4, "Himanshu");
            //sdic.Add(2, "Bhargav");
            //sdic.Add(5, "Pragnesh");
            //sdic.Add(3, "Viren");

            //foreach(KeyValuePair<int,string> kv in sdic)
            //{
            //    Console.WriteLine(kv.Key + " : " + kv.Value);
            //}
            //Console.ReadLine();


            //---SortedList--------------------------------------------------------------------------------------------------
            //SortedList<string, string> sl = new SortedList<string, string>();
            //sl.Add("2", "Himanshu");
            //sl.Add("1", "Yash");
            //sl.Add("5", "Pragnesh");
            //sl.Add("3", "Bhargav");
            //sl.Add("4", "Viren");

            //foreach(KeyValuePair<string,string> kv in sl)
            //{
            //    Console.WriteLine(kv.Key + " : " + kv.Value);
            //}
            //Console.ReadKey();
        }
    }
}
