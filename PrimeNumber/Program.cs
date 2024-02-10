using PrimeNumber;

class Program
{
    static void Main(string[] args)
    {
        Number num = new Number();

        Console.Write("At which number do you like to start? (default 2): ");
        int start = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("At which number do you like to end?: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Prime numbers at {start} to {end}");

        for (int i = start; i <= end; i++)
        {
            if (num.IsPrime(i))
                Console.WriteLine(i);
        }
    }
}