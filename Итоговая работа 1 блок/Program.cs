// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам.
// Первоночальный массив вводится с клавиатуры, либо задаётся на старте выполнения алгоритма.
Console.Write("Введите количество строк: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] arrayStr = new string[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите строку  , {i + 1}(>_<)");
    arrayStr[i] = Console.ReadLine()!;
}

string[] StrReduct(string[] str)
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            count++;
    }

    string[] strRed = new string[count];
    count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            strRed[count] = str[i];
            count++;
        }
    }

    return strRed;
}

string[] strReduct = StrReduct(arrayStr);

for (int i = 0; i < strReduct.Length; i++)
{
    Console.WriteLine(strReduct[i]);
}