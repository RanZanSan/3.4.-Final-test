using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysisThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 67;
            m = m + 13;
            int n = m / 4 - m / 2;
            int c = m - n;

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}