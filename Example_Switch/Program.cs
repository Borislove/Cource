using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            switch (str)
            {
                case "world" :
                    Console.WriteLine("Вы ввели world");
                    break;

                case "lala":
                    Console.WriteLine("lalala");
                        break;

            }
        }
    }
}
