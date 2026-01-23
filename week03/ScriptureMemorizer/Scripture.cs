using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private static Random _rand = new Random(); // Static to help prevent repeated scriptures.

    public Scripture(Reference reference, string text)
    // creates an array of words from the string text, then creates a word object for each word in the array
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    public static Scripture LoadRandomScripture()
    // Chooses a random scripture from a scripture library file that I created and defines all of its parts. Instantiates a new reference and a new scripture and returns the scripture. Static so I can call it directly with Scripture.LoadRandomScripture() in my Program.cs file without needing parameters
    {
        string[] lines = File.ReadAllLines("ScriptureLibrary.txt");
        string randomLine = lines[_rand.Next(lines.Length)]; //Picks a random line

        string[] parts = randomLine.Split("~~");
        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int verse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);
        return scripture;
    }

    public void HideRandomWords(int numberToHide)
    // Gets a random word and hides it. Loop continues until it reaches the specified numberToHide and not all words are completely hidden
    {
        int hidden = 0;

        while (hidden < numberToHide && !IsCompletelyHidden())
        {
            int index = _rand.Next(_words.Count); //gets index of random word
            if (!_words[index].IsHidden()) //checks if word is already hidden
            {
                _words[index].Hide(); //hides random word
                hidden++; //counts how many words are hidden
            }
        }

    }

    public void GetDisplayText()
    // Displays the text of the reference and scripture with words shown or hidden
    {
        Console.Write($"{_reference.GetDisplayText()} ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
    }
    
    public bool IsCompletelyHidden()
    // Checks if all words in the program are hidden and ends the program if they are
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
        
    }
}