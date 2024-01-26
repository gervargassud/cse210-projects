public class Entry{
    public String _date;
    public String _questionText;
    public String _entryText;

    public  void Display(){

        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Question: {_questionText}");
        Console.WriteLine($"Response: {_entryText}");

    }

    

}