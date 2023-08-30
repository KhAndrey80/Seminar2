/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

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

System.Console.WriteLine($"Сумма положительных -  {sumPozitive} и сумма отрицательных - {sumNegative}");
