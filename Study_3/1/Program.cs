// Вернуть два числа.

int[] InputSomeNums()
{
    int[] twoNums = new int[2];
    Console.Write("Введите первое число: ");
    twoNums[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число: ");
    twoNums[1] = int.Parse(Console.ReadLine()!);
    return twoNums;
}

int[] array = InputSomeNums();
Console.WriteLine($"{array[0]}, {array[1]}");