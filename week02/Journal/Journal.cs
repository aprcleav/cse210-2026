public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    // Adds new entry to _entries list
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    // Iterates through _entries list and displays each entry
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void SaveJournal(string filename)
    // Asks user for a filename, then iterates through the list of entries and saves them to the file
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("DATE\tPROMPT\tRESPONSE\tMOOD"); // Creates a clean header row for Excel
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}\t{e._prompt}\t{e._response}\t{e._mood}"); // Uses '\t' as the delimiter so the file will open nicely in Excel when you open the file in this manner: Data>From Text/CSV and choose "tab" as the delimiter in Excel
            }
        }
        Console.WriteLine("Journal saved.");
        Console.WriteLine();
    }

    public void LoadJournal(string filename)
    // Asks user for a filename, then creates an array of strings from each line and iterates through them. Creates a new entry and assigns each part to the correct entry variable and saves it to the _entries list.
    {
        _entries.Clear();
        Console.WriteLine("Reading entries from file...");
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines.Skip(1)) // Skips the header row, then iterates through each line
        {
            string[] parts = line.Split("\t"); // Splits the line at the tab so Excel can more easily read the file
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            newEntry._mood = parts[3];
            _entries.Add(newEntry);
        }
        Console.WriteLine("Entries loaded.");

    }
}