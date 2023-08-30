/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12];
int sumPozitive = 0;
int sumNegative = 0;

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
    System.Console.WriteLine(String.Join(" ", array));
}
FillArray(array);

foreach (int number in array)
{
    if (number > 0)
    {
       sumPozitive = sumPozitive + number;
    }
    else
    {
        sumNegative += number;
    }
}

System.Console.WriteLine($"Сумма положительных -  {sumPozitive} и сумма отрицательных - {sumNegative}");*/

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void EditArray (int [] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array [i];
    }    
    System.Console.WriteLine(); 
}

void FillArray (int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
    System.Console.Write(string.Join(" || ", array));
}

void PrintArray (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " || ");
    }
}

int [] array = new int [10];
FillArray(array);
EditArray(array);
PrintArray(array);












/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет     -3; массив [6, 7, 19, 345, 3] -> да*/


