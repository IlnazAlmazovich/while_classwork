using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести на консоль числа от 0 и до 10 сначала в порядке возрастания, а потом в порядке убывания.

            int a = 0; // Объявлется пременная а 
            Console.WriteLine("В порядке возрастания");
            while (a <= 10) // пока а меньше либо ранво 10
            {
                // a++;
                Console.WriteLine($"{a}"); // вывод на консоль результата
                a++; // производим приращение переменной а на единицу и цикл повтораяется
            }
            //Console.WriteLine("В порядке убывания ");
            //while (a > 0)
            //{

            //    Console.WriteLine($"{a}");
            //    a--;
            //}
        }
    }
}
