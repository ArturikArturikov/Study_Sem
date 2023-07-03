// Код перевернуть число и сравнить его (палидром).

long InputNum(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine()!);
}

long ReverseNum(long number)
{
    long reversedNum = 0;
    while (number != 0)
    {
        reversedNum = reversedNum * 10 + number % 10;
        number /= 10;
    }
    return reversedNum;
}

bool Palindrome(long num, long rev)
{
    return num == rev;
}

long num = InputNum("Введите число: ");
long rev = ReverseNum(num);
bool res = Palindrome(num, rev);
Console.WriteLine(res);