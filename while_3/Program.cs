using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //найдите сумму целых чисел от 1 до 50.
            int k, sum;
            k = 0;
            sum = 0;
            while (k != 50)
            {
                k++;
                sum += k; // sum = sum +k
            }
            Console.WriteLine($"Сумма чисел от 1 до 50 равна: {sum}");

        }
    }
}
