// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки Xa:");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки Ya:");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки Za:");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки Xb:");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки Yb:");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки Zb:");
int zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));

Console.WriteLine(result.ToString("N2"));