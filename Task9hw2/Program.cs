// Написать программу которая принимает число N и выдает таблицу кубов чисел от 1 до N. 3-1,8,27
System.Console.WriteLine("Введите положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int S = 1;
while (S <= N) 
{
System.Console.WriteLine(S*S*S);
S++;
}
