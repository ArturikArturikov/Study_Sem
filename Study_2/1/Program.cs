// Напишите программу, которая на Напишите программу, которая на вход принимает число и выдает его квадрат.

Console.Write("Введите целое число: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int square = num * num;
Console.WriteLine($"Квадрат числа {num} равен {square}");