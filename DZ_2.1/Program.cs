// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
int a2=(a/10) % 10;
int result = (a2);
Console.WriteLine(result);
