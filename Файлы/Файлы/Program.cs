using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Файлы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Чтение всего текста из файла
            // .. - Переход в предыдущий каталог
            string fileName = "..\\..\\input.txt";
            string text = File.ReadAllText(fileName);

            // Чтение файла построчно
            string[] lines = File.ReadAllLines(fileName);

            Console.ReadKey();
        }
    }
}
