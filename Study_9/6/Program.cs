// Разворот массива

int[] array = {1, 2, 3, 4, 5};
System.Console.WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length / 2; i++)
{
    array[i] = array[i] + array[array.Length - 1- i];
    array[array.Length - 1- i] = array[i] - array[array.Length - 1- i];
    array[i] = array[i] - array[array.Length - 1- i];
}

System.Console.WriteLine(String.Join(" ", array));