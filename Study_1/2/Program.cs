// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int RandomNum()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Число {num}");
    return num;
}

// 123 -> 13
// 123 / 10 = 1 - первая
// 123 % 10 = 3 - последняя
// 10 * 1 + 3 = 13

int DelSecondDigit(int num)
{
    int first = num / 100;
    int second = num % 10;
    int twoDigits = first * 10 + second;
    return twoDigits;
}

int number = RandomNum();
int result = DelSecondDigit(number);
Console.WriteLine(result);