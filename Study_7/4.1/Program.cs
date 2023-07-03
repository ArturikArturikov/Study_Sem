int[] Division (int num)
{
    int temp = num;
    int index = 0;
    int res = num;
    while(temp != 0)
    {
        temp = temp / 2;  
        index++;
    }
    int[] array = new int[index];
    for (int i = 0; i < array.Length; i++)
    {
        res = num % 2;
        num = num / 2;
        array[i] = res;
    }
    return array;
}

void RevArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

int number = InputNum("Введите число");
int[] myArray = Division(number);
PrintArray(myArray);
RevArray(myArray);
PrintArray(myArray);