namespace Организация_меню
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            int action;

            while (isRun)
            {
                Console.WriteLine("1. Пункт 1");
                Console.WriteLine("2. Пункт 2");
                Console.WriteLine("3. Пункт 3");
                Console.WriteLine("4. Пункт 4");
                Console.WriteLine("0. Выход");
                Console.Write(">");
                action = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (action)
                {
                    case 0:
                        isRun = false;
                        break;
                    case 1:
                        Console.WriteLine("Резултьтат работы 1");
                        break;
                    case 2:
                        Console.WriteLine("Резултьтат работы 2");
                        break;
                    case 3:
                        Console.WriteLine("Резултьтат работы 3");
                        break;
                    case 4:
                        Console.WriteLine("Резултьтат работы 4");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}