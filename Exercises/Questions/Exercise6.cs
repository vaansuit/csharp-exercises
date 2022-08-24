using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
    Test Data:
    Input the first number to multiply: 2
    Input the second number to multiply: 3
    Input the third number to multiply: 6
    Expected Output:
    2 x 3 x 6 = 36
 */
namespace Exercises
{
    internal class Exercise6
    {
        public static void Run()
        {
            Console.WriteLine("Please insert the first number to multiply: ");
            byte firstNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please inser the second number to multiply: ");
            byte secondNUmber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please inser the third number to multiply: ");
            byte thirdNumber = byte.Parse(Console.ReadLine());

            byte result = (byte)(firstNumber * secondNUmber * thirdNumber);

            Console.WriteLine("The result is: " + result);
        }
    }
}
