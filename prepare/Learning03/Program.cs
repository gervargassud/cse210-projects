using System;

class Program
{
    static void Main(string[] args)
    {
        Function function1 = new Function();
        Console.WriteLine(function1.GetFractionString());
        Console.WriteLine(function1.GetDecimalValue());
        Function function2 = new Function(5);
        Console.WriteLine(function2.GetFractionString());
        Console.WriteLine(function2.GetDecimalValue());
        Function function3 = new Function(3,4);
        Console.WriteLine(function3.GetFractionString());
        Console.WriteLine(function3.GetDecimalValue());
        
    
    }
}