Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Padre(int num)
{
    int num1 = 1;
    while(num1<num)
    {
        int square = num1*num1;
        Console.Write($"{num}  ");
        Console.WriteLine(square);
        num1++;
    }
    return num;
}
int result = Padre(number);
