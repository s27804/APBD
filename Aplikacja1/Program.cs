// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double average(int[] table)
{
    int sum = 0;
    for (int i = 0; i < table.Length; i++)
        sum += table[i];

    double result = sum / table.Length;
    Console.WriteLine(result);
    return result;
}

int[] table = [1,2,3,4,5];
average(table);