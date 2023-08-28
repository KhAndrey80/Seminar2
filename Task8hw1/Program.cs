// Принимает 5 значное число и проверяет, является ли оно полиндромом. 12321 -да, 12125 - нет
System.Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

int N1 = (N - N %10000) / 10000;
int N2 = ((N-N %1000) %10000) / 1000;
int N4 = (N %100 - N %10) / 10;
int N5 = N %10;

if (N1 == N5 && N2 == N4)

{
System.Console.WriteLine;("Палиндром");
}
else 
{
    System.Console.WriteLine("Не палиндром");
}

/*System.Console.WriteLine(N %10);//5 число
System.Console.WriteLine((N %100 - N %10) / 10);// 4 число
System.Console.WriteLine((N - N %10000) / 10000);// 1 число
System.Console.WriteLine(((N-N %1000) %10000) / 1000); //2 число*/