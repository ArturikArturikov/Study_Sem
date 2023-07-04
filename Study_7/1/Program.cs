// array[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2);
// array[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);
// array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);

double Diff (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return Math.Round(max - min, 2);
}


// int pos = InputNum("Введите размер массива: ");
// double[] myArray = CraeteArray(pos);
// FillArray(myArray);
// PrintArray(myArray);

// double difference = Diff(myArray);
// Console.WriteLine(difference);