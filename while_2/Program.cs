using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100; //запускать через кнопку пуск
            while (a >= 50)
            {
               
                Console.WriteLine($"{a}");
                a--;

            }
            Console.ReadKey();
        }
    }
}
