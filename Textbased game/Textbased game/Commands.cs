﻿using System;
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



            foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).creaturesAtLocation)
            {
                Console.WriteLine($"{item.GetName()} is here. ");
            }
        }


        public static void LookAt(string argument, World world)          //Make sure you can't look at things that aren't present!
        {

        }






        public static void TryGo(string argument, World world)
        {
            string exits = DataStorage.placesHasExits[world.GetPlayer().GetLocationName()];

            bool isLegitExit = false;

            for (int i = 0; i < exits.Length; i++)
            {
                if (argument[1] == exits[i])
                { isLegitExit = true; }
            }
                   
            if (isLegitExit)
            {
                Go(argument, world);
            }
            else
            {
                Console.WriteLine("You can't go that way.");
            }
        }

        public static void Go(string argument, World world)
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

            world.GetPlayer().SetLocation(newLocation.GetName());

            //Change location

            Console.WriteLine($"You go{argument} to {world.GetPlayer().GetLocationName()}");

            Commands.LookAround(world);

        }



        public static void TalkTo(string argument, World world)
        {
            string talkingTo = "nobody";

            foreach (Creature item in world.GetLocation(world.GetPlayer().GetLocationName()).creaturesAtLocation)
            {
                if ((argument == item.GetName()) || (argument == item.GetShortName()))
                { talkingTo = item.GetName(); }

            }

            //check if the argument refers to a present individual

                //if found, find dialog and write it


        }



    }
}
