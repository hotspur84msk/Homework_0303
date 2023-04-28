// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число для проверки на палиондром: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

int num2 = number % 10000;
int num3 = number % 1000;
int num4 = number % 100;
int num5 = number % 10;

int f5 = num5;
int f4 = (num4 - f5) / 10;
int f3 = (num3 - f4*10) / 100;
int f2 = (num2 - f3*100) / 1000;
int f1 = (number - f2*1000) / 10000;

if (Math.Abs(number) > 99999 || Math.Abs(number) < 10000)
{
    Console.WriteLine("Введенное число не пятизначное");
}
else
{
    if (f1 == f5 && f2 == f4)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
