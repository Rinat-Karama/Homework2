// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
int a3 =(a % 10);
int result = (a3);
Console.WriteLine(result);
if (a<100)
  Console.WriteLine("Третьей цифры нет");
