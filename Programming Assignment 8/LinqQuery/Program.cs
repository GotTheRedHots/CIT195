
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Celebrity
{
    class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
       public static void Main(string[] args)
            { 
        IList<famousPeople> stemPeople = new List<famousPeople>() {
                    new famousPeople() {Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                    new famousPeople() {Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                    new famousPeople() {Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                    new famousPeople() {Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                    new famousPeople() {Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                    new famousPeople() {Name = "Tu YouYou", BirthYear= 1930 },
                    new famousPeople() {Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                    new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                    new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                    new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                    new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                    new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                    new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                    new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                    new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                    new famousPeople() {Name = "Bill Gates", BirthYear=1955 }

         };
            Console.WriteLine("People born after 1900:");

            var Bdays = from famousPeople in stemPeople
                            where famousPeople.BirthYear > 1900
                            select famousPeople.Name;
                foreach (var name in Bdays)
                {
                    Console.WriteLine(name);
                }
            Console.WriteLine("-----------------------------------------------------");


            var doubleLs = from famousPeople in stemPeople
                        where famousPeople.Name.Contains("ll")
                        select famousPeople.Name;
            Console.WriteLine("People with two lowercase L's in their names:");
            foreach (var name in doubleLs)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------");

            var afterTheFifties = from famousPeople in stemPeople
                        where famousPeople.BirthYear > 1950
                        select famousPeople.Name;
            
                Console.WriteLine($"{afterTheFifties.Count()} were born after 1950");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine($"These people were born between 1920 and 2000:");
            var twentiesToOts = from famousPeople in stemPeople
                        where famousPeople.BirthYear > 1920 && famousPeople.BirthYear < 2000
                        select famousPeople.Name;
           
            foreach (var name in twentiesToOts)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"There are {twentiesToOts.Count()} people in this list.");
            Console.WriteLine("-----------------------------------------------------");


            var sortedList = from famousPeople in stemPeople
                             .OrderByDescending(x => x.BirthYear)
                             select famousPeople.Name;
            Console.WriteLine("Names in list by decending birth year:");
            foreach (var name in sortedList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------");



            var sixtiesToTwentyfifteen = from famousPeople in stemPeople
                                         where famousPeople.DeathYear > 1960 && famousPeople.DeathYear < 2015
                                         orderby famousPeople.Name
                                         select famousPeople.Name;
            Console.WriteLine("People born 1960 - 2015 in list by birth year:");
            foreach (var name in sixtiesToTwentyfifteen)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------");







        }
    }
    }

//Retrieve people with birthdates after 1900

//b) Retrieve people who have two lowercase L's in their name

//c) Count the number of people with birthdays after 1950

//d) Retrieve people with birth years between 1920 and 2000. Display their names and count the number of people in the list, then display the count.

//NOTE: You will need to perform a query with two where clauses to get the list of people. Then perform count on the object storing the query. Example: var birthCount = query4.Count();

//e) Sort the list by BirthYear

//f) Retrieve people with a death year after 1960 and before 2015, sort the list by name in ascending order.
