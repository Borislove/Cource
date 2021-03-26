using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_9
{
    //найти наименьший элемент массива
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {  3, 99, 49, 64, 77, 4, 42, 5 ,1,102,0, -1122,12144, -333, -4444, -889, 21499, 88888};
            int minValue = myArray[0];
            int maxValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                //минимальное
                if(myArray[i] < minValue)
                {
                    minValue = myArray[i];
                    
                }
                if(myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                    
                }

            }
            Console.WriteLine("Наименьшее число:" + minValue);
            Console.WriteLine("Наибольшее число:" + maxValue);
            Console.ReadLine();
        }
    }
}
