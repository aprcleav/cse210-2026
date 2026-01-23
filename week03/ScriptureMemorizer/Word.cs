using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    // Hides a word by replacing each character in the word with an underscore. I struggled with this one and asked AI "how to replace all characters in a word with unserscores in C#" and it suggested using Regex.Replace and the "." pattern to match any single character. It works! 
    {
        string hiddenWord = Regex.Replace(_text, ".", "_");
        _text = hiddenWord;
    
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        return _text;
    }
}