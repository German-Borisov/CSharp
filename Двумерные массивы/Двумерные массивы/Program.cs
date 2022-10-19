using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерные_массивы
{
    internal class Program
    {
        /**
          * Обычный двумерный массив
          * 
          * 4 5 6 2
          * 2 3 4 3
          * 7 8 9 7
          * 
          * int[,] matrix = new int[col, row];
          * 
          * Ступенчатый двумерный массив
          * 6 3 2 2
          * 7 5
          * 1 4 2
          * 7 8 9 3 5
          * 
          * int[][] matrix = new int[row][];
          * for (int i = 0; i < row; i++)
          *     matrix[i] = new int[n];
          *      
          *      
          * matrix[строка][столбец]
          */

        static void Main(string[] args)
        {
            // Cтолбцы
            int col = 6;
            // Строки
            int row = 4;

            int[,] matrix = new int[row, col];


        }
    }
}
