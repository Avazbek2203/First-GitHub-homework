using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter celsius degree : ");
        double celsius = double.Parse(Console.ReadLine());

        Console.Write("Entered celsius degree's  KELVIN quantity is : ");
        Console.WriteLine(celsius + 273.15);

        Console.Write("Entered celsius degree's  FAHRENHEIT quantity is : ");
        Console.WriteLine(celsius * 1.8 + 32);

        Console.WriteLine("=============================================");
        Main(args);
    }
}