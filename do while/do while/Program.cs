// Отличия от обычного while: сначала выполняется тело цикла
// потом проверяется условие. Т.е. в цикле do while тело цикла выполнится
// в любом случае один раз.

// Генерировать числа до тех пор, пока не встретится число 10.
int num = 0;
int count = 0;
do
{
    num = new Random().Next(100);
    Console.Write($"{num} ");
    count++;
} while (num != 10);
Console.WriteLine();
Console.Write(count);