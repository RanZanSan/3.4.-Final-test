using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int an = a1 + d * (n - 1);

            Console.WriteLine(an);
            Console.ReadKey();
        }
    }
}