// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите число: ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < num)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
}