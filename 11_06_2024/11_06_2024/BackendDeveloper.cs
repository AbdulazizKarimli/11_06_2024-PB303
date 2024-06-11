namespace _11_06_2024;

public class BackendDeveloper : Developer
{
    public string Level { get; set; }

    public BackendDeveloper(string name, string surname, int salary, string level) : base(name, surname, salary)
    {
        Level = level;
    }

    public override sealed string GetInfo()
    {
        return $"{base.GetInfo()} - Level: {Level}";
    }
}