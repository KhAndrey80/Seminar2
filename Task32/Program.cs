// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:            
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новы
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void ChangeArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i %2 != 0 && j %2 != 0)
{
   array[i, j] = array[i, j] * array[i, j];
}
Console.Write(array[i, j] + " ");
}
System.Console.WriteLine();
}
}
FillArray(array);
System.Console.WriteLine();
ChangeArray(array);
