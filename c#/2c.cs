using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d;
            for (int i = 1; i <= 1000; i++)
            {
                a = i / 100;
                b = (i / 10) % 10; 
                c = i % 10;
                d = a * a * a + b * b * b + c * c * c;
                if (i == d)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
