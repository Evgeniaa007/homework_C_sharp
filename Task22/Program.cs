// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите координату X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt (Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));

Console.WriteLine($"Раастояние между точками в 3D пространстве: {s}");
*/

using System.Security.Cryptography.X509Certificates;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        // Введите свое решение ниже
        double DistanceBetweenPoints = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            DistanceBetweenPoints = Math.Pow((pointA[i] - pointB[i]), 2) + DistanceBetweenPoints;
            
        }
        DistanceBetweenPoints = Math.Sqrt(DistanceBetweenPoints);
        return DistanceBetweenPoints;
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}

