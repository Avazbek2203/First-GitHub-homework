using System;

namespace Uchinchi_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height in santimeters: ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Please enter your height in meters as a number!");
                Console.Write("Enter your height in santimeters: ");
            }

            Console.Write("Enter your weight in kilograms: ");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Please enter your weight in kilograms as a number!");
                Console.Write("Enter your weight in kilograms: ");
            }

            double bmi = weight / height * weight;

            Console.WriteLine($"Your BMI is {bmi:F2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("You are normal weight.");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }


            Main(args);
        }
    }
}


