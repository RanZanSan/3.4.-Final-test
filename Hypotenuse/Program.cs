using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            int cathetusOne = Convert.ToInt32(Console.ReadLine());
            int cathetusTwo = Convert.ToInt32(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(cathetusOne, 2) + Math.Pow(cathetusTwo, 2));

            Console.WriteLine(hypotenuse);
            Console.ReadKey();
        }
    }
}