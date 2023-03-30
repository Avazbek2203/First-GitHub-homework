using System;

class Program
{
    static void Main()
    {
        double number = 0;
        bool validNumber = false;

        while (!validNumber)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out number))
            {
                validNumber = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}