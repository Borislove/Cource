using System;

namespace Lesson_31_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];

            //заполнение
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: "+i +" X:"+j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //вывод
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
    }

