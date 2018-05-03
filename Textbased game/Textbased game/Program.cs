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
            string[] commandPhrase;         //A "Command Phrase" contains four elements: a command, a subject, a preposition, and a last argument. Example: "Throw", "rock", "at", "window".






            Console.WriteLine("Game begins!");
            //create character

            Console.WriteLine($"You are {Equestria.GetPlayer().GetName()}, a {Equestria.GetPlayer().GetRace()}.");


            Commands.LookAround(Equestria);





            while (true)                //Continously running play loop that parses instructions

            {





                Console.WriteLine();
                Console.Write("Please input command: ");
                input = Console.ReadLine().ToLower();
                commandPhrase = Parser(input, Equestria);


                //Console.WriteLine(commandPhrase[0]);
                //Console.WriteLine(commandPhrase[1]);
                //Console.WriteLine(commandPhrase[2]);
                //Console.WriteLine(commandPhrase[3]);


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

                case "go to":
                    Commands.GoTo(command[1], world);
                    break;
                case "go":
                    Commands.GoTo(command[1], world);
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

                case "exits":
                    Commands.GetExits(world);
                    break;

                case "teleport":
                    Commands.TeleportOther(command, world);
                    break;

                case "teleport to":
                    Commands.TeleportSelf(command, world);
                    break;

                case "ask":
                    Commands.Ask(command, world);
                    break;


                case "":

                    break;




                default:
                    Console.WriteLine("What do you mean?");
                    break;
            }


        }






        public static string[] Parser(string command, World world)      //This runs a check on the input to ensure that it's a "proper" command
        {
            string[] cleanCommand = { "", "", "", "" };

            string[] remainder;


            foreach (string item in DataStorage.legitimateCommands)
            {
                if (command.StartsWith(item.ToLower()))
                {
                    //Now separate the command

                    remainder = command.Split(new string[] { item.ToLower() }, StringSplitOptions.None);

                    cleanCommand[0] = item;

                    if (remainder[1] != "")
                    { command = remainder[1].Remove(0, 1); }



                    break;
                }
            }

            foreach (string item in world.legitimateNouns)
            {
                if (command.StartsWith(item.ToLower()))
                {
                    //Now separate the noun

                    remainder = command.Split(new string[] { item.ToLower() }, StringSplitOptions.None);

                    cleanCommand[1] = world.ReturnFullName(item);

                    if (remainder[1] != "")
                    { command = remainder[1].Remove(0, 1); }





                    break;
                }
            }

            foreach (string item in DataStorage.legitimateConjunctions)
            {
                if (command.StartsWith(item.ToLower()))
                {
                    //Now separate the conjunction

                    remainder = command.Split(new string[] { item.ToLower() }, StringSplitOptions.None);

                    cleanCommand[2] = item;

                    if (remainder[1] != "")
                    { command = remainder[1].Remove(0, 1); }


                    break;
                }
            }


            cleanCommand[3] = command;      //Add the remainder


            return cleanCommand;
        }









        public static string ReturnShortForm(string noun)
        {
            string returnNoun = noun;


            for (int i = 0; i < DataStorage.variantNames.GetLength(0); i++)
            {
                for (int j = 0; j < DataStorage.variantNames.GetLength(1); j++)
                {
                    if (noun == DataStorage.variantNames[i, j])
                    { returnNoun = DataStorage.variantNames[0, j]; }
                }
            }



            return returnNoun;

        }








    }
}
