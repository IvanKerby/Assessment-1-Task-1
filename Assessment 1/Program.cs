using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables to store the sum and the current number
            int sum = 0;
            int currentnumber = 1;

            // Use a while loop to iterate from 1 to 100
            while (currentnumber <= 100)
            {
                // Check if the current number is a multiple of 3 or 5
                if (currentnumber % 3 == 0 || currentnumber % 5 == 0)
                {
                    // Add the current number to the sum
                    sum += currentnumber;
                }

                // Increment the current number
                currentnumber++;
            }

            // Display the result
            Console.WriteLine("Enter Your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + "!");
            Console.WriteLine("The sum of multiples of 3 and 5 from 1 to 100 is: " + sum);

            Console.ReadKey();  
        }
    }
}
       