// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("World, Hello!");
Console.WriteLine("Hello, World!");

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


static double CalculateAverage(int[] values)
{
    int summm = 0;
    foreach (int value in values)
    {
        summm += value;
    }
    return summm / values.Length;
}



Console.WriteLine("World, Hello!");
Console.WriteLine("Adding max function");