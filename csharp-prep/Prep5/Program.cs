using System;

class Program
{   
    static void WelcomeMessage(){
        Console.WriteLine("Hi! Welcome to this simple Function Activity: ");
    }

    static string YourName(){
        string name;
        Console.WriteLine("Please, tell me your name:");
        name = Console.ReadLine();
        return name;
    }
    static int FavNumber(){
       int number;
       string numberSTR;
       Console.WriteLine("Please, Insert your favourinte number:");
       numberSTR = Console.ReadLine();
       number = int.Parse(numberSTR);
       return number;
    }

    static int SquareNumber(int number1){
        int SQNumber = number1 * number1;
        return SQNumber;
    }

    static void ViewResults (String name1,int number2, int SQNumber1){
        Console.WriteLine("Your name is: "+name1+ "\nYour favourite number is: "+number2+ "\nThe Square of your number is: "+SQNumber1);
    }
    static void Main(string[] args)
    {
        int number;
        string name;
        int SQNumber;
        name = YourName();
        number = FavNumber();
        SQNumber = SquareNumber(number);
        ViewResults(name, number, SQNumber);
}
}