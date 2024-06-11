namespace _11_06_2024;

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, string surname, int grade) : base(name, surname)
    {
        Grade = grade;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()} - Grade: {Grade}";
    }

    public override void Eat()
    {
        Console.WriteLine("Eat as Student");
    }
}