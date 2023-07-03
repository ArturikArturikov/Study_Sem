string[,] table = new string[2, 5];

// String.Empty
// table[0,0]   table[0,1]  table[0,2]
// table[1,0]   table[1,1]  table[1,2]

table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}