﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21
{
    /*
     * ключевое слово continue;
     */
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {

                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
