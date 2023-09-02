// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите 3 числа");
// int a= Convert.ToInt32(Console.ReadLine());
// int b= Convert.ToInt32(Console.ReadLine());
// int c= Convert.ToInt32(Console.ReadLine());

// void Proverka(int a, int b, int c)
// {
// if (a < b + c && b < a + c && c < a + b)
// Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
// else Console.WriteLine($"Треуголбник со сторонами {a}, {b}, {c} не существует");
// }
// Proverka(a, b, c);

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] array = new int[5];
void FillArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
}
}


int[] Copy (int[] array)
{
    int[] copy = new int[array.Length];
     for (int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
}
return copy;
}

FillArray(array);
System.Console.WriteLine(String.Join(" ", array));
System.Console.WriteLine(String.Join(" ", Copy(array)));
