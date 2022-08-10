// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];
double x;
for (int i = 0; i < array.Length; i++)
{
x = new Random().NextDouble() * 100;
array[i] = Math.Round(x, 4);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
double max_array = array[0], min_array = array[0];
for (int i = 1; i < array.Length; i++)
{
if (array[i] > max_array)
max_array = array[i];
if (array[i] < min_array)
min_array = array[i];
}
Console.WriteLine(max_array - min_array);