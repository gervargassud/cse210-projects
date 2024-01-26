using System;
using System.Collections;
using System.Dynamic;
using System.Formats.Asn1;
using System.IO;
using System.Security.Cryptography;

class Program
{
    
    static String getRandomQuestion(){
       //function to read the question.txt. and get a random question.
       String questionFile = "Questions.csv";
       String[] questionLines = System.IO.File.ReadAllLines(questionFile);
       Random randomQuestion = new Random();
       int randomNumber = randomQuestion.Next(1,questionLines.Length);
       return questionLines[randomNumber];
    }
    static String getTodaysDate(){
        //function to know what is the actual day and return as a String.
        DateTime todaysDate = DateTime.Now;
        String todaysDateText = todaysDate.ToShortDateString();
        return todaysDateText;
    }
    static Entry getEntryData(){
        //function to get the data to be added to the journal. return the question and the response to be save.
    Entry entries = new Entry();
     entries._date = $"{getTodaysDate()}";//calling the function getTodaysDate.
     entries._questionText =$"{getRandomQuestion()}";//calling the function getRandomQuestion
     entries.Display();//calling the function display in entry class
     entries._entryText = Console.ReadLine();
     return entries;
    } 
    
    
    static void optionSelected(){
        // function to know what to do when the options are selected
        Journal newJournal = new Journal();
        int option;         
        //calling menu function
       do 
       {
        option = Menu();
        switch(option){

            case 1:
               Console.WriteLine("Please response the following answer: ");
               newJournal.AddEntry(getEntryData());//getEntryData();//calling function write
               break;
            case 2:
              
               newJournal.Display();
               break;
            case 3:
                newJournal.Clear();
                newJournal.Load();
                
                
               break;
            case 4:
                newJournal.Save();
                
                
        
                
                
                
               break;
            
          
        } 
            
         
         } while (option!=5);
         return;
       }

    //static Journal Write(){
        //function to ask the user to response, calling get entry date
       // Journal questionAndResponse = new Journal();
       // Console.WriteLine("Please response the following answer: ");
       // questionAndResponse = getEntryData();//calling the function get entry data
       // return questionAndResponse;

    //}
    
    static int Menu(){
        //function to know what option the user will take.
        Console.WriteLine("Welcome to the best Journal in the world! What you want to do?");
        Console.WriteLine("Please select one option");
        Console.WriteLine("1) Write\n2) Display \n3) Load \n4) Save \n5) Quit");
        String strOption = Console.ReadLine();
        while (strOption != "1" && strOption != "2" && strOption != "3" && strOption!= "4" && strOption != "5"){
            Console.WriteLine("Please, choose a valid option");
            Console.WriteLine("Welcome to the best Journal in the world! What you want to do?");
            Console.WriteLine("Please select one option");
            Console.WriteLine("1) Write\n2) Display \n3) Load \n4) Save \n5) Quit");
            strOption = Console.ReadLine();
        }
        int option = int.Parse(strOption);
        return option;
               
       
    }
    
    static void Main(string[] args){
    optionSelected();
    }
}
