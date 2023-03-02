using Microsoft.VisualBasic;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // constructor for ID only
    public Student(int id)
    { 
        this.Id = id;
        FirstName = "";
        LastName = "";
    }
    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

}
class Program
{
    public static void Main()
    {
        Student firstStudent= new Student(1);
        firstStudent.FirstName = "Jack";
        firstStudent.LastName = "Black";

        Student secondStudent= new Student(2,"Miley", "Cyrus");

        Console.WriteLine($"My first student's name is {firstStudent.FirstName} {firstStudent.LastName} and their ID is {firstStudent.Id}.");
        Console.WriteLine($"My second student's name is {secondStudent.FirstName} {secondStudent.LastName} and their ID is {secondStudent.Id}.");
    }
}