using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //for (int i = 1; i<=10; i++)
            //{
            //    int x = random.Next(-40, 40);
            //    Console.WriteLine(x);
            //}
            //Console.Read();

            //int count = 0;
            //Random random = new Random();
            //for (int i = 1; i <= 15; i++)
            //{
            //    double x = -20 + 50 * random.NextDouble();
            //    Console.WriteLine(x);
            //    if (x > 0)
            //    { count++; }
            //}
            //Console.WriteLine($"Кол-во положительных чисел ={count}");

            Random random = new Random();

            Console.WriteLine("Случайные числа");
            for (int i = 0; i < 12; i++)
            {
                dobule number = random.NextDouble() * (5 - (-5)) + (-5);
                Console.WriteLine(number + "");
                if (number < 0)
                {
                    Console.WriteLine(" - отрицательное число");
                }
                else if (number > 0)
                {
                    Console.WriteLine("- положительное число");

                }
            }

            Console.Read();
        }
    }
}
