using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a C# Sharp program to swap two numbers.
 * Test Data:
    Input the First Number : 5
    Input the Second Number : 6
    Expected Output:
    After Swapping :
    First Number : 6
    Second Number : 5
*/

namespace Exercises.Questions
{
    internal class Exercise5
    {
        public static void Run()
        {
            Console.WriteLine("Inform the first number:");
            byte firstNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Inform the second number:");
            byte secondNumber = byte.Parse(Console.ReadLine());

            byte temp;

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("Now first number is: " + firstNumber);
            Console.WriteLine("Now second number is: " + secondNumber);
            

        }
    }
}
