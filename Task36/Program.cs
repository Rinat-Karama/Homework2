﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Веедите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i  = 1; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);

Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 1; i < array.Length; i+=2) 
{
    count=count + array [i];
}
Console.WriteLine("Сумма не четных чисел = "+ count);