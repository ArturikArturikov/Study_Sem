// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти(x и y).

int InputNum(string message)
{
    Console.WriteLine(message);
    int quarter = int.Parse(Console.ReadLine()!);
    return quarter;
}

string GetQuarter(int quarter1)
{
    if (quarter1 == 1) return "Координаты x и y должны быть больше 0";
    else if (quarter1 == 2) return "Координаты x должны быть меньше 0, а координаты y - больше 0";
    else if (quarter1 == 3) return "Координаты x и y должны быть меньше 0";
    else if (quarter1 == 4) return "Координаты x должны быть больше 0, а координаты y - меньше 0";
    else return "Введено неверное число";
}

int quarter = InputNum("Введите номер четверти (1-4);");
string num = GetQuarter(quarter);
Console.WriteLine(num);