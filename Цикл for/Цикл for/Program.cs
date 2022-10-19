using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цикл_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Цикл for
            // int i = 0; инициализация
            // i < 10; условие выполнения
            // i++ изменение переменной счётчика каждую итерацию цикла
            // i++ инкремент (увеличение значения на 1)
            // i-- декремент (уменьшение значения на 1)
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
