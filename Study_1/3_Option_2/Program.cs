// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// 2 Вариант решения 

int Numbers (string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number1 = Numbers("Введите первое число");
int number2 = Numbers("Введите второе число");

void Division(int num1, int num2)
{
    int two = num1 % num2;
    if (two == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Некратно, " + two);
    }
}

Division (number1, number2);
