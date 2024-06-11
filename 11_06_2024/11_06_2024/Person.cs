namespace _11_06_2024;

public abstract class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public abstract void Eat();

    public virtual string GetInfo()
    {
        return $"Name: {Name} - Surname: {Surname}";
    }
}