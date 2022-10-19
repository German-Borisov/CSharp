using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    internal class Program
    {
        static void printArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                Console.Write($"{nums[i]} ");
        }

        static void fillArray(int[] nums)
        {
            // Класс для генерации случайных чисел
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
                // Next(value) функция, возвращающая случайное число до value 
                nums[i] = random.Next(1000);
        }

        void printLocalMax(int[] nums)
        {

        }

        static void Main(string[] args)
        {
            // Массивы
            // 1. Хранятся несколько значений одного типа
            // 2. Нумерация элементов начинается с 0
            // 3. После выделения памяти массиву невозможно изменить его размер
            int[] numbers;
            int size = 20;

            // Выделение памяти на size элементов в массиве
            numbers = new int[size];

            fillArray(numbers);
            printArray(numbers);

            Console.ReadKey();
        }
    }
}
