using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    /*
     * 2. Введите три числа и выведете на экран значение суммы и произведения этих чисел.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdhValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");
            thirdhValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdhValue;
            double mulResult = firstValue * secondValue * thirdhValue;

            Console.WriteLine("Сумма трех чисел " + sumResult);
            Console.WriteLine("Произведение трех чисел " + mulResult);
        }
    }
}
