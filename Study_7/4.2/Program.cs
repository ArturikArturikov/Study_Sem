Console.Clear();
System.Console.WriteLine("число: ");
int num = int.Parse(Console.ReadLine());
string count = "";

while (num > 0)
{
	count = num % 2 + count;
	num = num / 2;
}
System.Console.WriteLine(count);