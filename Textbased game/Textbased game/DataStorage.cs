using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class DataStorage
    {



        public static Location[,] worldMap = new Location[2, 2];


        public static int[] playerCoords = new int[2];


        public static string[] legitimateCommands = { "look at", "look around", "go", "pick up", "talk to", "quit", "look", "place", "brandish", "ask" };
        public static string[] legitimateConjunctions = { "about", "behind", "at", "under", "in front of", "on", "in" };




        public static Dictionary<string, string> placeDescriptions = new Dictionary<string, string> { { "Sugarcube Corner", "Sugarcube Corner is Ponyville's premier confectionery store." }, { "Carousel Boutique", "The Carousel Boutique is a place." }, { "Sweet Apple Acres", "This describes SAA." }, { "Golden Oaks Library", "This describes the library" } };
        public static Dictionary<string, string> placesHasExits = new Dictionary<string, string> { { "Sugarcube Corner", "se" }, { "Carousel Boutique", "ne" }, { "Sweet Apple Acres", "nw" }, { "Golden Oaks Library", "sw" } };






    }


}
