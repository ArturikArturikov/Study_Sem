// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.

int InputNum(string message)
{
	Console.Write(message);
	return int.Parse(Console.ReadLine()!);
}


void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i, j] = i + j;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			System.Console.Write($"{array[i, j]}\t");
			System.Console.WriteLine();
	}
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] myArray = new int[rows, columns];

FillArray(myArray);
PrintArray(myArray);