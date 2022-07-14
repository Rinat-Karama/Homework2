// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
    Console.WriteLine("Понедельник, не выходной");
if (a == 2)
    Console.WriteLine("Вторник, не выходной");
if (a == 3)
    Console.WriteLine("Среда, не выходной");
if (a == 4)
    Console.WriteLine("Четверг, не выходной");
if (a == 5)
    Console.WriteLine("Пятница, не выходной");
if (a == 6)
    Console.WriteLine("Суббота, да, выходной");
if (a == 7)
    Console.WriteLine("Воскресенье, да, выходной");
if (a > 7)
    Console.WriteLine("Доступные значения от 1 до 7");