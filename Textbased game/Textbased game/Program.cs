using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Program
    {
        //public static List<Location> locationList = new List<Location>();
        //public static List<Creature> creatureList = new List<Creature>();
        //public static List<Object> objectList = new List<Object>();
        //public static List<Item> itemList = new List<Item>();


        static void Main(string[] args)
        {

            //create locations, creatures, objects and items




            World Equestria = new World();




            string input;
            string[] commandPhrase = new string[2];         //A "Command Phrase" contains two elements: a command, and a subject. Example: "Pick up", "Apple".





            Console.WriteLine("Game begins!");
            //create character





            Console.WriteLine($"You are {Equestria.GetPlayer().GetName()}, a {Equestria.GetPlayer().GetRace()}");

            //DataStorage.playerLocation = Equestria.locationList.Find(x => x.GetName().Contains("Sugarcube Corner"));

            //DataStorage.playerCoords[0] = DataStorage.playerLocation.GetX();
            //DataStorage.playerCoords[1] = DataStorage.playerLocation.GetY();



            Console.Write($"You are currently standing in {Equestria.GetPlayer().GetLocationName()}. ");


            //Console.WriteLine(Equestria.GetPlayer().GetLocation().GetDescription());









            foreach (string item in Equestria.properNoun)
            {
                Console.WriteLine(item);
            }








            while (true)                //Continously running play loop that parses instructions

            {
                Console.WriteLine();
                Console.Write("Please input command: ");
                input = Console.ReadLine().ToLower();
                commandPhrase = ProperCommand(input);




                RunCommand(commandPhrase, Equestria);


            }





        }


        public static void RunCommand(string[] command, World world)
        {


            switch (command[0])     //This can be used to parse similar expressions, i.e. "examine" points to "look at".
            {
                case "quit":
                    Commands.Quit();
                    break;

                case "go":
                    Commands.TryGo(command[1], world);
                    break;

                case "pick up":
                    //stuff
                    break;

                case "talk to":
                    Commands.TalkTo(command[1], world);
                    break;

                case "look":
                    Commands.LookAround(world);
                    break;

                case "look around":
                    Commands.LookAround(world);
                    break;

                case "look at":
                    Commands.LookAt(command[1], world);
                    break;

                case "":

                    break;


                default:
                    Console.WriteLine("What do you mean?");
                    break;
            }


        }






        public static string[] ProperCommand(string command)      //This runs a check on the input to ensure that it's a "proper" command
        {
            string[] cleanCommand = { "Illegal command", "" };

            string[] separated;


            for (int i = 0; i < DataStorage.legitimateCommands.Length; i++)
            {
                if (command.StartsWith(DataStorage.legitimateCommands[i]))
                {
                    //Now split the line

                    separated = command.Split(new string[] { DataStorage.legitimateCommands[i] }, StringSplitOptions.None);



                    cleanCommand[0] = DataStorage.legitimateCommands[i];
                    cleanCommand[1] = separated[1].Replace(" ", "");        //makes sure to remove that space

                    break;
                }
            }


            return cleanCommand;
        }




















    }
}
