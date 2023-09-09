// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

int[,] AddArray()
{
Console.WriteLine("Введите длину массива ");
int lengthArray = int.Parse(Console.ReadLine());
int getArray = int.Parse(Console.ReadLine());
int[,] array = new int[lengthArray, getArray];
return array;
}

int[,] array = AddArray();

if (array.GetLength(0) != array.GetLength(1)){
Console.WriteLine("Невозможно перевернуть массив");
} else {

int[,] FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-10, 10);
Console.Write(array[i, j] + "\t");
}
Console.WriteLine();
}
return array;
}

int[,] array2 = FillArray(array);

Console.WriteLine("-------------------------");

void FillArray21(int[,] arr)
{
for(int i=0; i< arr.GetLength(0)-1; i++) {
for(int j=i+1; j< arr.GetLength(1); j++) {
int temp = arr[i,j];
arr[i,j] = arr[j,i];
arr[j,i] = temp;
}
Console.WriteLine();
}
}

FillArray21(array2);

void PrintArray(int[,] array){
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + "\t");
}
Console.WriteLine();
}
}

PrintArray(array2);

}