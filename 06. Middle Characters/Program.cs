using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            if (myString.Length % 2 == 0)
            {
                Console.WriteLine(myString.Substring((myString.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(myString[myString.Length / 2]);
            }

        }
    }
}
