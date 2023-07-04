// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
int[] Dict(int[,] array, int min, int max)
{
    int[] result = new int[max - min + 1];
    // 0   1      2 3 4 5 6 7
    //min min + 1...        max - частота встречаемости
    // 0   1      2 3 
    // -5  -4
    // 5   6  7

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int index = array[i, j] - min;     // min = -5                       
            result[index]++;                    // array[i, j] = -4                      
        }                                       // index = -4 -(-5) = -4 + 5 = 1
    }
    return result;
}
void Result(int[] dict, int min)
{
    for (int i = 0; i < dict.Length; i++)
    {
        Console.WriteLine($"Число {i + min} встречается {dict[i]} раз(а)");
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int[] dictionary = Dict(myArray, minValue, maxValue);
Result(dictionary, minValue);