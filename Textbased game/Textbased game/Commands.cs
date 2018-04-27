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
            Console.WriteLine();

            List<Creature> npcsList = world.GetLocation(world.GetPlayer().GetLocationName()).GetCreaturesAtLocation();      //Create a list of npcs at the location. Make sure to exclude Trixie.

            int numCreatures = npcsList.Count;

            if (npcsList.Count() == 1) { Console.WriteLine("There's nopony else here."); }

            else
            {
                Console.WriteLine($"{world.TurnCreatureListIntoString(npcsList)} {HelpfulMethods.IsOrAre(numCreatures - 1)} here.");
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
                //world.GetPlayer().SetLocation(newArea);                                                     //Change player's location variable; already included in prev command
                Console.WriteLine($"You go to {world.GetLocation(newArea).GetName()}.");
                Console.ReadLine();
                Console.Clear();
                LookAround(world);
            }
            else { Console.WriteLine("You can't get there from here."); }
        }







        public static void TalkTo(string name, World world)
        {
            if (!(world.DoesObjectExist(name)))                                                             //Subject doesn't exist.
            { Console.WriteLine($"You don't know of anypony by that name."); }

            else if (world.IsObjectPresent(name) == false)                                                   //Subject isn't present.
            { Console.WriteLine($"{world.GetGenericObject(name).GetName()} isn't here right now."); }

            else if (!(world.GetGenericObject(name) is Creature))                                                //Subject isn't a creature.
            { Console.WriteLine($"You don't make a habit of talking to inanimate objects."); }

            else if ((world.GetGenericObject(name) is Creature))
            {
                string[] dialog = DialogData.casualDialog[name];                   //This runs if you successfully talk to someone.
                Console.WriteLine(dialog[world.diceRoll.Next(dialog.Length)]);

            }
            else
            { Console.WriteLine("Debug code. If this is shown, something didn't go right."); }

            //string talkingTo = "Nonexistent";

            //foreach (Creature item in world.creatureList)
            //{
            //    if (item.GetName().Equals(creatureName, StringComparison.InvariantCultureIgnoreCase))
            //    { talkingTo = "Away"; }
            //}

            //foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).GetCreaturesAtLocation())
            //{

            //    if (item.GetName().Equals(creatureName, StringComparison.InvariantCultureIgnoreCase))
            //    { talkingTo = item.GetName(); }
            //}

            //if (talkingTo == "Nonexistent")
            //{ Console.WriteLine("You don't know of anypony by that name."); }
            //else if (talkingTo == "Away")
            //{ Console.WriteLine($"{world.GetCreature(creatureName).GetName()} isn't here right now."); }
            //else
            //{
            //    string[] dialog = DialogData.casualDialog[talkingTo];                   //This runs if you successfully talk to someone.
            //    Console.WriteLine(dialog[world.diceRoll.Next(dialog.Length)]);
            //}




        }



        public static void GetExits(World world)
        {
            Location loc = world.GetLocation(world.GetPlayer().GetLocationName());
            List<string> exits = loc.GetExits();


            Console.Write($"Exits are: {world.TurnStringListIntoString(exits)}.");
        }


        public static void TeleportOther(string[] command, World world)  //Make sure you can teleport items and objects - different code?
        {

            if (!world.DoesObjectExist(command[1]))             //Subject doesn't exist
            {                Console.WriteLine("You can't teleport something that doesn't exist.");            }

            else if (!world.IsObjectPresent(command[1]))        //Subject isn't in the area
            { Console.WriteLine("You can only teleport things within eyesight."); }
            
            else if (world.GetGenericObject(command[1]).GetName().Equals("Trixie", StringComparison.InvariantCultureIgnoreCase))           //Are you instructing the game to teleport Trixie herself?
            {
                world.RemoveCreatureFromLocation(world.GetPlayer().GetLocationName(), world.GetPlayer().GetName());
                world.AddCreatureToLocation(command[3], world.GetPlayer().GetName());

                Console.WriteLine($"You vanish in a burst of smoke, and reappear at {world.GetLocation(command[3]).GetName()}");
                Console.ReadLine();
                Console.Clear();
                LookAround(world);
            }
            else
            {
                world.RemoveCreatureFromLocation(world.GetPlayer().GetLocationName(), world.GetCreature(command[1]).GetName());
                world.AddCreatureToLocation(command[3], command[1]);

                Console.WriteLine($"{command[1]} vanishes in a burst of smoke!");
            }
        }


        public static void TeleportSelf(string[] command, World world)  //Make sure you can teleport items and objects - different code?
        {
            world.RemoveCreatureFromLocation(world.GetPlayer().GetLocationName(), world.GetPlayer().GetName());
            world.AddCreatureToLocation(command[1], world.GetPlayer().GetName());




            Console.WriteLine($"You vanish in a burst of smoke, and reappear at {world.GetLocation(command[1]).GetName()}");
            Console.ReadLine();
            Console.Clear();
            LookAround(world);


        }




        public static void Ask(string[] command, World world)
        {


        }


    }
}
