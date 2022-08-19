// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


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
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = matrix[0, i];
    matrix[0, i] = matrix[n - 1, i];
    matrix[n - 1, i] = temp;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}