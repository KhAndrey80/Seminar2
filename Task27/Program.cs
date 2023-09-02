// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());
string binaryString = string.Empty;
while (decimalNumber > 0)
{
int remainder = decimalNumber % 2;
decimalNumber /= 2;
binaryString = remainder.ToString() + binaryString;
}
Console.WriteLine($"Двоичное представление числа: {binaryString}");