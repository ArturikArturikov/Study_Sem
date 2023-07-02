// Ставим точку в конце строки

int[] InputSomeNums()
{
    Console.Write("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-e число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
// int[] array = InputSomeNums();
// Console.WriteLine($"{array[0]}, {array[1]}");
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        else
            Console.Write("."); 
    }
}

int[] maArray = InputSomeNums();
PrintArray(maArray);