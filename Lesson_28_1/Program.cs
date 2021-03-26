using System;

namespace Lesson_28_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 4, 5, 66, 99 };
            //Console.WriteLine(myArray[5]);
            //Console.WriteLine(myArray[myArray.Length-1]);

            //Console.WriteLine(myArray[^1]);
            //int[] myArray2 = myArray[..4];
            //int[] myArray2 = myArray[5..];

            Index myIndex = ^2;

            Console.WriteLine(myArray[myIndex]);

            string str = "Hello world !!! =)";
            Console.WriteLine(str[0..6]);
        }
    }
}
