namespace OOP;
public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string UniversityName { get; set; }

    public void DisplayInfo()
    {
        string response = $"Name : {Name} , LastName : {LastName} ," +
            $" Age : {Age} , UniversityName : {UniversityName}";

        Console.WriteLine(response);
    }

}
