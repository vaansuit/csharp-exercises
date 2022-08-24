using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
    Test Data:
    Enter the number: 5
    Expected Output:
    5 * 0 = 0
    5 * 1 = 5
    5 * 2 = 10
    5 * 3 = 15
    ....
    5 * 10 = 50
 */
namespace Exercises.Questions
{
    internal class Exercise8
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            byte multiplicator = 0;

            while (multiplicator <= 10)
            {
                
                int result = number * multiplicator;
                Console.WriteLine(result);
                multiplicator++;
            }



          
        }
    }
}
