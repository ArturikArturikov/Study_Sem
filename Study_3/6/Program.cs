// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int xA = InputNum("Введите x для А: ");
int yA = InputNum("Введите y для А: ");
int xB = InputNum("Введите x для B: ");
int yB = InputNum("Введите y для B: ");

double Root(int xA, int yA, int xB, int yB)
{
    double res1 = Math.Pow(xB - xA, 2);
    double res2 = Math.Pow(yB - yA, 2);
    double res = Math.Sqrt(res1 + res2);
    return res;
}

double distance = Root(xA, yA, xB, yB);
// Console.WriteLine(distance);
Console.WriteLine(Math.Round(distance, 2));