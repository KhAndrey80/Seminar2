/* Программа принимает на вход координаты 2 точек и находит расстояние между ними в 2D пространстве.
A(3,6), B(2,1)->5,09  A(7,-5), B(1,-1)->7,21
Формула: A(xA,yA), B(xB,yB). d=корень ((xA-xB)^2 + (yA-yB)^2)
Math.Pow(x, степень)  Math.Pow(x,2)= x^2   Math.Sqrt(x) - корень*/

System.Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 -x2, 2) + Math.Pow(y1 -y2, 2));

System.Console.WriteLine(d);