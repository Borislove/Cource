using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55,8 };

            //Console.WriteLine(myArray[0]);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
