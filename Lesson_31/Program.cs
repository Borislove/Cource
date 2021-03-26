using System;

namespace Lesson_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myArray = new int[,]
            //{
            //    {1,2,3,4,5 },
            //    { 2,3,4,5,6},
            //    { 6,7,8,9,0},
            //    {1,2,3,4,5 }
            //};
            //foreach (var item in myArray)
            //{
            //    Console.Write(item+" ");
            //}

            //вывести табличкой
            int[,] myArray = new int[,]
            {
                {1,2,3,4,5 },
                { 2,3,4,5,6},
                { 6,7,8,9,0},
                {1,2,3,4,5 }
            };
            //Console.WriteLine(myArray.Rank);
            // myArray.GetLength(0);

            //Console.WriteLine(myArray.GetLength(0));

            //наглядный пример 
            //int height = myArray.GetLength(0); //высота
            //int width = myArray.GetLength(1); //ширина
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(myArray[y,x]+ "\t");

            //    }
            //    Console.WriteLine();
            //}

            //сокращенный варинат
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
