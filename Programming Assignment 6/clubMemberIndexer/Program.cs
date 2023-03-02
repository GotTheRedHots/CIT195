using System.Drawing;

class Clubs
{
    public const int size = 15;  // global variable
    private string[] Members = new string[size];

    public string ClubType { get; set; }
    public string ClubLocation { get; set; }
    public string MeetingDate { get; set; }

    // constructor
    public Clubs()
    {
        for (int i = 0; i < size; i++)
        {
            Members[i] = string.Empty;
        }
    }
    //indexer get and set methods
    public string this[int i]
    {
        get
        {
            return Members[i];
        }
        set
        {
            Members[i] = value;
        }
    }
    public string DisplayMembers()
    {
        string allMembers = string.Empty;
        for (int i = 0; i < size; i++)
        {
            if (Members[i] != string.Empty)
            { 
                allMembers += ($"{Members[i]}, ");
            }
        }
            return allMembers.Trim(',', ' ');
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clubs football = new Clubs();
        football[0] = "Bob";
        football[1] = "Dave";
        football[2] = "Colin";
        football.ClubType = "American Footbal";
        football.ClubLocation = "building 5";
        football.MeetingDate = "Every Other Tuesday";

        Console.WriteLine
            ($"The {football.ClubType} club meets {football.MeetingDate} in {football.ClubLocation} and its members include:{football.DisplayMembers()}. ");
    }
}