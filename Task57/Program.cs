// Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцев: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
matrix[i, j] = new Random().Next(0, 2);
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}

Console.WriteLine();
for (int k = 0; k < m; k++)
{
for (int l = 0; l < n; l++)
{
if (matrix[k, l] != -1)
{
int temp = matrix[k, l];
int z = 0;
for (int r = 0; r < m; r++)
{
for (int e = 0; e < n; e++)
{
if (matrix[r,e] == temp)
{
matrix[r, e] = -1;
z++;
}
}
}
Console.WriteLine(temp + " встречается " + z + " раз(а)");
}
}
}