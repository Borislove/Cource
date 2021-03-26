using System;

namespace Lesson_32_3
{
    class Program
    {
        //заполнение строками
        static void Main(string[] args)
        {
            string[,] myArray = new string[2, 3];

            //заполнение
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X:" + j);
                    myArray[i, j] = Console.ReadLine();
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
