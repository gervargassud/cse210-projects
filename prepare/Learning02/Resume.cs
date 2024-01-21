using System;
public class Resume{

    public String _name;
    public List<Jobs> _jobs = new List<Jobs>();
  
    public void displayResumeInformation(){

    Console.WriteLine($"{_name}");

    foreach(Jobs job in _jobs){

           job.DisplayJobInformation();

    }

    }
}