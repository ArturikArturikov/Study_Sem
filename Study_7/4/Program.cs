// Задача 42: Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string Bin(int num)
{
    string num2 = "";
    while (num > 0)
    {
        int digit = num % 2;
        num2 = $"{digit}" + num2;
        num = num / 2;
    }
    return num2;
}

int num3 = InputNum("Введите число: ");
Console.WriteLine(Bin(num3));