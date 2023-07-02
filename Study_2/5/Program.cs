// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнию цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int rem = number % 10;
Console.WriteLine(rem);