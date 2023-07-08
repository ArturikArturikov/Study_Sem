/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

***** учесть отрицательные степени
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

// double Multiplication(int A, int B)
// {
//     if (B == 0)
//         return 1;

//     else if (B > 0)
//     {
//         return A * Multiplication(A, B - 1);
//     }
//     else
//         return 1 / Multiplication(A, -B);  // -B (-(-2) = 2 (B становится положительным) -> if (B > 0) = 1 /  A * Multiplication(A, B - 1)
// }

// int A = InputNum("Введите целое число A: ");
// int B = InputNum("Введите целое число B: ");
// double result = Multiplication(A, B);
// Console.WriteLine(result);

double StepenNumber(int a, int b)
{
    if (b == 0) return 1;
    if (b > 0)
    {
        return a * StepenNumber(a, b - 1);
    }
    return 1 / (a * StepenNumber(a, -b - 1));
}
int a = InputNum("Введите целое число A: ");
int b = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(a, b));


/* Например, 5
A *(A, 4)
A * A (A, 3)
A * A * A (A, 2)
A * A * A * A (A, 1)
A * A * A * A * A * (0 = 1), так как (b == 0) return 1 стек собран

начинаем собирать ответ = 1 * A * A * A * A * A 
*/