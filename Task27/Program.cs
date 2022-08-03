// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while (a > 0)
{
    int i = a % 10;
    a = a / 10;
    summa = summa + i;
}
Console.Write("сумма цифр в числе: " + summa);