// Напишите программу, которая принимает на вход число и выдвет кол-во цифр в числе.
using System.Reflection.Metadata.Ecma335;

int GetNumber() 
{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountElems (int number)
{
   if (number < 0)
   {
    number = number * -1;
   } 
   int count = 0;
   while (number > 0)
   {
    number = number / 10;
   count++;
   }
    return count;
}


int number = GetNumber();
int sum = CountElems (number);
System.Console.WriteLine(sum);
