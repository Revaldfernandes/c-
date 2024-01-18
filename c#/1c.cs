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
            int a = 1;
            while (a == 1)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /, %): ");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case '%':
                        result = num1 % num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        break;
                }

                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);

                Console.Write("If you want to continue, enter 1; otherwise, enter 0: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
