using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    /*
     заполнить массив с клавиатуры
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount]; //кол-во элементов
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива :");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
