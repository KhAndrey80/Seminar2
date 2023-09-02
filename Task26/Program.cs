// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Первый способ:
// void Fib (int value)
// {
// int [] array = new int [value];
// for (int i = 0; i < array.Length; i++)
// {
// if (i == 0){
// array[i] = 0;
// System.Console.Write(array[i] + " ");
// }
// else if(i == 1){
// array[i] = 1;
// System.Console.Write(array[i] + " ");
// }
// else{
// array[i] = array[i-1]+ array[i-2];
// System.Console.Write(array[i] + " ");
// }
// }
// }
// Fib(10);

// Второй способ

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int fibbonacci1 = 0, fibbonacci2 = 1, fibbonacciSum;

Console.Write(fibbonacci1 + " ");
Console.Write(fibbonacci2 + " ");

int count = 0;
while (count < number - 2){
fibbonacciSum = fibbonacci1 + fibbonacci2;
fibbonacci1 = fibbonacci2;
fibbonacci2 = fibbonacciSum;
Console.Write(fibbonacciSum + " ");
count ++;
}