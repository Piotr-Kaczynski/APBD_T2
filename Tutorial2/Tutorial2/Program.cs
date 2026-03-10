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

static int CalculateMax(int[] values)
{
    int max = values[0];
    foreach (int value in values)
    {
        if (value > max)
            max = value;
    }
    return max;
}

static int CalculateMin(int[] values)
{
    int min = values[0];
    foreach (int value in values)
        {
        if (value < min)
            min = value;
        }
    return min;
}

Console.WriteLine("World, Hello!");
Console.WriteLine("Adding max function");