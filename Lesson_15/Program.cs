using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели число 1");
                    break;

                case 2:
                    Console.WriteLine(  "Вы ввели число 2");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
