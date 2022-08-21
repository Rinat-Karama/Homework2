// адача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцев: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n == m)
{
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
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (j < i)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}
else
Console.WriteLine("Увы... Это невозможно");