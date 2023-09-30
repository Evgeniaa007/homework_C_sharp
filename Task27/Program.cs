// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int col)
{
    int sum = 0;
    while (col > 0)
    {
        int ost = col % 10;
        col /= 10;
        sum = sum + ost;
    }
    return sum;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {n} равна {Sum(n)}");