using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //int limit = int.Parse(Console.ReadLine());
            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(; ; )
            //{
            //    Console.WriteLine("for is working");
            //    System.Threading.Thread.Sleep(300);
            //}
            //Console.ReadLine();

            //int i = 0;
            //for (; i < 3; i++)
            //{
            //    Console.WriteLine("for_1: "+i);
            //}
            //for (; i < 5; i++)
            //{
            //    Console.WriteLine("for_2: "+i);
            //}


            //for (int i = 0, j=5 ; i <10; i++,j++)
            //{
            //    Console.WriteLine("i:" +i);
            //    Console.WriteLine("j:" +j);
            //}

            //for (int i = 0, j = 5; i < 10 && j<12; i++, j++)
            //{
            //    Console.WriteLine("i:" + i);
            //    Console.WriteLine("j:" + j);
            //}


            ////обратный порядок
            //int i = int.Parse(Console.ReadLine());
            //for (; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = int.Parse(Console.ReadLine()); i >=0;i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0, j=5; i<5; i++,j--)
            //{
            //    Console.WriteLine("i: "+i);
            //    Console.WriteLine("j: "+j);
            //}
            
                for (int i = 10; i >= 0; i--)
                {
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine(i);
                }

                for (int j = 0; j < 100; j++)
                {
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(40, 300);
                    Console.WriteLine("BOOM!!!");
                }

            }
    }
}
