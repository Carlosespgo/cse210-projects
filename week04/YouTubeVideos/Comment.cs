public class Comment
{
    private string _commentator;
    private string _text;

    public Comment(string commentator, string text)
    {
        _commentator = commentator;
        _text = text;
    }

    public string GetDisplayText()
    {
        return $"{_commentator}: {_text}.";
    }
}
