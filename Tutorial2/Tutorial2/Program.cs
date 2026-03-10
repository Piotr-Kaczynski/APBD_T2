// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("World, Hello!");
Console.WriteLine("Hello, World!");

static double CalculateAverage(int[] values)
{
    int sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    return sum / values.Length;
}

Console.WriteLine("World, Hello!");
Console.WriteLine("Adding max function");