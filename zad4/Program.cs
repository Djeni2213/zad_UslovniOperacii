using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Avrage grade: ");
            double grade = double.Parse(Console.ReadLine());

            Console.Write("Number of absenses: ");
            int absences = int.Parse(Console.ReadLine());

            if (grade > 5.50 && absences < 5)
            {
                Console.WriteLine("Exelent student");
            }
            else if (grade >= 4.50 && absences < 10)
            {
                Console.WriteLine("Good student");
            }
            else if (grade < 3.00 || absences > 20)
            {
                Console.WriteLine("Inconsistant student");
            }
            else
            {
                Console.WriteLine("Avrage student");
            }
        }
    }
}
