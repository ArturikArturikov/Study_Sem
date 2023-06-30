// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшое цифру числа.

// Random rnd = new Random();
// int num = new rnd.Next(10, 100);
// 54 / 10 = 5
// 54 % 10 = 4

int RandomNum ()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine($"Число {num}");
    return num;
}

int MaxDigit (int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else
        return second;
}

int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.WriteLine($"Макс цифра в числе {rand} = {maxDigit}");