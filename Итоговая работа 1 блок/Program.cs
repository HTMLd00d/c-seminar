// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам.
// Первоночальный массив вводится с клавиатуры, либо задаётся на старте выполнения алгоритма.
Console.Write("Введите количество строк: ");
int count = Convert.ToInt32(Console.ReadLine()); 
string[] arrayStr = new string[count]; 
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите строку  , {i + 1}");
    arrayStr[i] = Console.ReadLine()!;
}


string[] NotMore3Symbols(string[] str)
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            count++;
    }

    string[] strLess4 = new string[count];
    count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            strLess4[count] = str[i];
            count++;
        }
    }

    return strLess4;
}

//Формирование массива из строк, длина которых меньше, либо равна 3 символам
string[] notMore3Symbols = NotMore3Symbols(arrayStr);

//Вывод полученного массива в консоль
for (int i = 0; i < notMore3Symbols.Length; i++)
{
    Console.WriteLine(notMore3Symbols[i]);
}