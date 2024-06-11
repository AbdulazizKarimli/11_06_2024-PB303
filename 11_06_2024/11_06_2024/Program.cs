using _11_06_2024;
using _11_06_2024.Helpers;

#region Extension Methods
//int number = 6;

//Console.WriteLine(number.IsOdd());
//bool IsOdd(int num)
//    => num % 2 != 0;
#endregion

//Person person = new Person("Akber", "Ceferov");
Student student = new("Ferid", "Bendiyev", 90);
Developer developer = new Developer("Asiman", "Qasimzade", 700);
BackendDeveloper backendDeveloper = new("Orxan", "Nagizade", 5100, "Team Lead");
//Console.WriteLine(person.GetInfo());
Console.WriteLine(student.GetInfo());
Console.WriteLine(developer.GetInfo());
Console.WriteLine(backendDeveloper.GetInfo());
student.Eat();

Person[] people = new Person[] { /*person,*/ student };
//foreach (var item in people)
//{
//    Console.WriteLine(item.GetInfo());
//}