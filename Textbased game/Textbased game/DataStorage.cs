using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class DataStorage
    {



        //public static Location[,] worldMap = new Location[2, 2];


        //public static int[] playerCoords = new int[2];


        //TO DO: Move these to world, maybe? And sort them!

        public static string[] legitimateCommands = { "nouns", "look at", "look around", "look", "go to", "go", "pick up", "talk to", "quit", "place", "brandish", "ask", "cast", "exits", "teleport to", "teleport", "help", "commands" };
        public static string[] legitimateConjunctions = { "to", "about", "behind", "at", "under", "in front of", "on", "in" };






        public static Dictionary<string, string> objectDescriptions = new Dictionary<string, string> {
            { "Cutie Map", "The Cutie Map serves as a magic display for 'friendship emergencies', or something. Starlight won't let you go near it after... the incident." }
          , { "apple tree", "The tree has no apples right now... somepony must've harvested them already." }
          , { "sewing machine", "A sewing machine for advanced stitchwork. You could use it to fix damaged clothes... or better yet, let Rarity do it for you. It's her job, not yours." }
          , { "baking oven", "A typical oven for baking. You could probably use it... if you wanted to." }
        };


        public static Dictionary<string, string> itemDescriptions = new Dictionary<string, string> {
            { "rock", "It's a rock. You saw enough of them during your time on the rock farm." }
          , { "wooden crate", "A wooden crate for putting things in." }
          , { "bundle of fireworks", "A bunch of magical fireworks, crafted by yours truly. Handle with care!" }
          , { "Trixie's hat", "Your hat. Anypony who sees it will know that they're dealing with a magnificent magician. Good for keeping the sun out of your eyes, too." }
          , { "Trixie's cape", "Your cape. Anypony who sees it will know that they're dealing with a magnificent magician. Keeps you warm during travels, too." }
        };






















    }


}
