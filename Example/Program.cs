using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    /*
     * 1.Напишите программу, вычисляющую среднее арифметическое двух чисел.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("Среднее арифметическое двух чисел = " + result);
        }
    }
}
