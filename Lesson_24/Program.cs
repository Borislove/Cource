using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24
{
    /*
     Массивы

    Одномерные массивы
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int[5];

            myArray[1] = 3;
            myArray[0] = 10;

            int a = myArray[0];

            Console.WriteLine(myArray[0]);

            Console.WriteLine(myArray.Length);

            Console.ReadLine();
        }
    }
}
