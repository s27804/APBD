// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double average(int[] table)
{
    int sum = 0;

    for (int x = 0; x < table.Length; x++)
        sum += table[x];

    double result = sum / table.Length;
    Console.WriteLine(result);
    return result;
}

static int maxValue(int[] table)
{
    int max = 0;
    for(int i = 0;i < table.Length;i++)
    {
        if (table[i] > max)
            max = table[i];
    }
    Console.WriteLine(max);
    return max;
}

int[] table = [1, 2, 5, 4, 3];
average(table);
maxValue(table);