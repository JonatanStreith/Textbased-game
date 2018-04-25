using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Commands
    {


        public static void Quit()
        {
            Console.WriteLine("Are you sure you want to quit? Y/N");
            if (Console.ReadKey(true).KeyChar.ToString() == "y")
            {
                Console.WriteLine("Okay, bye!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Okay, let's continue.");
        }





        public static void LookAround(World world)
        {
            Console.Write($"You are currently standing in {world.GetLocation(world.GetPlayer().GetLocationName()).GetName()}. ");
            Console.WriteLine(world.GetLocation(world.GetPlayer().GetLocationName()).GetDescription());



            List<Creature> npcsList = world.GetLocation(world.GetPlayer().GetLocationName()).GetCreaturesAtLocation();      //Create a list of npcs at the location. Make sure to exclude Trixie.

            npcsList.Remove(world.GetCreature("Trixie"));
            int numCreatures = npcsList.Count;

            if (npcsList.Count() == 0) { Console.WriteLine("There's nopony else here."); }

            else
            {





                string fullString = npcsList[0].GetName();
                npcsList.RemoveAt(0);

                if (npcsList.Count > 0)
                {
                    while (npcsList.Count > 1)
                    {
                        fullString = fullString + $", {npcsList[0].GetName()}";
                        npcsList.RemoveAt(0);
                    }
                    fullString = fullString + $" and {npcsList[0].GetName()}";
                }

                Console.WriteLine($"{fullString} {HelpfulMethods.IsOrAre(numCreatures)} here.");

            }
            
        }







        public static void LookAt(string argument, World world)          //Make sure you can't look at things that aren't present!
        {

            if (world.GetPlayer().GetLocationName().Equals(argument, StringComparison.InvariantCultureIgnoreCase))      //Looking at the place
            {
                Console.WriteLine(world.GetLocation(world.GetPlayer().GetLocationName()).GetDescription());
            }
            else
            {


                foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).GetCreaturesAtLocation())
                {

                    if (item.GetName().Equals(argument, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine(item.GetDescription());
                    }
                }

                foreach (Item item in world.GetLocation(world.GetPlayer().GetLocationName()).GetItemsAtLocation())
                {
                    if (item.GetName().Equals(argument, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine(item.GetDescription());
                    }
                }

                foreach (StationaryObject item in world.GetLocation(world.GetPlayer().GetLocationName()).GetObjectsAtLocation())
                {
                    if (item.GetName().Equals(argument, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine(item.GetDescription());
                    }
                }


            }

        }







        public static void GoTo(string newArea, World world)
        {
            bool canGo = false;
            foreach (string place in world.GetLocation(world.GetPlayer().GetLocationName()).GetExits())     //Check if any of the legitimate exits is the place we want to go to
            {

                if (newArea == place)
                { canGo = true; }
            }

            if (canGo)               //Is newArea on the list of legitimate exits?
            {
                world.RemoveCreatureFromLocation(world.GetPlayer().GetLocationName(), "Trixie");            //Remove player from current location
                world.AddCreatureToLocation(newArea, "Trixie");                                             //Add player to new location
                world.GetPlayer().SetLocation(newArea);                                                     //Change player's location variable
                Console.WriteLine($"You go to {world.GetLocation(newArea).GetName()}.");
                Console.ReadLine();
                Console.Clear();
                LookAround(world);
            }
            else { Console.WriteLine("You can't get there from here."); }
        }







        public static void TalkTo(string creatureName, World world)
        {

            Console.WriteLine(creatureName);

            string talkingTo = "Nonexistent";



            foreach (Creature item in world.creatureList)
            {
                if (item.GetName().Equals(creatureName, StringComparison.InvariantCultureIgnoreCase))
                { talkingTo = "Away"; }


            }


            foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).GetCreaturesAtLocation())
            {

                Console.WriteLine($"Found: {item.GetName()}");
                Console.WriteLine($"Wants to talk to: {creatureName}");

                if (item.GetName().Equals(creatureName, StringComparison.InvariantCultureIgnoreCase))
                { talkingTo = item.GetName(); }
            }


            if (talkingTo == "Nonexistent")
            { Console.WriteLine("You don't know of anypony by that name."); }
            else if (talkingTo == "Away")
            { Console.WriteLine($"{world.GetCreature(creatureName).GetName()} isn't here right now."); }
            else
            {
                string[] dialog = DialogData.casualDialog[talkingTo];                   //This runs if you successfully talk to someone.
                Console.WriteLine(dialog[world.diceRoll.Next(dialog.Length)]);




            }
        }



        public static void GetExits(World world)
        {
            Location loc = world.GetLocation(world.GetPlayer().GetLocationName());
            List<string> exits = loc.GetExits();


            Console.Write("Exits are: ");
            foreach (string exit in exits)
            {
                Console.Write($"{exit}, ");
            }
        }


        public static void Teleport(string[] command, World world)
        {
            world.AddCreatureToLocation(command[3], command[1]);            //This is unfinished!
        }



    }
}
