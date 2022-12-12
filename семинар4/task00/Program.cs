Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i < num; i++)
    {

        sum = sum * i;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);

Console.WriteLine($"Сумма чисел от единицы до А {sumNumbers}");


