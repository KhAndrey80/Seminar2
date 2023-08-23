// Написать программу которая принимает число N и выдает таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int S = 1;
int qw = 0;
while (S < N+1 ) 
{
qw = S * S;
System.Console.WriteLine(qw);
S++;
}
