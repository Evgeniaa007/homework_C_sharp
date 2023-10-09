// пользователь вводит M чисел. сколько чисел больше 0
/*
int[] InputArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int[] arr = InputArray(5);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.Write($"The amount of numbers higher then 0 is {count}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("введите значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.Write($"Координаты точки пересечения двух прямых — X: {x}, Y: {y}");