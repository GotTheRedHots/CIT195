interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}
class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s annual salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}
sealed class Executive : Employee
{
    public double Salary { get; set; }
    public string Title { get; set; }

    public Executive() : base()
    {
        Salary = 0;
        Title = "";
    }
    public Executive(int id, string firstName, string lastName, double salary, string title)
        : base(id, firstName, lastName)
    {
        Salary = salary;
        Title = title;
    }

    public override double Pay()
    {
        double execBonus = 10000;
        if (Salary > 150000)
            return  Salary+ execBonus;
        else
            return Salary;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee Darell = new Employee(20517, "Darrel", "Wilkinson");

        Executive Brad = new Executive(10376,"Brad", "Waters",151000,"VP of the Northwest");

        Console.WriteLine($"{Darell.Fullname()} is paid {Darell.Pay()} annually.");
        Console.WriteLine($"{Brad.Fullname()} is a {Brad.Title} and is paid {Brad.Pay()} annually.");
    }

}