// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void Fib (int value)
{
int [] array = new int [value];
for (int i = 0; i < array.Length; i++)
{
if (i == 0){
array[i] = 0;
System.Console.Write(array[i] + " ");
}
else if(i == 1){
array[i] = 1;
System.Console.Write(array[i] + " ");
}
else{
array[i] = array[i-1]+ array[i-2];
System.Console.Write(array[i] + " ");
}
}
}
Fib(10);