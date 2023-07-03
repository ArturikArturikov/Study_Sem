// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumFrom1ToN(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите целое число N: ");
int sum = SumFrom1ToN(num);
Console.WriteLine($"Сумма чисел от 1 до N равна {sum}.");