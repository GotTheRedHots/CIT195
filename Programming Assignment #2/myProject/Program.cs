using System;

namespace myProject
{
    class myMusic    {
        static void Main(string[] args)
        {
            show Paramore = new show();
            Paramore.SetId(300);
            Paramore.SetVenue("The Villa");
            Paramore.SetBand("Paramore");

            show BonesUK = new show();
            Console.WriteLine("Please enter the show ID: ");
            BonesUK.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the show venue: ");
            BonesUK.SetVenue(Console.ReadLine());
            Console.WriteLine("Please enter the band name: ");
            BonesUK.SetBand(Console.ReadLine());

            show Ruskaja = new show(42, "Wembley", "Ruskaja");

            Console.WriteLine("Please enter the show ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the venue: ");
            string tempVenue = Console.ReadLine();
            Console.WriteLine("Please enter the band name: ");
            string tempBand = Console.ReadLine();
            show Frankenstein = new show(tempID, tempVenue, tempBand);

            DisplayShows(Paramore);
            DisplayShows(BonesUK);
            DisplayShows(Ruskaja);
            DisplayShows(Frankenstein);
        }

        static void DisplayShows(show member)
        {
            Console.WriteLine("Here's your show's information");
            Console.WriteLine($"Show ID: {member.GetId()}");
            Console.WriteLine($"Show title: {member.GetVenue()}");
            Console.WriteLine($"Show author: {member.GetBand()}");
        }


    }
}

class show
{
    private int _id;
    string _venue;
    string _band;

    public show() { }

    public show(int id, string venue, string band)
    {
        _id = id;
        _venue = venue;
        _band = band;
    }

    public int GetId()
    {
        return _id;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public string GetVenue()
    {
        return _venue;
    }

    public void SetVenue(string venue)
    {
        _venue = venue;
    }

    public string GetBand()
    {
        return _band;
    }

    public void SetBand(string band)
    {
        _band = band;
    }

}