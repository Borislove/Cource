using System;

namespace Lesson_33
{
    class Program
    {
        //ступенчатые , зубчатые массивы
        static void Main(string[] args)
        {
            int[][] myArray =new int[3][];
            //int[,] myArray2 = new int[10, 5];

            //int myArrayRank = myArray.Rank;
            //int myArray2Rank = myArray2.Rank;

            //int myArrayLength = myArray.Length;
            //int myArray2Length = myArray2.Length;


            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[15];

            Console.WriteLine(myArray[0][3]);
            

        }
    }
}
