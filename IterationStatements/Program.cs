using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0

            List<int> numbers = new List<int>();

            int i = 0;
            //numbers.Add(1);
            

            // Create a do-while loop
            {
               
                // Then add your variable to "numbers"

                do
                {
                    // Increment your variable by 1
                    i++;
                    // Then add your variable to "numbers"
                    numbers.Add(i);
                    // Console.WriteLine($"i = {i} and list is {numbers[1]}");
                } while (i < 100);
            }
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            {
                while (i < 200)
                {
                    // Increment your variable by 1
                    i += 1;
                    // Then add your variable to "numbers"
                    numbers.Add(i);
                }


                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(int j = 199; j <= numbers.Count && j > 0; j--)
            {

                // Write to the console "numbers" at index i
                Console.WriteLine($"The number {numbers[j]} is at the {j} index");
            }

        }
    }
}
