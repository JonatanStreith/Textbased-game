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
            if (Console.ReadKey(true).KeyChar.ToString() == "y" )
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

        public static void Go(string argument)          
        {

            string exits = DataStorage.placesHasExits[DataStorage.playerLocation.GetName()];

            foreach (string letter in collection)
            {

            }

            if (true)
            {

            }
            else {
                Console.WriteLine("You can't go that way.");
            }

        }


    }
}
