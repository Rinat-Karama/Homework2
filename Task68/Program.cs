// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число m неотрицательное:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n неотрицательное:");
int n = Convert.ToInt32(Console.ReadLine());
int Ack (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ack(m - 1, 1);
    if (m > 0 && n > 0) return Ack(m - 1, Ack(m, n - 1));
return Ack(m, n);
}

Console.WriteLine($"Функция Аккермана A({m},{n}) = {Ack(m, n)}");