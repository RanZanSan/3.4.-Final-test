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
        }
    }
}