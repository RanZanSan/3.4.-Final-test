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

            double firstMax = Math.Max(Math.Max(firstNumber, secondNumber), Math.Max(thirdNumber, fourthNumber));
            double secondMin = Math.Min(Math.Max(firstNumber, thirdNumber), Math.Max(secondNumber, fourthNumber));
            double thirdMax = Math.Max(Math.Min(firstNumber, thirdNumber), Math.Min(secondNumber, fourthNumber));
            double fourthMin = Math.Min(Math.Min(firstNumber, secondNumber), Math.Min(thirdNumber, fourthNumber));

            Console.Write(firstMax);
            Console.Write(secondMin);
            Console.Write(thirdMax);
            Console.Write(fourthMin);
            Console.ReadKey();
        }
    }
}