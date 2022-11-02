namespace Exceptions
{
    internal class Program
    {
        static int SumSeq(int a, int b)
        {
            int sum = 0;
            if (a > b)
                throw new ArgumentsPositionException("Первый аргумент должен быть больше второго!");
            for (int i = a; i <= b; i++)
                sum += i;
            return sum;
        }


        static void Main(string[] args)
        {
            int a = 0, b = 0;
            // Программа не завершается аварийно!
            try
            {
                // Исключительные ситуации
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine(SumSeq(a, b));

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Введено не число!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Превышено допустимое значение!");
            }
            catch (ArgumentsPositionException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}