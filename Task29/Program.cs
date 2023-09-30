// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Mass(int num1, int num2)
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(num1, num2);
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите границы массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
Mass(n1, n2);
