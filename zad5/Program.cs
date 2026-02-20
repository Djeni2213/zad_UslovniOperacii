using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year of made: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Power: ");
            int power = int.Parse(Console.ReadLine());

            Console.Write("Does it have a technical review (true/false): ");
            bool hasCheck = bool.Parse(Console.ReadLine());

            if (year > 2010 && power >= 150 && hasCheck)
            {
                Console.WriteLine("It can participate!!!");
            }
            else
            {
                Console.WriteLine("It CAN'T participate!!!");
            }
        }
    }
}
