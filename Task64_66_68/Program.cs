// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write("Input N: "); int N = Convert.ToInt32(Console.ReadLine());
string PrintNumber(int N)
{
    if (N == 1) return Convert.ToString(N);
    return $"{N}, {PrintNumber(N - 1)}";
}
Console.Write($"N = {N} -> ");
Console.Write(PrintNumber(N));
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120 M = 4; N = 8. -> 30
/*
Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: "); int N = Convert.ToInt32(Console.ReadLine());
int SumOfNumbers(int M, int N)
{
    if (M > N) return 0;
    else if (M == N) return M; return M + SumOfNumbers(M + 1, N);
}
Console.WriteLine($"M = {M}; N = {N} -> {SumOfNumbers(M, N)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int Ackermann(int m, int n)
{
    if (m < 0 || n < 0) return 0;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {Ackermann(m, n)}");
*/

// -----------------------------------Спираль-----------------------------------------

int[,] GenerationArray(int size1, int size2) //Функция генерации двумерного массива, заполненного спирально 
{
    int[,] Array = new int[size1, size2];
    int x = 0;
    int y = 0; // Ввод переменных 
    int xstart = 0;
    int ystart = 0; // Координаты массива, x - горизонтальные элементы, y - вертикальные, будут обозначать процесс пути 
    int xfinish = 0;
    int yfinish = 0;// Значения, служащие для уменьшения пройденного прямоугольника по строкам и столбцам 
                    //Array[xstart, ystart] = 1; //Значение нулевого элемента массива 

    for (int count = 1; count <= Array.GetLength(0) * Array.GetLength(1); count++) //Цикл, ограничивающий последнее число массива, где count - значение
    //                                                                                  на которое будет увеличиваться значение следующего элемента массива 

    {
        Array[x, y] = count;
        if (x == xstart && y < Array.GetLength(1) - 1 - yfinish) //Путь до правой верхней стороны прямоугольника(квадрата) 
        {
            y++;
        }

        else if (y == Array.GetLength(1) - 1 - yfinish && x < Array.GetLength(0) - 1 - xfinish) //Путь до правой нижней стороны прямоугольника(квадрата) 
        {
            x++;
        }

        else if (x == Array.GetLength(0) - 1 - xfinish && y > ystart) //Путь до левой нижней стороны прямоугольника(квадрата) 
        {
            y--;
        }

        else if (y == ystart && x > xstart) //Путь до левой верхней стороны прямоугольника(квадрата) 
        {
            x--;
        }

        if (x == xstart + 1 && y == ystart && ystart != Array.GetLength(1) - 1 - yfinish) //МАГИЯ!!!!!!!!!!!! 
        {
            xstart++;
            ystart++;
            xfinish++;
            yfinish++;
        }
    }
    return Array;
}

void PrintArray(int[,] NewArray1) //Функция печати двумерного массива 
{
    for (int i = 0; i < NewArray1.GetLength(0); i++) //Первый цикл 
    {
        for (int j = 0; j < NewArray1.GetLength(1); j++) //Второй цикл 
        {
            Console.Write($"{NewArray1[i, j]}\t");
        }
        Console.WriteLine();
    }
}


Console.Write("Количество строк: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int N2 = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = GenerationArray(N1, N2);
Console.WriteLine();
PrintArray(NewArray);
