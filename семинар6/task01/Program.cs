Console.WriteLine("Введите три числа");
Console.Write("первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите три числа");
Console.Write("первое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите три числа");
Console.Write("первое число ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine(Triangle(num1, num2, num3) ?"YES":"NO");