Console.WriteLine("Введите координаты первой точки");
Console.Write("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double length(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));
}
double res = Math.Round(length(x1, y1, x2, y2),2, MidpointRounding.ToZero);
Console.WriteLine(res);