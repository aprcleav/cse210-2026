using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    // return number of comments
    {
        return _comments.Count;
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}\nLength: {_length} seconds\nComments: {NumberOfComments()}\n");
    }
}