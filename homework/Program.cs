using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework
{
    class Program
    {
        /*
         * Создать индексатор для одномерного массива который при установке значения будет 
         * возводить в квадрат передаваемое значение переменной и устанавливать его для указанного индекса. э
         * При получении элемента массива по индексу будет возвращаться его текущее значение.
         */

        static void Main(string[] args)
        {
            Array array = new Array(3);
            array[0] = 4;
            array[1] = 134;
            array[2] = 3456;

            for(int i = 0; i < array.Size; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
