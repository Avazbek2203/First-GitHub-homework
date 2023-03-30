using System;

class Program
{
    static void Main()
    {
        static void Main(string[] args)
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

        int firstNumber = 0, secondNumber = 1;

        Console.Write(firstNumber + " " + secondNumber + " ");

        for (int i = 2; i < number; i++)
        {
            int thirdNumber = firstNumber + secondNumber;
            Console.Write(thirdNumber + " ");
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
        }

        Console.WriteLine();
    }
}