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


int SumNumber(int number)
{
    if (number == 0)
{
    return 0;
}
return number %10 + SumNumber(number /10);
}

System.Console.WriteLine(SumNumber(453));