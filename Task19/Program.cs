// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 23132
/*
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 10 == (number / 10000) && ((number / 1000) % 10 == (number % 100) / 10)))
{
    Console.Write($"{number} является палиндромом");
}
else
{
    Console.Write($"{number} не является палиндромом числом");
}
*/
public class Answer
{
    static bool IsPalindrome(int number){
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        else if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
