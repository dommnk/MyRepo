using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter password length. (No less than 6).");
                try
                {
                    int passwordLength = int.Parse(Console.ReadLine());
                    var password = new Password(passwordLength);
                    password.Generate();
                    password.Display();

                }
                catch (Exception FormatException)
                {
                    Console.WriteLine(FormatException.Message);
                }

                Console.WriteLine("Generate new password? (Y/N)");
                string toContinue = Console.ReadLine();

                if (toContinue == "N" || toContinue == "n")
                    break;           
            }

        }
    }
}
