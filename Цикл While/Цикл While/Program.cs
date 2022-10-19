using System;

namespace Цикл_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 12325;

            // Цикл while применяют, когда неизвестно кол-во итераций

            // Необходимо следить, чтобы переменная в условии
            // менялась внутри цикла.
            while (n > 0)
            {
                Console.WriteLine(n % 10);
                n = n / 10; // n /= 10
            }

            Console.ReadKey();
        }
    }
}
