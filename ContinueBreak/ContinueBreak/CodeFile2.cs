/// Break
/// Генерировать случайные числа до тех пор, пока их сумма не превысит N 

int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (true)
{
    int num = new Random().Next(100);
    Console.Write($"{num} ");
    sum += num;
    if (sum > n)
        // Завершает выполнение цикла
        break;
}



