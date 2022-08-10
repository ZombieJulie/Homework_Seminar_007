/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int m = 10;
int n = 10;
int[,] array = GetArray(m, n);
PrintArray(array);

Console.WriteLine("Введите номер строки, на которой нужно найти элемент: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца, на котором нужно найти элемент: ");
int column = int.Parse(Console.ReadLine());

SearchNumber(array, row, column);

int[,] GetArray(int m, int n)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(-100, 101);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}

void SearchNumber(int[,] arr, int r, int c)
{
    if (r > arr.GetLength(0) || c > arr.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет.");
    else Console.WriteLine($"Значение элемента на строке {r} в столбце {c}: {arr[r-1, c-1]}");
}
