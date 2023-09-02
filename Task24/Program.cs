// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] array = new int[5];
void FillArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
}
}

void Reverse (int[] array)
{
int tmp;
for (int i = 0; i < array.Length / 2; i++)
{
tmp = array[i];
array[i] = array[array.Length - 1 - i];
array[array.Length - 1 - i] = tmp;
}
}


int[] ReverseNew (int[] array)
{
    int[] newArray = new int[array.Length];
     for (int i = 0; i < array.Length; i++)
{
    newArray[array.Length -1-i] = array[i];
}
return newArray;
}

FillArray(array);
System.Console.WriteLine(String.Join(" ", array));
System.Console.WriteLine(String.Join(" ", ReverseNew(array)));
Reverse(array);
System.Console.WriteLine(String.Join(" ", array));