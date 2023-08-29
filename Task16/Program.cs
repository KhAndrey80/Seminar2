// Программа принимает на вход число и выдает сумму цифр в числе 452->11

int GetNumber() 
{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumElems (int number)
{
   if (number < 0)
   {
    number = number * -1;
   } 
   int sum = 0;
   while (number > 0)
   {
    sum = sum + number %10;
    number = number /10;
   }
    return sum;
}

int number = GetNumber();
int sum = SumElems (number);
System.Console.WriteLine(sum);
