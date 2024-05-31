using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            //ask user name
            Console.Write("Tell me your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}!!!",name);
            Console.WriteLine("Casting numbers !!!");
            string userInput;
            int num1 = 5, num2, result;
            Console.WriteLine("Give me an in number to add");
            userInput = Console.ReadLine();
            //nvert string to int
            num2 =Int32.Parse(userInput);
            result = num1 + num2;
            Console.WriteLine("The result of the sum is {0}", result);

            

        }
    }
}
