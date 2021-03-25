using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    /*
     вложенные циклы
     */
    class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 1; i <=3 ; i++)
            //    {
            //        Console.WriteLine("цикл 1 итерация №: "+i);
            //        for (int j = 1; j <= 5; j++)
            //        {
            //            Console.WriteLine("\tцикл 2 итерация №: " + j);
            //        }

            //        for (int k = 0; k <= 3; k++)
            //        {
            //            Console.WriteLine("\t\tцикл 3 итерация №: " + k);
            //        }
            //    }

            //    Console.ReadLine();
            //}

            Console.WriteLine("Введите высоту прямоугольника ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника ");
            int width = int.Parse(Console.ReadLine());

            for (int j= 0; j<height; j++)
            {

                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();

        }
    }
}
