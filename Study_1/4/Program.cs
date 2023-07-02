// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно с 7 и 23.

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string Multiplicity(int number)
{
    string res = "Нет";
    if (number % 7 == 0 && number % 23 == 0)
        res = "Да";
    return res;    
}

int numbers = InputNum("Введите целое число: ");
string result = Multiplicity(numbers);

Console.WriteLine(result);