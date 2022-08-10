/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
double[,] array = new double[rows, columns];


double[,] GetArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return array;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
  }
}

GetArray(rows, columns);
PrintArray(array);
