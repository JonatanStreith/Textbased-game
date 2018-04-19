using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Program
    {
        static void Main(string[] args)
        {




            string input;
            string[] commandPhrase = new string[2];         //A "Command Phrase" contains two elements: a command, and a subject. Example: "Pick up", "Apple".


            Console.WriteLine("Game begins!");
            //create character

            Creature player = new Creature("Player", "human");

            //create locations, creatures, objects and items

            while (true)                //Continously running play loop that parses instructions

            {

                Console.Write("Please input command: ");
                input = Console.ReadLine().ToLower();
                commandPhrase = ProperCommand(input);

                RunCommand(commandPhrase);


            }





        }


        public static void RunCommand(string[] command)
        {
            Console.WriteLine("Your command line is: ");

            Console.WriteLine($"{command[0]}{command[1]}");




        }






        public static string[] ProperCommand(string command)      //This runs a check on the input to ensure that it's a "proper" command
        {
            string[] cleanCommand = new string[2];

            string[] separated;


            for (int i = 0; i < DataStorage.legitimateCommands.Length; i++)
            {
                if (command.StartsWith(DataStorage.legitimateCommands[i]))
                {

                    separated = command.Split(new string[] { DataStorage.legitimateCommands[i] }, StringSplitOptions.None);



                    cleanCommand[0] = DataStorage.legitimateCommands[i];
                    cleanCommand[1] = separated[1];
                    //Now split the line

                    break;
                }
            }


            return cleanCommand;
        }


        public static void CreateWorld()
        {

            Location Sugarcube = new Location("Sugarcube Corner", 0, 0);
            Location Library = new Location("Golden Oaks Library", 0, 1);
            Location Boutique = new Location("Carousel Boutique", 1, 0);
            Location Acres = new Location("Sweet Apple Acres", 1, 1);

            DataStorage.locationList.Add(Sugarcube);
            DataStorage.locationList.Add(Library);
            DataStorage.locationList.Add(Boutique);
            DataStorage.locationList.Add(Acres);

            Creature PinkiePie = new Creature("Pinkie Pie", "earth pony");
            Creature Applejack = new Creature("Applejack", "earth pony");
            Creature RainbowDash = new Creature("Rainbow Dash", "pegasus");
            Creature Fluttershy = new Creature("Fluttershy", "pegasus");
            Creature Rarity = new Creature("Rarity", "unicorn");
            Creature TwilightSparkle = new Creature("Twilight Sparkle", "unicorn");
            Creature Spike = new Creature("Spike", "dragon");


            DataStorage.creatureList.Add(PinkiePie);
            DataStorage.creatureList.Add(Applejack);
            DataStorage.creatureList.Add(RainbowDash);
            DataStorage.creatureList.Add(Fluttershy);
            DataStorage.creatureList.Add(Rarity);
            DataStorage.creatureList.Add(TwilightSparkle);
            DataStorage.creatureList.Add(Spike);


            Sugarcube.AddCreature(PinkiePie);

            Location loc = DataStorage.locationList.Find(x => x.GetName().Contains("Sugarcube Corner"));

        }

    }
}
