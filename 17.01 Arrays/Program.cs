int[,] array2D = { { 3,5,18,-2,}, {12,17,6,7 }, {20,2,19,99 } };

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        Console.Write("\t"+array2D[i, j] + " ");
    }
    Console.WriteLine();
}

int k = 1;
int min;
int max = min= array2D[0,0];
double d = 0;

Console.WriteLine();

foreach(var x in array2D)
{
    if (max < x)
    {
        max = x;
    }
    if (min > x)
    {
        min = x;
    }
    d += x;
    Console.Write("\t"+x);
    if (k == array2D.GetLength(1))
    {
        Console.WriteLine();
        k= 0;   
    }
    k++;
}
Console.WriteLine($"Max = {max} Min = {min } d = {Math.Round(d/(array2D.GetLength(0)*(array2D.GetLength(1))),2)}");
Console.ReadKey();