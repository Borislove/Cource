using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int fanSpeen = 3000;

            bool isHightTemperature = true;
            bool hasNoCooling = fanSpeen<=0;

            if(isHightTemperature || hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
        }
    }
}
