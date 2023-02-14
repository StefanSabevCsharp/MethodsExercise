using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double factorielFirstNum = FactorielFirstNum(firstNum);
            double factorielSecondNum = FactorielSecondNum(secondNum);
            Console.WriteLine($"{Math.Abs(factorielFirstNum/factorielSecondNum):f2}");
        }
        static double FactorielFirstNum(double firstNum)
        {
            double factorielFirstNum = 1;
            for (double i = firstNum; i > 0; i--)
            {
                factorielFirstNum *= i;
            }
            return factorielFirstNum;
        }
        static double FactorielSecondNum(double secondNum)
        {
            double factorielFirstNum = 1;
            for (double i = secondNum; i > 0; i--)
            {
                factorielFirstNum *= i;
            }
            return factorielFirstNum;
        }
    }
}
