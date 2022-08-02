using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++) {
                char charData;
                int a = 65;
                for (int j = 1; j <= i*2-1; j++)
                {
                    if(j< (i*2-1)/2 +1 )
                    {
                        charData = (char)a;
                        Console.Write(charData+" ");
                        a++;
                    }
                    else
                    {
                        charData = (char)a;
                        Console.Write(charData+" ");
                        a--;
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
