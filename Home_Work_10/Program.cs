using System;

namespace Home_Work_10
{

    /*
     * 
     * Написать метод который выводит на экран строку.
     * Символы из которых состоит строка и их количество вводятся пользователем.
     */
    class Program
    {

        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите количество символов:");
           uint  symbolsCount = uint.Parse(Console.ReadLine());
            PrintLine(symbol, symbolsCount);
            Console.ReadLine();
        }
    }
}
