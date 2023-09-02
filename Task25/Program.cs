// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа");
int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
int c= Convert.ToInt32(Console.ReadLine());

void Proverka(int a, int b, int c)
{
if (a < b + c && b < a + c && c < a + b)
Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
else Console.WriteLine($"Треуголбник со сторонами {a}, {b}, {c} не существует");
}
Proverka(a, b, c);

