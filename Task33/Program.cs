// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите длинну массива");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 9);
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
}

void SumArray(int[,] array)
{
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i == j)
{
   sum = sum + array[i, j];
}
}
}
System.Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}

FillArray(array);
System.Console.WriteLine();
SumArray(array);