// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7



Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцев: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
matrix[i, j] = new Random().Next(-100, 100);
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}
int minNumber = 101;
int minRow = 0;
int minColumn = 0;
Console.WriteLine();
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
if (minNumber > matrix[i, j])
{
minNumber = matrix[i, j];
minRow = i;
minColumn = j;
}
}
Console.WriteLine();
}
Console.WriteLine("В строке под номером: " + minRow + 1);
Console.WriteLine("В столбце под номером: " + minColumn + 1);
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
if (minRow != i && minColumn != j)
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}