using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_7
{
    //ВЫВОД МАССИВА В ОБРАТНОМ ПОРЯДКЕ

    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 56, 69, 7 };

            Console.WriteLine(myArray.Length);

            Console.WriteLine("\nВывод массива:");
            for (int i = myArray.Length-1; i >=0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
