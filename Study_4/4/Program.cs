// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
 int Factorial(int num)
 {
    int multipl = 1;
    for (int i = 1; i <= num; i++)
    {
        multipl = multipl*i;
    }
    return multipl;
 }
 int num = InputNum("Введите целое число: ");
 int fact = Factorial(num);
 Console.WriteLine(fact);