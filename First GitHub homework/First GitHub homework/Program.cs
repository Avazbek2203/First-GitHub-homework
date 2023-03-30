using System;

class Program
{
    static void Main()
    {
        int number = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }


        for (int row = 1; row <= number; row++)
        {

            for (int coloumn = 1; coloumn <= number; coloumn++)
            {

                Console.Write("{0,4}", row * coloumn);
            }
            Console.WriteLine();
        }
    }
}