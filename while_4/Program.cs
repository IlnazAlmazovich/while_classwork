﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
