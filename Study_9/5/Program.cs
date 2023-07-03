// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int InputNum(string message)
{
	Console.Write(message);
	return int.Parse(Console.ReadLine()!);
}
void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i, j] = rnd.Next(min, max + 1);
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
int ChangeArray(int [,] array)
{
    int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
        if (i==j) sum = sum + array[i,j];
    }
    return sum;
} 
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int maxValue = InputNum ("ВВедите максимум диапазона");
int minValue = InputNum ("ВВедите минимум диапазона");
int [,] myArray = new int[rows,columns];
FillArray(myArray,minValue,maxValue);
PrintArray(myArray);
Console.WriteLine("");
int result = ChangeArray(myArray);
Console.WriteLine(result);