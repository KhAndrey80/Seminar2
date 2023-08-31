// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//  и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3               [6 7 3 6] -> 36 21
int [] array = {1, 2, 3, 4, 5};
int [] array2 = {6, 7, 3, 6};

void Result (int [] array)
{
    if (array.Length %2 == 0)
    {
        for(int i = 0; i < array.Length/2; i++)
        System.Console.Write(array[i] * array[array.Length - i-1] + " ");
    }
    else
   {
        for(int i = 0; i < array.Length/2; i++)
        System.Console.Write(array[i] * array[array.Length- i-1] + " ");
        System.Console.WriteLine(array[array.Length/2]);
   }
} 
Result(array);
System.Console.WriteLine(" ");
Result(array2);

