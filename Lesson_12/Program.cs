using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    /*
     * Операторы отношений
     * Операции сравнения
     */

    /*
     == Равно
    != Не равно
    > Больше
    < Меньше
    >= Больше или равно
    <= Меньше или равно
     */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            Console.WriteLine(a == b);

            Console.WriteLine(a !=b);
            Console.WriteLine(a>b);
            Console.WriteLine(a<b);
        }
    }
}
