/// Continue
/// Сгенерировать N случайных чисел и сложить только чётные из них.
/// 

int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; i < n; i++)
{
    int num = new Random().Next(100);    
    if (num % 2 != 0)
        continue;
    Console.Write($"{num} ");
    sum += num;
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");
