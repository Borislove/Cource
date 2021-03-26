using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };

            //int result = myArray.Min();
            //Console.WriteLine(result);

            //int maxValue = myArray.Max();
            //Console.WriteLine(maxValue);

            //"Сумма четных элементов" 
            Console.WriteLine( myArray.Where(i=>i % 2 ==0).Sum());

            //Минимальное число
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());

            //уникальные элементы
            int[] result = myArray.Distinct().ToArray();

            int[] result2 = myArray.OrderByDescending(i =>i).ToArray();

            Array.Reverse(myArray);

            Console.ReadLine();
        }
    }
}
