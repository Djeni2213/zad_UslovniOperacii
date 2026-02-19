using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the person's age, if he has a registration(yes/no) and if he has a subscribtion(yes/no)");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            string[] info = Console.ReadLine().Split(' ').ToArray();
            if(int.Parse(info[0]) >= 18 && info[1].ToLower() == "yes")
            {
                Console.WriteLine("Acsess granted!");
            }
            else if (info[2].ToLower() != "yes" || int.Parse(info[0]) < 18)
            {
                Console.WriteLine("Acsess restricted!");
            }
            else if(info[1].ToLower() != "yes" && info[2].ToLower() != "yes")
            {
                Console.WriteLine("Acsess denied!");
            }

            
        }
    }
}
