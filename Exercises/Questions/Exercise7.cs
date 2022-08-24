using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
    Test Data:
    Input the first number: 25
    Input the second number: 4
    Expected Output:
    25 + 4 = 29
    25 - 4 = 21
    25 x 4 = 100
    25 / 4 = 6
    25 mod 4 = 1
*/

namespace Exercises.Questions
{
    internal class Exercise7
    {
        public static void Run()
        {
            Console.WriteLine("Please enter the first number: ");
            byte firstNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            byte secondNumber = byte.Parse(Console.ReadLine());

            byte sum = (byte)(firstNumber + secondNumber);
            byte sub = (byte)(firstNumber - secondNumber);
            byte mult = (byte)(firstNumber * secondNumber);
            byte div = (byte)(firstNumber / secondNumber);
            byte mod = (byte)(firstNumber % secondNumber);

            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Subtraction is: " + sub);
            Console.WriteLine("Multiplication is: " + mult);
            Console.WriteLine("The Mod is: " + mod);
        }
    }
}
