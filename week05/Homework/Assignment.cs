public class Assignment
{
    private string _studentName;
    private string _topic;

public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} has submitted an assignment on {_topic}.";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    
}