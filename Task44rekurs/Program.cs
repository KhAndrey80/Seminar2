// 1. Задать M и N. Написать программу, которая выдает все числа от М до N.
// void PrintNumber(int n, int m)
// {
// if (n==m)
// {
//     System.Console.WriteLine(n);
// return;
// }
// System.Console.Write(n + ", ");
// PrintNumber(n +1, m);
// }

// PrintNumber(1,5);

// 2. Написать программу, которая принимает число и возвращает сумму его цифр.


// int SumNumber(int number)
// {
//     if (number < 10)
// {
//     return number;
// }
// return number %10 + SumNumber(number /10);
// }

// System.Console.WriteLine(SumNumber(453));

//3. Написать программу, которая принимает 2 числа А и В и возводит А в степеь В.
// А=3, В=5, 3^5 = 243

int Stepen(int a, int b)
 {
     if (b == 1)
{
     return a;
}
return a * Stepen(a, b-1);
}

System.Console.WriteLine(Stepen(3,5));