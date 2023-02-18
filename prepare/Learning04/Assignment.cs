public class Assignment {
    string _studentName;
    string _topic;

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() {
        string message = $"{_studentName} - {_topic}";
        return message;
    }
}