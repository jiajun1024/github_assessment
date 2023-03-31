using System;

namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public static void Main()
        {
            int firstNumber = 1, SecondNumber = 1, nextNumber, numberOfTerms;
            Console.Write("Enter the number of terms: ");
            numberOfTerms = int.Parse(Console.ReadLine());
            
            Console.Write(firstNumber + " " + SecondNumber + " ");

            for(int index = 2; index < numberOfTerms; index++)
            {
                nextNumber = firstNumber + SecondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }
            
            Console.ReadKey();
        }
    }
}