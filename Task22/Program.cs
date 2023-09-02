// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
int sumNPoz = 0;

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
    System.Console.WriteLine(String.Join(" ", array));
}
FillArray(array);

    for (int i=0; i < array.Length; i++) 
    if (i %2 != 0)
    {
       sumNPoz = sumNPoz + array[i];
    }
  
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {sumNPoz}");

