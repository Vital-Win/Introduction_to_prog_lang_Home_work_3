// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа которая проверяет является ли введенное число палиндромом");
Console.WriteLine("Введите положительное пятизначное число:");
int number = int.Parse(Console.ReadLine()!);

int number1 = number / 10000;
int number2 = (number / 1000) % 10;
int number4 = (number % 100) / 10;
int number5 = number % 10;

if (number1 == number5 && number2 == number4)
    Console.WriteLine("Да");
else if (number < 10000 || number > 99999)
    Console.WriteLine("Введено некорректное число!");
else
{
    Console.WriteLine("Нет");
}