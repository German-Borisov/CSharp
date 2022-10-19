using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_конструкции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if (<условие>) {}
            // else {}

            // > < == != >= <=
            // && И
            // || ИЛИ

            int n = 25;

            // Определение чётности числа
            if (n % 2 == 0)
            {
                Console.WriteLine("Чётное");
            }
            else
            {
                Console.WriteLine("Нечётное");
            }

            // Координатная плоскость
            // Входные данные:
            // Координаты точки
            // Выходные данные:
            // Координатная четверть
            
            // -4
            // 1
            // II
            
            // 0
            // -1
            // Точка лежит на оси
                
        }
    }
}
