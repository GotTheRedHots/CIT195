using System;

namespace greatAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int lives = 0, magic = 0, health = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is the name of your character? ");
            string name = Console.ReadLine();
            initValues(ref lives, ref magic, ref health, r);
            while (lives > 0 && magic > 0 && health > 0 && win == false)
            {
                direction = chooseDirection();
                /* the direction impacts the number passed to the actions method
                 * if they choose left, they will only receive bad outcomes
                 * if they choose right, they have a better chance of receiving 
                 * good outcomes along with the bad outcomes */
                if (direction == 1)
                    actions(r.Next(4), ref lives, ref magic, ref health);
                else
                    actions(r.Next(10), ref lives, ref magic, ref health);
                checkResults(ref round, ref lives, ref magic, ref health, ref win);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully completing your journey!");
            else if (lives <= 0)
                Console.WriteLine("You lost too many lives and did not complete your journey");
            else if (magic <= 0)
                Console.WriteLine("You don't have any magic left and cannot complete your journey");
            else
                Console.WriteLine("You are in poor health and had to stop your journey before it's completion");

        }

        private static void initValues(ref int lives, ref int magic, ref int health, Random r)
        {
            lives = r.Next(1,10);
            magic = r.Next(5,15);
            health = r.Next(5,14);
        }

        private static void checkResults(ref int round, ref int lives, ref int magic, ref int health, ref bool win)
        {
            round++;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Round {round} stats: lives {lives}, magic {magic}, health {health}.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            win = round >= 25;
            return;
          
        }

        private static void actions(int diceRoll, ref int lives, ref int magic, ref int health)
        {

            switch (diceRoll)
            {
                case 0:
                    Console.WriteLine("You met three bears who were not happy that their porridge was gone.");
                    Console.WriteLine("You lose 1 unit of health and 1 unit of magic");
                    health -= 1;
                    magic -= 1;
                    break;
                case 1:
                    Console.WriteLine("You were abducted by flying monkeys and had to be rescued by a young girl and a dog");
                    Console.WriteLine("You lost 2 units of health and magic and 1 life");
                    health -= 2;
                    magic -= 2;
                    lives -= 1;
                    break;
                case 2:
                    Console.WriteLine("In the pitch black you encounter a Gru and are eaten.");
                    Console.WriteLine("You lost 3 units of health and magic and 1 life");
                    health -= 3;
                    magic -= 3;
                    lives -= 1;
                    break;
                case 3:
                    Console.WriteLine("Crowley, the king of Hell, walks in on you stealing his whiskey and feeds you to a Hell hound.");
                    Console.WriteLine("You lost 2 units of health and magic and 1 life");
                    health -= 2;
                    magic -= 2;
                    lives -= 1;
                    break;
                case 4:
                    Console.WriteLine("You run into a Rugaru but it is more afraid of you than you are of it, and it flees before you can fight it.");
                    Console.WriteLine("You walk away unscathed and are treated to 2 units of health, magic and lives by Fate");
                    health += 2;
                    magic += 2;
                    lives += 2;
                    break;
                case 5:
                    Console.WriteLine("You saved a fellow traveler from a headless horseman.");
                    Console.WriteLine("The traveler granted you 2 units of health, magic and lives");
                    health += 2;
                    magic += 2;
                    lives += 2;
                    break;
                case 6:
                    Console.WriteLine("You babysat for a women who lived in a house that resembled a shoe (she had a lot of kids).");
                    Console.WriteLine("You gain 3 units of health and magic");
                    health += 3;
                    magic += 3;
                    break;
                case 7:
                    Console.WriteLine("You have a beer with Sam and Dean Winchester after defeating a Windego.");
                    Console.WriteLine("You gained 2 units of health and magic and 1 life");
                    health += 2;
                    magic += 2;
                    lives += 1;
                    break;
                case 8:
                    Console.WriteLine("You were abducted by The alpha Vampire and scared half out of you wits, but he just wanted to talk.");
                    Console.WriteLine("You lost 2 units of magic and gain 1 life");
                    magic -= 2;
                    lives += 1;
                    break;
                case 9:
                    Console.WriteLine("You made friends with Castiel the angel after helping to recover the staff of Moses from Raphael, and he heals your wounds.");
                    Console.WriteLine("You gained 2 units of health and magic");
                    health += 2;
                    magic += 2;                  
                    break;
                default:
                    Console.WriteLine("You saved a unicorn from a mean wizard.");
                    Console.WriteLine("You gain 2 lives and 5 units of magic");
                    magic += 2;
                    lives += 5;
                    break;
            }

        }

        private static int chooseDirection()
        {
            Console.WriteLine("You have come to a crossroad, enter 1 to travel left and a 2 to travel right");
            int direction = int.Parse(Console.ReadLine());
            while (direction != 1 && direction != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for left or a 2 for right");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }
    }
}