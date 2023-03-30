namespace Uchinchi_dars_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number : ");
            string firstInput = Console.ReadLine();
            int firstNumber;
            while (!int.TryParse(firstInput, out firstNumber))
            {
                Console.WriteLine("Please input only number for the first input!");
                Console.Write("Enter first number : ");
            }

            Console.Write("Enter second number : ");
            string secondInput = Console.ReadLine();
            int secondNumber;
            while (!int.TryParse(secondInput, out secondNumber))
            {
                Console.WriteLine("Please input only number for the second input!");
                Console.Write("Enter second number : ");


            }

            if (firstNumber == secondNumber)
            {
                Console.WriteLine((firstNumber + secondNumber) * 3);
            }
            else
            {
                Console.WriteLine(firstNumber + secondNumber);

            }
            Main(args);

        }
    }
}