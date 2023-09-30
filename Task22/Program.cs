// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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

double s = Math.Sqrt (Math.Pow((xa - ya), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));

Console.WriteLine($"Раастояние между точками в 3D пространстве: {s}");