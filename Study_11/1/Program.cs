/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// int num = InputNum("Введите целое число: ");
// Console.WriteLine(PrintNumbers(1, num));

void PrintNumbers(int start, int end)
{
    if (start > end) return; // ничего не возвращаем поэтому start > end
    Console.WriteLine(start + " ");
    PrintNumbers(start + 1, end);  // ++start сначала увеличиваем значение, а потом вызов функции
}
int num = InputNum("Введите целое число: ");
PrintNumbers(1, num);


// void PrintNumbers(int start, int end)
// {
//     if (start > end) return; // ничего не возвращаем поэтому start > end
//     PrintNumbers(start + 1, end);  // ++start 1+2+3+4+5 стек собрался и 
//     Console.WriteLine(start + " "); // раскручивается в обратную сторону 5 4 3 2 1
//     
// }
// int num = InputNum("Введите целое число: ");
// PrintNumbers(1, num);