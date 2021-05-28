using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclicPermutationsNumbers
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

            int cyclicPermutationsOne = fourthNumber * 1000 + firstNumber * 100 + secondNumber * 10 + thirdNumber;
            int cyclicPermutationsTwo = secondNumber * 1000 + thirdNumber * 100 + fourthNumber * 10 + firstNumber;
            int cyclicPermutationsThree = thirdNumber * 1000 + fourthNumber * 100 + firstNumber * 10 + secondNumber;
            double cyclicPermutationsMax = Math.Max(Math.Max(number, cyclicPermutationsOne), Math.Max(cyclicPermutationsTwo, cyclicPermutationsThree));

            Console.WriteLine(cyclicPermutationsMax);
            Console.ReadKey();
        }
    }
}