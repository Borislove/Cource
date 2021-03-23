using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    /*
     * Инкремент и декремент. Постфиксный и префиксный.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++; //постфиксный
            Console.WriteLine(a);
            ++a; //префиксный
            Console.WriteLine(a);

            int b = 5;
            b--;
            Console.WriteLine(b);


            int c = 1;
            c = ++c * c;
            Console.WriteLine(c); //4

            int d = 1;
            d = d++ * d;
            Console.WriteLine(d); //2
        }
    }
}
