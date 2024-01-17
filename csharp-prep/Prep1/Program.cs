using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Name?");
        string Name = Console.ReadLine();
        Console.WriteLine("What is your LastName");
        string LastName = Console.ReadLine();

        Console.WriteLine("Your name is "+Name +", "+Name +" " + LastName);
        
    }
}