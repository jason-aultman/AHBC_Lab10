using System;
using System.Linq;

namespace AHBC_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = false;
            do
            {
                var radius = GetValidatedUserInput();
                Circle circle = new Circle(radius);
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                again = DoAgain();
            } while (again);


        }
        public static double GetValidatedUserInput()
        {
            string input;
            do
            {
                System.Console.Clear();
                Console.WriteLine("Enter a radius:");
                input = Console.ReadLine();
            } while (!Validator.CheckValidInputPositiveDouble(input));
            return int.Parse(input);
        }
        public static bool DoAgain()
        {
            Console.WriteLine("Would you like to go again? y/n");
            var again = Console.ReadLine();
            while (!Validator.CheckValidUserInputYorN(again))
            {
                Console.WriteLine("Invalid input, try again! :");
                again = Console.ReadLine();
            }
            if (again == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Good-bye.  You made {Circle.count} circles");
                return false;
            }
                
        }
    }
}
