using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int fourthNumber = number % 10;
            int thirdNumber = (number % 100) / 10;
            int secondNumber = (number % 1000) / 100;
            int firstNumber = (number % 10000) / 1000;

            double firstNumbersMax = Math.Max(Math.Max(firstNumber, secondNumber), Math.Max(thirdNumber, fourthNumber));
            double secondNumbersMax = Math.Min(Math.Max(Math.Min(firstNumber, secondNumber), Math.Max(thirdNumber, fourthNumber)), Math.Max(Math.Min(firstNumber, secondNumber), Math.Max(thirdNumber, fourthNumber)));
            double thirdNumbersMax = Math.Max(Math.Min(Math.Max(firstNumber, secondNumber), Math.Min(thirdNumber, fourthNumber)), Math.Min(Math.Min(firstNumber, secondNumber), Math.Max(thirdNumber, fourthNumber)));
            double fourthNumbersMin = Math.Min(Math.Min(firstNumber, secondNumber), Math.Min(thirdNumber, fourthNumber));

            Console.Write(firstNumbersMax);
            Console.Write(secondNumbersMax);
            Console.Write(thirdNumbersMax);
            Console.Write(fourthNumbersMin);
        }
    }
}