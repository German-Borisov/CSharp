using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции
{
    internal class Program
    {
        // Функции
        // 1. Улучшение читаемости кода
        // 2. Выделение повторяющихся частей кода

        // <тип результата> <название функции>(<аргументы>)

        // Функция, которая определяет кол-во какой-либо цифры в числе
        static int digitCount(int num, int digit)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 10 == digit)
                    count++;
                num /= 10;
            }
            // Завершает выполнение функции и возвращает значение
            return count;
        }

        static void printRectangle(int width, int height)
        {
            // TODO
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Вызываем функцию с параметрами и сравниваем результат
            for (int i = 0; i < n; i++)
            {
                if (digitCount(i, 0) == 3)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
