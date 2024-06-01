using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE DESCRIPTION: THIS IS AN AIRPORT, THE CONDITIONS TO CAN FLY IS, HAVE THE 2 MOTORS CHECK, AND HACE 75% OF ENERGY
//BUT YOU CAN FLY IF YOU HAVE 1 MOTOR CHECK AND 100% ENERGY.

namespace LogicOperators_Jetplanes_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            float energy;
            bool propLeft,propRight;
            Console.WriteLine("PUT THE ENERGY LEVEL");
            energy=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("THE RIGHT PROPELLER IS OK?(true/false)");
            propRight=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("THE LEFT PROPELLER IS OK?(true/false)");
            propLeft = Convert.ToBoolean(Console.ReadLine());
            if ((((propRight && propLeft) == true) && (energy >= 75)) || (((propRight || propLeft)) == true && (energy == 100)))
            {
                Console.WriteLine("CONGRATS! YOU CAN FLY");
            }
            else
            {
             Console.WriteLine("Sorry you can´t fly");
            }

        }
    }
}
