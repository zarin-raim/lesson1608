using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1608
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int start = 0, end = 1;
            while (!isInt)
            {
                Console.Write("Начало: ");
                isInt = int.TryParse(Console.ReadLine(), out start);
            }
            isInt = false;
            while (!isInt)
            {
                Console.Write("Конец: ");
                isInt = int.TryParse(Console.ReadLine(), out end);
            }

            RangeOfArray array = new RangeOfArray(start, end);
            array[]

        }
    }
}
