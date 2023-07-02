// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 0;

int FindResult(int number1, int number2)
{
    result = number1 % number2;
    return result;
}

int res = FindResult(number1, number2);
if (res == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Некратно, остаток {res}");
} 