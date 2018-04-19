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





        public static void LookAround(Location location)
        {
            Console.Write($"You are currently standing in {DataStorage.playerLocation.GetName()}. ");

            Console.WriteLine(DataStorage.placeDescriptions[DataStorage.playerLocation.GetName()]);

            foreach (Creature item in DataStorage.playerLocation.creaturesAtLocation)
            {
                Console.WriteLine($"{item.GetName()} is here. ");
            }
        }


        public static void LookAt(string argument)          //Make sure you can't look at things that aren't present!
        {

        }

        public static void TryGo(string argument)
        {
            string exits = DataStorage.placesHasExits[DataStorage.playerLocation.GetName()];

            bool isLegitExit = false;

            for (int i = 0; i < exits.Length; i++)
            {
                if (argument[1] == exits[i])
                { isLegitExit = true; }
            }
                   
            if (isLegitExit)
            {
                Console.WriteLine(argument);
                Go(argument);
            }
            else
            {
                Console.WriteLine("You can't go that way.");
            }
        }

        public static void Go(string argument)
        {
            int[] currentCoord = DataStorage.playerCoords; //Get current coordinate

            int[] newCoord = currentCoord;

            if (argument == " north")            //Calculate new coordinate
            { newCoord[0] -= 1; }
            else if (argument == " south")
            { newCoord[0] += 1; }
            else if (argument == " west")
            { newCoord[1] -= 1; }
            else if (argument == " east")
            { newCoord[1] += 1; }
            else
            { Console.WriteLine("You can't go that way."); }

            Location newLocation = DataStorage.worldMap[newCoord[0], newCoord[1]];            //Determine new location

            DataStorage.playerLocation = newLocation;

            //Change location

            Console.WriteLine($"You go{argument} to {DataStorage.playerLocation.GetName()}");

            Commands.LookAround(DataStorage.playerLocation);

        }



    }
}
