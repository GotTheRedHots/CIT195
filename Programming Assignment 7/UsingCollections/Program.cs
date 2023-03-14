using System;
using System.Collections.Generic;

namespace FunwithQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a) Use the Queue<T> collection.
            add 5 items.
            Check to see if the queue contains a specific item and display a message. (Do not remove this item from the queue.)
            Remove at least 1 different item from the queue.
            Count the items in the queue and display the count.
            Print all the items in the queue.*/
            Queue<string> ticketHolders = new Queue<string>();

            ticketHolders.Enqueue("Juan Doe");
            ticketHolders.Enqueue("Jane Doe");
            ticketHolders.Enqueue("Jack Flash");
            ticketHolders.Enqueue("Jonny B Good");
            ticketHolders.Enqueue("Bridget Jones");

            Console.WriteLine($"Bridget Jones is coming to the show? {ticketHolders.Contains("Bridget Jones")}");
            ticketHolders.Dequeue();
            Console.WriteLine($"Someone had to drop out and only these {ticketHolders.Count} people can make it to the show now:");
            foreach (string ticketHolder in ticketHolders) { Console.WriteLine(ticketHolder); }

            /*b) Use the PriorityQueue<T> collection
            Add 5 items.
            Find and display the highest priority item, then remove the item.
            Continue displaying the highest priority item and removing it until all items are removed.*/

            // Create the queue
            // The data items are strings. The second type parameter (an int) indicates the priority

            Console.WriteLine();
            PriorityQueue<string, int> bandOrder = new PriorityQueue<string, int>();

            bandOrder.Enqueue("Skillet", 2);
            bandOrder.Enqueue("In This Moment", 1);
            bandOrder.Enqueue("Bring Me The Horizon", 3);
            bandOrder.Enqueue("Slipknot", 4);
            bandOrder.Enqueue("Tool", 5);

            for (int i = 0; i <= bandOrder.Count;) 
            {
                if (bandOrder.Count != 0)
                {
                    Console.WriteLine($"The top billed act, {bandOrder.Peek()} cancelled.");
                    bandOrder.Dequeue();
                }
                else
                {
                    Console.WriteLine("There are no more bands left.");
                    break;
                }
            }

            /*c) Use the Stack<T> collection.
            Add 5 items.
            Check to see if the stack contains a specific item and display a message.
            Remove at least 1 item.
            Count the items in the stack and display the count.
            Print all the items in the stack.*/

            Console.WriteLine();
            Stack<string> standbyLine = new Stack<string>();
            //adding members
            standbyLine.Push("Brad");
            standbyLine.Push("Julie");
            standbyLine.Push("Evan");
            standbyLine.Push("Daniel");
            standbyLine.Push("Kevin");

            Console.WriteLine($"Kevin is in line: {standbyLine.Contains("Kevin")}");
            Console.WriteLine("The last person to get in line gave up and went home.");
            standbyLine.Pop();
            Console.WriteLine($"The {standbyLine.Count()} people still in line are:");
            foreach (var stander in standbyLine)
                { Console.WriteLine(stander); }


            /*d) Use the LinkedList<T> and LinkedNodeList<T> collections.
            Add 5 items to a linked list.
            Retrieve and display the first node.
            Retrieve and display the last node.
            Add a 6th item to the middle of the list.
            Remove a node from the list (it can be the first, last, or a node with a specific value).
            Count the items in linked list and display the count.
            Print all the items in the linked list.*/

            Console.WriteLine();
            string[] crewMembers = { "Mickey", "Miley", "Donald", "Peter", "Gus", "Daisy" };
            LinkedList<string> tourCrew = new LinkedList<string>(crewMembers);
            Console.WriteLine($"The first crew member listed is {tourCrew.First()}");
            Console.WriteLine($"The last crew member listed is {tourCrew.Last()}");
            tourCrew.AddAfter(tourCrew.Find("Donald"), "Pete");
            tourCrew.AddLast("Molly");
            Console.WriteLine($"After a few changes in staff, the crew has these {tourCrew.Count()} members:");
            foreach (var member in tourCrew)
            { Console.WriteLine(member); }

            /*e) Use the Dictionary<TKey, TValue> collection
            Add 5 items to a dictionary
            Retrieve and display all the keys
            Retreive and display all the values
            Retrieve and display both the keys and the values
            Remove an item from the dictionary
            Display a count of the dictionary items.*/

            Console.WriteLine();
            Dictionary<string, string> tourStops = new Dictionary<string, string>();

            tourStops.Add("Wembley Stadium", "London");
            tourStops.Add("Motorpoint Arena", "Nottingham");
            tourStops.Add("The Cavern Club", "Liverpool");
            tourStops.Add("Genting Arena", "Birmingham");
            tourStops.Add("The O2 Arena", "London");

            Console.WriteLine("Tour stop venues (keys)");
            Dictionary <string, string>.KeyCollection keys= tourStops.Keys;
            foreach (string key in keys)
            { Console.WriteLine(key); }
            Console.WriteLine();

            Console.WriteLine("Tour stop cities (values)");
            Dictionary <string, string>.ValueCollection values = tourStops.Values;
            foreach (string value in values) 
            { Console.WriteLine(value); }
            Console.WriteLine();

            Console.WriteLine("Tour stops venue/city (key/value)");
            foreach (KeyValuePair<string, string> kvp in tourStops)
            {
                Console.WriteLine($"Venue: {kvp.Key}  City: {kvp.Value}");
            }
            Console.WriteLine("Wembley Stadium is double booked and needs to cancel.");
            tourStops.Remove("Wembley Stadium");
            Console.WriteLine($"We have {tourStops.Count} stops left in the tour.");
            Console.WriteLine();

            /*f) Use the SortedList<TKey, TValue> collection
            Add 5 items to a sorted list
            Allow the user to enter a key and value (you will need to check to see if the key exists and handle the problem)
            Remove an item from the list (this code can be combined with #2 above if you include this in your error handling)
            Print the key and value for your sorted list.*/

            SortedList<int, string> contestPrizes = new SortedList<int, string>()
            {
                {1, "Car"},
                {2, "Cruise"},
                {3, "Weekend Getaway"},
                {4, "VIP pass"},
                {5, "Signed Guitar" }
            };
            Console.WriteLine("What prize wouldyou suggest we add??");
            string Item = Console.ReadLine();
            
            if (contestPrizes.ContainsValue(Item))
                Console.WriteLine($"{Item} is already one of the prizes.");
            else
                contestPrizes.Add(contestPrizes.Count + 1, Console.ReadLine());

            Console.WriteLine("Someone won the car!");
            contestPrizes.Remove(1);

            Console.WriteLine("The remianing prizes are:");
            foreach(KeyValuePair< int, string> prize in contestPrizes)
            {
                Console.WriteLine($"prize number: {prize.Key}, prize: {prize.Value}");
            }

                /*g) Use the HashSet<T> collection
                Add 5 items to a hashset object
                Create a similar hashset object with 5 items.
                Create a third hashset object and add 5 more items (2 items should be the same as your first or second object)
                Use a command to combine the first and second object. Store the combined items in the first object and print out the combined list.
                Create a new hashset object to store duplicates and use a command to display items that appear in both the first object and your third object. Store the results in your new hashset object.Print out the contents of the object*/

                HashSet<string> drummers = new HashSet<string>();
            drummers.Add("Garry");
            drummers.Add("Herald");
            drummers.Add("Jimmy");
            drummers.Add("Dale");
            drummers.Add("Dana");


            HashSet<string> leadGuitar = new HashSet<string>();
            leadGuitar.Add("Gordie");
            leadGuitar.Add("Holly");
            leadGuitar.Add("Jenny");
            leadGuitar.Add("Day");
            leadGuitar.Add("Daniel");


            HashSet<string> leadVocals = new HashSet<string>();
            leadVocals.Add("Guy");
            leadVocals.Add("Henry");
            leadVocals.Add("Jill");
            leadVocals.Add("Dale");
            leadVocals.Add("Dana");

            Console.WriteLine("Combined list of drummers and lead gutarists");
            drummers.UnionWith(leadGuitar);
            foreach (string drummer in drummers)
            {
                Console.WriteLine(drummer);
            }
            Console.WriteLine();

            Console.WriteLine("Drummers that sing lead vocals");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = drummers;
            bothLists.IntersectWith(leadVocals);
            foreach (string member in bothLists)
            {
                Console.WriteLine(member);
            }


            /*h) Use the List<T> collection
            Add 5 items to a list
            Use the AddRange() method to add 3 more items to a list
            Sort the list and print all the items
            Remove at least 1 item
            Sort the list in reverse order and print all items.*/

            List<string> vipList = new List<string> { "Beyonce","Mariah", "Arianna", "Christina", "Brittany"};
            string[] memberArr = new string[] { "Nick", "Justin", "Marshall"};
            vipList.AddRange(memberArr);
            vipList.Sort();
            Console.WriteLine("VIP List");
            foreach (string vip in vipList)
                Console.WriteLine(vip);
            vipList.Remove("Nick");
            vipList.Reverse();
            Console.WriteLine("VIP List reversed");
            foreach (string vip in vipList)
                Console.WriteLine(vip);

        }
    }
}