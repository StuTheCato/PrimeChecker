namespace Overload;

public class Value
{
    public void Output(int x)
    {
        Console.WriteLine($"Number: {x}");
    }

    public void Output(double x)
    {
        Console.WriteLine($"Double: {x}");
    }

    public void Output(string x)
    {
        Console.WriteLine($"String: {x}");
    }
}