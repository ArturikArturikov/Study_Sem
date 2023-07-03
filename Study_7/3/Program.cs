// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Triangle(int a, int b, int c)
{
    if (a + b < c || b + c < a || a + c < b)
    Console.WriteLine("Нет");
    else 
    Console.WriteLine("Да");
}

int num = InputNum("Введите первое число: ");
int num1 = InputNum("Введите второе число: ");
int num2 = InputNum("Введите третье число: ");

Triangle(num, num1, num2);