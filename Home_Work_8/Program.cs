using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_8
{
    //сумма четных чисел
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };
            int result = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
