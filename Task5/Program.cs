/* Программа принимает на вход координаты 2 точек и находит расстояние между ними в 3D пространстве.
A(3,6,8), B(2,1,-7)->15,84  A(7,-5,0), B(1,-1,9)->11,53
Формула: A(xA,yA,zA), B(xB,yB,zB). d=корень ((xA-xB)^2 + (yA-yB)^2 + (zA-zB)^2 )
Math.Pow(x, степень)  Math.Pow(x,2)= x^2   Math.Sqrt(x) - корень*/

System.Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x1 -x2, 2) + Math.Pow(y1 -y2, 2) + Math.Pow(z1 -z2, 2)), 2);

System.Console.WriteLine(d);
