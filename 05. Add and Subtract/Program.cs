using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = SumOfFirstTwo(first, second);
            int substracted = SubstractSum(sum, third);
            Console.WriteLine(substracted);
        }
        static int SumOfFirstTwo(int first,int second)
        {
            int sum = first + second;
            return sum;
        }
        static int SubstractSum(int sum, int third)
        {
            int substracted = sum - third;
            return substracted;
        }
    }
}
