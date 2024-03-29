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
            int rows = int.Parse(Console.ReadLine());

            int[][] triangle = new int[rows][];

            int counter = 1;

            for (int i = 0; i < rows; i++)
            {

                triangle[i] = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {

                    triangle[i][j] = counter;

                    counter++;
                }
            }

            Console.WriteLine("Floyd's Triangle:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {

                    Console.Write(triangle[i][j] + " ");
                }

                Console.WriteLine();
            }
             Console.ReadLine();
        }
       
    }
}
