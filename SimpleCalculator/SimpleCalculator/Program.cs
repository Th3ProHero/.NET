using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 1;
            byte OPTION;
            double number1, number2, result;

            while (answer == 1)
            {
                Console.WriteLine("HI! THIS IS A SIMPLE CALCULATOR");
                Console.WriteLine("PLEASE SELECT AN OPTION");
                Console.WriteLine("1. SUM 2 NUMBERS");
                Console.WriteLine("2. REST 2 NUMBERS");
                Console.WriteLine("3. MULTIPLY 2 NUMBERS");
                Console.WriteLine("4. DIVIDE 2 NUMBERS");
                Console.WriteLine("INPUT A VALID NUMBER");

                OPTION = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("INSERT THE FIRST NUMBER");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("INSERT THE SECOND NUMBER");
                number2 = Convert.ToDouble(Console.ReadLine());

                switch (OPTION)
                {
                    case 1:
                        result = number1 + number2;
                        Console.WriteLine("The sum of the number {0} and {1} is {2}", number1, number2, result);
                        break;
                    case 2:
                        result = number1 - number2;
                        Console.WriteLine("The rest of the number {0} and {1} is {2}", number1, number2, result);
                        break;
                    case 3:
                        result = number1 * number2;
                        Console.WriteLine("The result of multiply of the number {0} and {1} is {2}", number1, number2, result);
                        break;
                    case 4:
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            Console.WriteLine("The division of the number {0} and {1} is {2}", number1, number2, result);
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        answer = 1;
                        break;
                }

                Console.WriteLine("Return to menu? 1 YES 2 NO");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("SEE YOU NEXT TIME");
        }
    }
}
