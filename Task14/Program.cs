﻿// Написать программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случйном порядке
int [] array = new int[8];

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(array[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);