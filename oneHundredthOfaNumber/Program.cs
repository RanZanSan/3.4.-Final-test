using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneHundredthOfaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int hundredthNumber = (number / 100) % 10;

            Console.WriteLine(hundredthNumber);
            Console.ReadKey();
        }
    }
}