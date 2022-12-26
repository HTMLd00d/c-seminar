// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам.
// Первоночальный массив вводится с клавиатуры, либо задаётся на старте выполнения алгоритма.

Console.Write("Введите количество строк: ");
int count = Convert.ToInt32(Console.ReadLine()); 
string[] arrayStr = new string[count]; 
for (int i = 0; i < count; i++)
{
    Console.Write("Введите строку  ", i + 1);
    arrayStr[i] = Console.ReadLine();
}
Console.WriteLine("Строки длиною меньше или равной 3 символам");
for (int i = 0; i < count; i++)
{
    Console.WriteLine(arrayStr[i]);
}
