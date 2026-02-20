using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Равностранен триъгълник");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Равнобедрен триъгълник");
                }
                else
                {
                    Console.WriteLine("Разностранен триъгълник");
                }
            }
            else
            {
                Console.WriteLine("Не може да се образува триъгълник!");
            }
        }
    }
}
