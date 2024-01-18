using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());

            int[,] pascal = new int[n, n];

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    if (j == 0 || j == i)
                    {
                        pascal[i, j] = 1;
                    }

                    else
                    {
                        pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {

                for (int k = 0; k < n - i - 1; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pascal[i, j] + " ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
