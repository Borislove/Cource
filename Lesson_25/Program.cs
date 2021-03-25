using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray= new int[5];
            //  int[] myArray = new int[5] { 5, 6, 7, 8,10};
            //int[] myArray = new int[] { 5, 6, 7, 8, 10 };

            //int[] myArray = Enumerable.Repeat(5,10).ToArray();
            int[] myArray = Enumerable.Range(4,10).ToArray();
        }
    }
}
