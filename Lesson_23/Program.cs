﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23
{
    /*
     Тернарный оператор
     */
    class Program
    {
        static void Main(string[] args)
        {

            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            //if(enteredPassword == storedPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}

            //accessAllowed = enteredPassword == storedPassword ? true : false;

            //Console.WriteLine(accessAllowed);


            int inputData = int.Parse(Console.ReadLine());
            int outputData = (inputData < 0) ? 0 : inputData;

            Console.ReadLine();
        }
    }
}
