using System.Collections.Generic;
public class Journal{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry( Entry newEntry){
     _entries.Add(newEntry);
     }
    public void Display(){
        for (int i = 0; i < _entries.Count; i++){
            
            _entries[i].Display();
            
        }

    }
    public void Save(){
        String file;
        Console.WriteLine("Please, insert the file where you want to save this changes");
        file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file)){
        for (int i = 0; i < _entries.Count; i++){
         outputFile.WriteLine($"{_entries[i]._date},{_entries[i]._questionText},{_entries[i]._entryText}");

        }
        
        
        }

    
    }

    public void Clear(){
      
       for(int j = 0; j < _entries.Count; j++){
       
       _entries.RemoveAt(j);

       }
       
      
    }
    public void Load(){
        String file;
        Console.WriteLine("Please select the file what yo want to see all ");
        file = Console.ReadLine();
        String [] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines){
         string[] parts = line.Split(",");
          Entry newEntry2 = new Entry();
          newEntry2._date = parts[0];
          newEntry2._questionText = parts[1];
          newEntry2._entryText = parts[2];
          AddEntry(newEntry2);
    
}    
        }


}