using Overload;

class Program
{
    static void Main(string[] args)
    {
        Value v = new Value();
        
        v.Output(2);
        v.Output(2.5);
        v.Output("Hello World");
    }
}