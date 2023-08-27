//Программа получает число A и выдает сумму от 1 до А. 7->28, 4 -> 10
int Parse(string text) 
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum (int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = Parse("Введите число");
int sum = Sum (number);
System.Console.WriteLine(sum);


