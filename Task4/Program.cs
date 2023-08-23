/* Напишите программу, которая принимает на вход координаты точки  (Х и Y), не равные нулю, и выдает номер четверти плоскости, в
которой находится точка 2 1
                        3 4 */
System.Console.WriteLine("Введите значения x и y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
System.Console.WriteLine("Первая четверть");
}

else if (x < 0 && y > 0)
{
System.Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
System.Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
System.Console.WriteLine("Четвертая четверть");
}
else
{
System.Console.WriteLine("x = 0 или у = 0");
}