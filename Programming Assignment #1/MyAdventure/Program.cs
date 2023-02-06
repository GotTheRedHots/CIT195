using System;

namespace fishingTale
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int bait = 0, patience = 0, limit = 0, sideOfBoat = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is the name of your character? ");
            string name = Console.ReadLine();
            initValues(ref bait, ref patience, ref limit, r);
            while (bait > 0 && patience > 0 && limit > 0 && win == false)
            {
                sideOfBoat = chooseDirection();
                /* the side of the boat (sideOfBoat) impacts the number passed to the actions method
                 * if they choose port, they will only receive bad outcomes
                 * if they choose starboard, they have a better chance of receiving 
                 * good outcomes along with the bad outcomes */
                if (sideOfBoat == 1)
                    actions(r.Next(4), ref bait, ref patience, ref limit, ref win);
                else
                    actions(r.Next(11), ref bait, ref patience, ref limit, ref win);
                checkResults(ref round, ref bait, ref patience, ref limit);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully catching a fish  T H I S   B I G");
            else if (bait <= 0)
                Console.WriteLine("You ran out of bait and could not catch more fish");
            else if (patience <= 0)
                Console.WriteLine("You ran out of patience trying to land the big one");
            else
                Console.WriteLine("You ran out of space for fish but you feel like the big one is still out there");

        }

        private static void initValues(ref int bait, ref int patience, ref int limit, Random r)
        {
            bait = r.Next(1, 11);
            patience = r.Next(1, 11);
            limit = r.Next(1, 11);
        }

        private static void checkResults(ref int round, ref int bait, ref int patience, ref int limit)
        {
            round++;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Round {round} stats: bait {bait}, patience {patience}, limit {limit}.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            return;
        }

        private static void actions(int diceRoll, ref int bait, ref int patience, ref int limit, ref bool win)
        {

            switch (diceRoll)
            {
                case 0:
                    Console.WriteLine("A seagull swoops down and eats some of your bait! How infurating");
                    Console.WriteLine("You lose 2 bait and 1 patience");
                    bait -= 2;
                    patience -= 1;
                    break;
                case 1:
                    Console.WriteLine("An enormous fish pulls at the line so hard it snaps!!!");
                    Console.WriteLine("You lost 1 bait");
                    bait -= 1;
                    break;
                case 2:
                    Console.WriteLine("A large wave rocks the boat and a fish spills out of the well and back into the water! Curses!!!");
                    Console.WriteLine("You lose 3 patience and gain 1 limit");
                    limit += 1;
                    patience -= 2;
                    break;
                case 3:
                    Console.WriteLine("A whole hour passes without so much as a nibble.");
                    Console.WriteLine("You lost 2 patience");
                    patience -= 2;
                    break;
                case 4:
                    Console.WriteLine("While resetting the line you kick over your bucket of bait and several pieces fall into the water");
                    Console.WriteLine("You lost 3 bait");
                    bait -= 3;
                    break;
                case 5:
                    Console.WriteLine("Feeling a hard tug at the line you begin to reel quickily! Out of the water shoots a crawfish, its claw tightly gripping the bait.");
                    Console.WriteLine("A crawfish is no good for keeping but will make great bait. Gain 4 bait");
                    bait += 4;
                    break;
                case 6:
                    Console.WriteLine("You feel a nibble! Defly setting the hook you reel in a gorgeous redfin snapper!");
                    Console.WriteLine("You gain 3 patience and lose 1 limit and 1 bait");
                    limit -= 1;
                    patience += 3;
                    break;
                case 7:
                    Console.WriteLine("The tip of your fishing rod bends low over the water! After a fierce battle you haul up a glittering sturgeon, what a catch!");
                    Console.WriteLine("You gain 5 patience and lose 1 limit and 1 bait");
                    limit += 2;
                    patience += 2;
                    bait += 5;
                    break;
                case 8:
                    Console.WriteLine("You only caught a few little bait fish today. A little frusterating, but there's always tomorrow.");
                    Console.WriteLine("You lost 2 patience but gained 3 bait fish.");
                    patience -= 2;
                    bait += 3;
                    break;
                case 9:
                    Console.WriteLine("You made friends with your neighbor and he said he will share his favorite secret spot with you.");
                    Console.WriteLine("You upped your limit and gain 2 patience.");
                    limit += 2;
                    patience += 2;
                    break;
                default:
                    Console.WriteLine("Out of the corner of your eye a great shadow appears, and the rod is nearly snatched from your hand by some leviathan! After hours of pitched battle you finally reel the monstrosity to the surface. An enormous marlin!");
                    Console.WriteLine("You've won!!!!");
                    patience += 2;
                    bait += 5;
                    win = true;
                    break;
            }

        }

        private static int chooseDirection()
        {
            Console.WriteLine("Enter 1 to cast off the port side and a 2 to cast off the starboard side");
            int side = int.Parse(Console.ReadLine());
            while (side != 1 && side != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for port or a 2 for starboard");
                side = int.Parse(Console.ReadLine());
            }
            return side;
        }
    }
}