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
            Console.Write($"You are currently standing in {world.GetLocation(world.GetPlayer().GetLocationName()).GetFullName()}. ");

            Console.WriteLine(world.GetLocation(world.GetPlayer().GetLocationName()).GetDescription());

            List<Creature> npcsList = world.GetLocation(world.GetPlayer().GetLocationName()).creaturesAtLocation;



            if (npcsList.Count() == 1) { Console.WriteLine("There's nopony else here."); }

            else if (npcsList.Count() == 2) { Console.WriteLine($"{npcsList[0].GetFullName()} is here."); }

            else if (npcsList.Count() >= 3)
            {
                for (int i = 0; i < npcsList.Count - 3; i++)
                {
                    Console.Write($"{npcsList[i].GetFullName()}, ");
                }

                Console.Write($"{npcsList[npcsList.Count - 3].GetFullName()} and ");
                Console.WriteLine($"{npcsList[npcsList.Count - 2].GetFullName()} are here.");

            }

            else { Console.WriteLine("Something weird is going on."); }





        }


        public static void LookAt(string argument, World world)          //Make sure you can't look at things that aren't present!
        {

        }


        public static void GoTo(string newArea, World world)
        {
            bool canGo = false;
            foreach (string place in world.GetLocation(world.GetPlayer().GetLocationName()).GetExits())     //Check if any of the legitimate exits is the place we want to go to
            {
                if (newArea == place.ToLower())
                { canGo = true; }
            }

            if (canGo)               //Is newArea on the list of legitimate exits?
            {
                world.RemoveCreatureFromLocation(world.GetPlayer().GetLocationName(), "Trixie");            //Remove player from current location
                world.AddCreatureToLocation(newArea, "Trixie");                                             //Add player to new location
                world.GetPlayer().SetLocation(newArea);                                                     //Change player's location variable
                Console.WriteLine($"You go to {world.GetLocation(newArea).GetFullName()}.");
                Console.ReadLine();
                Console.Clear();
                LookAround(world);
            }
            else { Console.WriteLine("You can't get there from here."); }
        }







        public static void TalkTo(string creatureName, World world)
        {
            string talkingTo = "Nonexistent";



            foreach (Creature item in world.creatureList)
            {
                if (creatureName == item.GetName())
                { talkingTo = "Away"; }
            }

            foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).creaturesAtLocation)
            {
                if (creatureName == item.GetName())
                { talkingTo = item.GetFullName(); }
            }

            if (talkingTo == "Nonexistent")
            { Console.WriteLine("You don't know of anypony by that name."); }
            else if (talkingTo == "Away")
            { Console.WriteLine($"{world.GetCreature(creatureName).GetFullName()} isn't here right now."); }
            else
            {
                string[] dialog = DialogData.casualDialog[talkingTo];
                Console.WriteLine(dialog[world.diceRoll.Next(dialog.Length)]);
            }




        }



    }
}
