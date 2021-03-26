using System;

namespace Lesson_35
{
    //функция и методы
    //модификаторы тип_возращаемого_значениея название_метода(параметры)
    //              {
    //                      тело метода
    //              }
    class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: "+result);
        }
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


            //Console.WriteLine(Sum(a,b));

            c = Sum(a, b);
            PrintResult(c);

        }
    }
}
