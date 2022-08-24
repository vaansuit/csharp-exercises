using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
    Test Data:
    Enter the First number: 10
    Enter the Second number: 15
    Enter the third number: 20
    Enter the four number: 30

    Expected Output:
    The average of 10 , 15 , 20 , 30 is: 18
 
 */

namespace Exercises.Questions
{
    internal class Exercise9
    {
        public static void Run()
        {
            Console.WriteLine("Please, enter the first number: ");
            byte firstNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            byte secondNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            byte thirdNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fourth number: ");
            byte fourthNumber = byte.Parse(Console.ReadLine());

            var allInputNumbers = new int[] { firstNumber, secondNumber, thirdNumber, fourthNumber };
            double averageNumber = Queryable.Average(allInputNumbers.AsQueryable());

            Console.WriteLine("The avarege number of the inputs is: " + averageNumber);
        }
    }
}
