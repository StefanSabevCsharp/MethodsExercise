using System;
using System.Linq;
namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(CountVowels(text));
        }
        static int CountVowels(string text)
        {
            char[] array = { 'a', 'e', 'y', 'u', 'i', 'o'};

            int counter = 0;

            foreach (char ch in text.ToLower())
            {

                if (array.Contains(ch))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
