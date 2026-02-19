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

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpace = password.Contains(" ");

            foreach (char el in password)
            {
                if (char.IsUpper(el))
                {
                    hasUpper = true;
                }
                if (char.IsDigit(el))
                {
                    hasDigit = true;
                } 
            }

            if (password.Length >= 8 && hasUpper && hasDigit && !hasSpace)
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
