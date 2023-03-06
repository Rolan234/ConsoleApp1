using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 1; i<=10; i++)
            {
                int x = random.Next(-40, 40);
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
