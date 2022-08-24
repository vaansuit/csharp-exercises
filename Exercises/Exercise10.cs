using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
    Test Data:
    Enter first number - 5
    Enter second number - 6
    Enter third number - 7

    Expected Output:
    Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 */
namespace Exercises
{
    internal class Exercise10
    {
        public static void Run()
        {
            Console.WriteLine("Please, input the first number: ");
            byte firstNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the second number: ");
            byte secondNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Pleanse, input the third number: ");
            byte thirdNumber = byte.Parse(Console.ReadLine());

            byte firstResult = (byte)((firstNumber + secondNumber) * thirdNumber);
            byte secondResult = (byte)(firstNumber * secondNumber + secondNumber * thirdNumber);

            Console.WriteLine("The results are: " + firstResult + " and " + secondResult);
        }
    }
}
