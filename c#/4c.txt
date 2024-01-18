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
           
 {

int[] numbers = { 10, 20, 30, 40, 50 };

int result = 0;

try
 {

 Console.Write("Enter a number to divide by: ");
int divisor = int.Parse(Console.ReadLine());
 result = numbers[0] / divisor;

 Console.WriteLine("The sixth element of the array is: " + numbers[5]);
 }

catch (DivideByZeroException ex)
 {

 Console.WriteLine("Division by zero exception: " + ex.Message);
 }

catch (IndexOutOfRangeException ex)
 {


 Console.WriteLine("Index out of range exception: " + ex.Message);
 }

finally
 {

 Console.WriteLine("The result of the division is: " + result);
 }
Console.ReadLine();
 }
}
        }
    }

