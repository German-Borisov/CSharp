namespace Наследование
{
    internal class Program
    {
        // Наследование
        // 1. Наследование признаков (полей и методов) одного класса от другого.
        // 2. Необходимость хранить вв одном контейнере различные типы сущностей.
        static void Main(string[] args)
        {
            // Возможность хранить в одном списке разные типы
            List<Triple> triples = new List<Triple>();
            triples.Add(new Time(1, 2, 3));
            triples.Add(new Date(1, 2, 3));

        }
    }
}