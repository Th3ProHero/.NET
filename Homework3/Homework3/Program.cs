using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optionMenu,exercise1,exercise2;
            double exercise3;
            bool loopContinue=true;
            while (loopContinue) {
                Console.WriteLine("HOMEWORK_3");
                Console.WriteLine("PLEASE, SELECT AN OPTION TO START");
                Console.WriteLine("1.MONTHS");
                Console.WriteLine("2.EVEN/ODD NUMBER");
                Console.WriteLine("3.PARKING");

                optionMenu=Convert.ToInt32(Console.ReadLine());

                switch (optionMenu)
                {
                    case 1:
                        Console.WriteLine("Insert a number");
                        exercise1 = Convert.ToInt32(Console.ReadLine());

                        if (exercise1 == 1)
                        {
                            Console.WriteLine("THE MONTH IS JANUARY");
                        }

                        if (exercise1 == 2)
                        {
                            Console.WriteLine("THE MONTH IS FEBRUARY");
                        }

                        if (exercise1 == 3)
                        {
                            Console.WriteLine("THE MONTH IS MARCH");
                        }

                        if (exercise1 == 4)
                        {
                            Console.WriteLine("THE MONTH IS APRIL");
                        }

                        if (exercise1 == 5)
                        {
                            Console.WriteLine("THE MONTH IS MAY");
                        }
                        if (exercise1 == 6)
                        {
                            Console.WriteLine("THE MONTH IS JUNY");
                        }
                        if (exercise1 == 7)
                        {
                            Console.WriteLine("THE MONTH IS JULY");
                        }
                        if (exercise1 == 8)
                        {
                            Console.WriteLine("THE MONTH IS AUGUST");
                        }
                        if (exercise1 == 9)
                        {
                            Console.WriteLine("THE MONTH IS SEPTEMBER");
                        }
                        if (exercise1 == 10)
                        {
                            Console.WriteLine("THE MONTH IS OCTOBER");
                        }
                        if (exercise1 == 11)
                        {
                            Console.WriteLine("THE MONTH IS NOVEMBER");
                        }
                        if (exercise1 == 12)
                        {
                            Console.WriteLine("THE MONTH IS DECEMBER");
                        }
                        break;


                    case 2:
                        Console.WriteLine("GIVE ME AN INT NUMBER");
                        try
                        {
                            exercise2 = Convert.ToInt32(Console.ReadLine());
                            if (exercise2 % 2 == 0)
                            {
                                Console.WriteLine("YOUR NUMBER IS EVEN");
                            }
                            else
                            {
                                Console.WriteLine("YOUR NUMBER IS ODD");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("THIS IS NOT A NUMBER");
                        }
                        break;
                    case 3:
                        Console.WriteLine("INSERT YOUR MINS TO CALCULATE YOUR BILL");
                        exercise3= Convert.ToDouble(Console.ReadLine());
                        if (exercise3 <= 60)
                        {
                            Console.WriteLine("YOU MUST BE PAY $5.00 PLASE");
                        }
                        if (exercise3 > 60 && exercise3 <= 120)
                        {
                            Console.WriteLine("YOU MUST BE PAY $15.00 PLASE");
                        }
                        if(exercise3 >120)
                        {
                            Console.WriteLine("YOU MUST BE PAY $20.00 PLASE");
                        }
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        Console.Clear();
                        loopContinue =true;
                        break;
                }

             

            }
        }
    }
}
