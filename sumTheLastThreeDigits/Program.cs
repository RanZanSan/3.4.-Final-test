using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumTheLastThreeDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int lastNumbers = number % 1000;
            int threeNumbers = lastNumbers % 10;
            int oneNumber = lastNumbers / 100;
            int twoNumber = (lastNumbers / 10) % 10;
            int sumNumbers = oneNumber + twoNumber + threeNumbers;

            Console.WriteLine(sumNumbers);
            Console.ReadKey();
        }
    }
}