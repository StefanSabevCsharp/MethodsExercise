using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (!IsContainsLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsContainsLetterAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ISContainsTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsContainsLenght(password) && IsContainsLetterAndDigits(password) && ISContainsTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool IsContainsLenght(string password)
        {
            bool contains = password.Length >= 6 && password.Length <= 10;
            return contains;
        }
        static bool IsContainsLetterAndDigits(string password)
        {

            bool result = password.All(Char.IsLetterOrDigit);
            if (result)
            {
                return true;

            }

            return false;
        }
        static bool ISContainsTwoDigits ( string password)
        {
            int counter = 0;

            foreach (char ch in password)
            {
                if (ch >= 48 && ch <= 57)
                {
                    counter++;
                }
            }

            return counter>= 2;
        }
    }
}
