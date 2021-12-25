// Найти расстояние между точками в пространстве 2D

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1 = ");
string X1 = Console.ReadLine();
int x1 = int.Parse(X1);
Console.Write("Y1 = ");
string Y1 = Console.ReadLine();
int y1 = int.Parse(Y1);
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2 = ");
string X2 = Console.ReadLine();
int x2 = int.Parse(X2);
Console.Write("Y2 = ");
string Y2 = Console.ReadLine();
int y2 = int.Parse(Y2);

double d = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.WriteLine ("Расстояние между точками: {0}", d);


