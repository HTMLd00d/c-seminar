Console.WriteLine("Number: ");
int num = Convert.ToInt32(Console.ReadLine());

string ConverToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine(ConverToBin(num));