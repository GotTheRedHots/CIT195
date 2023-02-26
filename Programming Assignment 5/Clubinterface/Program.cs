using System;
namespace Club
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
    }
    class Program
    {
        class Club : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Rank { get; set; }

            public Club()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Rank = 0;
                
            }
            public Club(int id, string firstName, string lastName, int rank)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Rank = rank;
                
            }

            public void Display()
            {
                Console.WriteLine($"Club member {Id}'s name is {FirstName} {LastName} and their rank is {Rank}.");
            }
            
        }
        static void Main(string[] args)
        {
            // Club object created using parameterized constructor
            Club Joe = new Club(101, "Joe", "Jackson", 1);
            Joe.Display();

        }
    }
}