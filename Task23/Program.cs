// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*int[] array = new int[10];

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
    System.Console.WriteLine(String.Join(" ", array));
}
FillArray(array);

int max = 0;
int min = array[0];

    for (int i=0; i < array.Length; i++) 

    if (array[i] > max)
    {
       max = array[i];
    }
   else if( array[i] < min)
    {
       min = array[i];
    }

System.Console.WriteLine(max);
System.Console.WriteLine(min);*/


double[] array = new double[10];

Random rand = new Random();
for(int i=0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.Next(0,100) + rand.NextDouble(), 2);
}
System.Console.WriteLine(String.Join(" ", array));

double max = 0;
double min = array[0];

    for (int i=0; i < array.Length; i++) 

    if (array[i] > max)
    {
       max = array[i];
    }
   else if( array[i] < min)
    {
       min = array[i];
    }

System.Console.WriteLine(max);
System.Console.WriteLine(min);

System.Console.WriteLine($"Разница между максимальным и минимальным числом равно: {max - min}");
