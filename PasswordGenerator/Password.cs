using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator
{
    public class Password
    {
        public int Length { get; set; }
        public string PasswordGenerated = "";

        private static readonly char[] uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] lowercaseLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] numbers = "123456789".ToCharArray();
        private static readonly char[] specialSigns = "!@#$%^&*()_-+=".ToCharArray();

        public char[][] AllSigns = new char[][] { uppercaseLetters, lowercaseLetters, numbers, specialSigns };

        Random random = new Random();
        
        public Password(int length)
        {
            // set password length
            if (length >= 6)
            {
                Length = length;
                Console.WriteLine("Password length set to: " + Length);
            }
            else
            {
                Length = 6;
                Console.WriteLine("Invalid password length. Password length set to: " + Length);

            }
        }

        public string Generate()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < Length; i++)
            {
                //generate password with n = Length chars
                int RandomArray = random.Next(0, AllSigns.Length);
                int ArrayLimit = AllSigns[RandomArray].Length;
                int RandomChar = random.Next(0, ArrayLimit);

                builder.Append(AllSigns[RandomArray][RandomChar]);
                
            }

            PasswordGenerated = builder.ToString(); 

            return PasswordGenerated;
        }

        public void Display()
        {
            Console.WriteLine("Randomly generated password: " + PasswordGenerated);
        }
    }
}
