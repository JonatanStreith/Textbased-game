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

            Creature player = new Creature("Player", "human", 0, 0);

            //create locations, creatures, objects and items
            DataStorage.CreateAllLocations();

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


    }
}
