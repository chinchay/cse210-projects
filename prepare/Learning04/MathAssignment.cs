public class MathAssignment : Assignment
{
    string _textBookSection;
    string _problems;

    public MathAssignment(
        string studentName, string topic,
        string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        string text = $"Section {_textBookSection} Problems {_problems}";
        return text;
    }
}