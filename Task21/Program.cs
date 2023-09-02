// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в массиве.

int [] array = new int [10];

Random random = new Random();
for(int i=0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}
System.Console.WriteLine(String.Join(" ", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] %2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine("Количество чётных чисел в массиве: " + count);

