// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int DigitNum(int num)
{
    int index = 0;
    while (num != 0)
    {
        num = num / 10;
        index++;
    }
    return index;
}
int num = InputNum("Введите целое число: ");
int number = DigitNum(num);
Console.WriteLine($"В числе {num} {number} цифр");