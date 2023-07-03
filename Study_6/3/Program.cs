// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-10, 11);
}

bool FindNum(int[] array, int num)
{
	for (int i = 0; i < array.Length; i++)
		if (array[i] == num)
			return true;

	return false;
}

void PrintArray(int[] array)
{
	foreach (int item in array)
		Console.Write($"{item} ");
	System.Console.WriteLine();
}

int[] newArray = new int[50];
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);


FillArray(newArray);
PrintArray(newArray);
Console.WriteLine(FindNum(newArray, num));