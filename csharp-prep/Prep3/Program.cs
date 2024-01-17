using System;
using System.Security.Cryptography;

bool guessed = false;

Random randomGenerator = new Random();
int mNumber = randomGenerator.Next(1,100);
Console.WriteLine("Lets play a funny game, try to Guess what number I am Thinking:");

while (guessed == false){
Console.WriteLine("What is your guess?");
string mGuessStr = Console.ReadLine();
int mGuessNumber = int.Parse(mGuessStr);


if (mGuessNumber == mNumber){
    guessed = true;
    Console.WriteLine("You Guessed it!");
} else {
    if (mGuessNumber < mNumber){
        Console.WriteLine("The number is higher than yourst");
    } else {
        Console.WriteLine("The number es Lower than yourst");
    }
}

}
