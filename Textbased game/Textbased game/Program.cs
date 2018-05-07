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

            string defaultWorld = @"C:\Users\Lexicon\source\repos\Textbased-game\Textbased game\Textbased game\DefaultWorld\";  //Figure out how to do this as a relative path later!


            World Equestria = new World(defaultWorld);




            string input;
            string[] commandPhrase;         //A "Command Phrase" contains four elements: a command, a subject, a preposition, and a last argument. Example: "Throw", "rock", "at", "window".






            Console.WriteLine("Game begins!");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            RollIntro();





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
                case "brandish":
                    //stuff
                    break;

                case "cast":
                    //stuff
                    break;

                case "save":
                    //stuff
                    break;

                case "load":
                    //stuff
                    break;

                case "pick up":
                    Commands.PickUp(command[1], world);
                    break;

                case "drop":
                    Commands.Drop(command[1], world);
                    break;
                    
                case "inventory":
                    Commands.ShowInventory(world);
                    break;

                case "nouns":
                    Commands.ListNouns(world);
                    break;

                case "help":
                    Commands.Help();
                    break;

                case "commands":
                    Commands.ListCommands(world);
                    break;


                case "quit":
                    Commands.Quit();
                    break;

                case "go to":
                    Commands.GoTo(command[1], world);
                    break;
                case "go":
                    Commands.GoTo(command[1], world);
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

                default:
                    Console.WriteLine("What do you mean?");
                    break;
            }


        }






        public static string[] Parser(string command, World world)      //This runs a check on the input to ensure that it's a "proper" command
        {
            string[] cleanCommand = { "", "", "", "" };

            string[] remainder;


            foreach (string item in world.legitimateCommands)
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

            foreach (string item in world.legitimateConjunctions)
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









        public static void RollIntro()
        {
            Console.WriteLine("Once upon a time, in the magical land of Equestria...");
            Console.WriteLine();
            Console.WriteLine("A great and powerful magician went to Ponyville to awe and impress. That didn't end very well. Later, she returned for vengeance. That didn't quite work out either.");
            Console.WriteLine();
            Console.WriteLine("Then she returned again and made a great friend, and later helped save Equestria from the changeling menace, proving how all those neighsayers were foolish and wrong for doubting Trixie.");
            Console.WriteLine();
            Console.WriteLine("Now, Trixie has returned to Ponyville once again. What adventures await her this time?");

            Console.ReadKey();
            Console.Clear();

        }



    }
}
