using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    /*ключевое слово break*/
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {

                string msg = Console.ReadLine();
                if(msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
