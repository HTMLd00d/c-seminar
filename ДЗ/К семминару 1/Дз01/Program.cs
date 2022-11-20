// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a <= b)
{
    Console.WriteLine($"Большее число {b}, Меньшее число {a}");
}
else
    Console.WriteLine($"Большее число {a}, Меньшее число {b}");
if (a == b) {
    Console.WriteLine($"Большее число {a}");
}