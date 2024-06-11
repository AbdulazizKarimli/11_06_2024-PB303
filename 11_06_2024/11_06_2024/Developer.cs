namespace _11_06_2024;

public class Developer : Person
{
    public int Salary { get; set; }

    public Developer(string name, string surname, int salary) : base(name, surname)
    {
        Salary = salary;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()} - Salary: {Salary}";
    }

    public override void Eat()
    {
        Console.WriteLine("Eat as Developer");
    }
}