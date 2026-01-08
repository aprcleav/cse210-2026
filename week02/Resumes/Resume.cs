public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Instantiate new List object
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job j in _jobs) // Iterates through each job in jobs list
        {
            j.DisplayJob(); // Calls the DisplayJob() method from the Job class
        }
        
    }
}