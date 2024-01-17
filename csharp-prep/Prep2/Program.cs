using System;

Console.WriteLine("Hi! Please, tell me you your grade porcentage: ");
string gradestring = Console.ReadLine();
int grade = int.Parse(gradestring);
String letter;
if (grade >= 90)
{
    letter = "A";
    Console.WriteLine("Your Letter Grade is " + letter);
}
else
{
    if (grade >= 80 && grade < 90)
    {
        letter = "B";
        Console.WriteLine("Your Letter Grade is " + letter);
    }
    else
    {
        if (grade >= 70 && grade < 80)
        {
            letter = "C";
            Console.WriteLine("Your Letter Grade is " + letter);
        }
        else
        {
            if (grade < 60 || grade >= 70)
            {
                letter = "F";
                Console.WriteLine("Your Letter Grade is " + letter);
            }
            else
            {
                letter = "D";
                Console.WriteLine("Your Letter Grade is " + letter);

            }
        }
    }
}

if (grade > 70)
{

    Console.WriteLine("Congratulations! You Pass the Class");

}
else
{

    Console.WriteLine("Sorry, you did not pass the Class.");

        }
