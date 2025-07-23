using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string user, string text)
    {
        Comment comment = new Comment(user, text);
        comment.GetDisplayText();
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of comments: {GetCommentCount()}");
        foreach (Comment comm in _comments)
        {
            Console.WriteLine($"-{comm.GetDisplayText()}");
        }
    }
}
