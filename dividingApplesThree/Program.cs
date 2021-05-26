using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividingApplesThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            //Несложно прийти к формуле(n-k % n)% n: вычитаем количество учеников, получивших наибольшее число яблок из числа всех учеников и берем остаток от деления на n на случай,
            //если таких учеников нет.

            int a = (k / n) * n;
            int b = k - a;
            int c = n - b;
            int d = c % n;

            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}