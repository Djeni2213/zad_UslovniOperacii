using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            Console.WriteLine("=========================");

            bool hasUpper = false;
            bool hasNum = false;
            bool hasSpace = password.Contains(" ");

            foreach (char element in password)
            {
                if (char.IsUpper(element))
                {
                    hasUpper = true;
                }
                if (char.IsDigit(element))
                {
                    hasNum = true;
                }
            }

            if (password.Length >= 8 && hasUpper && hasNum && hasSpace == false)
            {
                Console.WriteLine("Valid password!!!");
            }
            else
            {
                Console.WriteLine("Invalid pasword!!!");
            }
        }
    }
}
