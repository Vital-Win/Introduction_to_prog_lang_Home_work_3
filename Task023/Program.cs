// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое положительное число (начиная с 1):");
int n = int.Parse(Console.ReadLine()!);

int i = 1; 

while (i <= n)
{
    var result = Math.Pow(i, 3);
    Console.WriteLine(result);
    i++;
}

if (n <= 0) 
    Console.WriteLine("Введено некорректное число!");