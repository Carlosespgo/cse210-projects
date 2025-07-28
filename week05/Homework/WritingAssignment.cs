public class WritingAssignment : Assignment
{
    private string _tittle;

    public WritingAssignment(string studentName, string topic, string tittle) : base(studentName, topic)
    {
        _tittle = tittle;
    }

    public string GetWritingInformation()
    {
        return $"{_tittle} by {_studentName}";
    }
}