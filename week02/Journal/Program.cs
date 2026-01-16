// Showing Creativity: I used AI to help me learn how to save to a csv file in a way that would open correctly in Excel. Using '\t' as the delimiter seems to work well for this as long as the file is opened in the correct way in Excel (Data>From Text/CSV). I added code to write a header row before adding each entry to the file, then to skip the header row when reading from a file. I also threw in a few extra journal prompts and added a _mood variable to the Entry class. In the NewEntry() method, I added code to ask the user to rate how they feel on a scale of 1-5. They can use this to track their mood over time, which can be helpful for people struggling with mental illness. In Excel, they can quickly see which days were rated a 1, and read the entries for those days to see if there are any negative thought patterns or common triggers.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int menuChoice;

        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load entries from a file");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                Entry myEntry = new Entry();
                myEntry.NewEntry();
                myJournal.AddEntry(myEntry);
            }
            else if (menuChoice == 2)
            {
                myJournal.DisplayJournal();
            }
            else if (menuChoice == 3)
            {
                Console.Write("Please enter the filename: ");
                string filename = Console.ReadLine();
                myJournal.LoadJournal(filename);
            }
            else if (menuChoice == 4)
            {
                Console.Write("Please enter file name: ");
                string filename = Console.ReadLine();
                myJournal.SaveJournal(filename);
            }
            else
            {
                break;
            }
            
        } while (menuChoice != 5);

    }
}

