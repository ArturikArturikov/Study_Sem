﻿int num = int.Parse(Console.ReadLine()!);

string bin = String.Empty;

while (num != 0)
{
    bin = num % 2 + bin;
    num /= 2;
    // 10
    // 10 % 2 = 0
    // 10 / 2 = 5
    // 5 % 2 = 1 + '0' = '10'
    // 5 / 2 = 2
    // 2 % 2 = 0 + '10' = '010'
    // 2 / 2 = 1
    // 1 % 2 = 1 + '010' = '1010'
    // 1 / 2 = 0
    // 1010 = 1 * 2^3 + 0 * 2^2 + 1 * 2^ 1 + 0 * 2^0 = 8 + 2 = 10
}