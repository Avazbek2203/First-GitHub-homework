using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber;
        while (!int.TryParse(Console.ReadLine(), out decimalNumber))
        {
            Console.WriteLine("Enter only an integer number, please! ");
            Console.Write("Enter a decimal number: ");
        }

        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine("Binary number: " + binaryNumber);
    }
}