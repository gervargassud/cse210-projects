using System;
using System.Collections.Generic;

int numbers = 1;
List<int> numbersAdded = new List<int>();
int Sum = 0;
float average = 0;
int i;
int largest = 0;
while (numbers != 0)
{
    String NumberSTR;
    Console.WriteLine("Please, insert a number to be included in your list (put the number 0 at the end to finish the record)");
    NumberSTR = Console.ReadLine();
    numbers = int.Parse(NumberSTR);
    numbersAdded.Add(numbers);
}
for (i = 0; i < numbersAdded.Count; i++)
{

    Sum += numbersAdded[i];
}
average = Sum / i;
for (int j = 0; j < numbersAdded.Count; j++)
{

    if (numbersAdded[j] > largest)
    {

        largest = numbersAdded[j];

    }
}

Console.WriteLine("Hi! I have the following results: \n1)Sum = " +Sum + "\n2)Average = " +average+ "\n3)Largest number = "+largest);
