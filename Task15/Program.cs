// Напишите цикл, который принимает на вход 2 числа А и В и возводит число А в натуральную степень В 3,5-> 243 2,4->16
//Программа принимает на вход число и выдает сумму цифр в числе 452->11
//Программа, которая задает массив из 8 элементов и выводит на экран

using System.Globalization;

int GetNumber() 
{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Stepen(int number1, int number2)
{
   int i = 0;
   int stepen = 1;
   while (i < number2)
{
    stepen = stepen * number1;
    i++; 
}    
    return stepen;
}

int number1 = GetNumber();
int number2= GetNumber();
int stepen = Stepen(number1, number2);
System.Console.WriteLine(stepen);