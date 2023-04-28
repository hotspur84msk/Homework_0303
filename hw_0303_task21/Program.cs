// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты для точки А: ");

double ax = Convert.ToInt32(Console.ReadLine());
double ay = Convert.ToInt32(Console.ReadLine());
double az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки В: ");

double bx = Convert.ToInt32(Console.ReadLine());
double by = Convert.ToInt32(Console.ReadLine());
double bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));

Console.WriteLine($"Расстояние между А и В = {Math.Round(distance, 3)}");