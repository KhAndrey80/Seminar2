//Программа принимает на вход число N и выдает произведение чисел от 1 до N
int Parse(string text) 
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Proizv (int number)
{
    int proizv = 1;
    for (int i = 1; i <= number; i++)
    {
        proizv = proizv * i;
    }
    return proizv;
}

int number = Parse("Введите число");
int proizv = Proizv (number);
System.Console.WriteLine(proizv);
