using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book TheVilla = new book();
            TheVilla.SetId(300);
            TheVilla.SetTitle("The Villa");
            TheVilla.SetAuthor("Rachel Hawkins");
            TheVilla.SetTrans();

            book ChristmasCarol = new book();
            ChristmasCarol.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            ChristmasCarol.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            ChristmasCarol.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Author: ");
            ChristmasCarol.SetAuthor(Console.ReadLine());

            book Catcher = new book(42, "Catcher in the Rye", "J. D. Salinger");
            Catcher.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the Author: ");
            string tempAuthor = Console.ReadLine();
            book Frankenstein = new book(tempID, tempTitle, tempAuthor);
            Frankenstein.SetTrans();

            Console.WriteLine(book.GetTrans());

            DisplayBooks(TheVilla);
            DisplayBooks(ChristmasCarol);
            DisplayBooks(Catcher);
            DisplayBooks(Frankenstein);
        }

        static void DisplayBooks(book member)
        {
            Console.WriteLine("Here's your book's information");
            Console.WriteLine($"book ID: {member.GetId()}");
            Console.WriteLine($"book title: {member.GetTitle()}");
            Console.WriteLine($"book author: {member.GetAuthor()}");
        }


    }
}

class book
{
    private int _id;
    string _title;
    string _author;
    private static  int _transactions = 0;

    public void SetTrans()
    { 
        _transactions++;    
    }

    public static int GetTrans() { return _transactions; }

    public book() { }

    public book(int id, string title, string author)
    {
        _id = id;
        _title = title;
        _author = author;
    }

    public int GetId()
    {
        return _id;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

}