Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberCounter(int num)
{
    int counter = 0;
    while (num != 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;

}
int numberCounter = NumberCounter(number);
Console.WriteLine($"{number} ->{NumberCounter(number)}");
