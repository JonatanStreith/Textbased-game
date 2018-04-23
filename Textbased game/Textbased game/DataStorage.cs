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


        public static string[] legitimateCommands = { "look at", "look around", "go to", "pick up", "talk to", "quit", "look", "place", "brandish", "ask", "cast" };
        public static string[] legitimateConjunctions = { "about", "behind", "at", "under", "in front of", "on", "in" };




        public static Dictionary<string, string> placeDescriptions = new Dictionary<string, string> {
            { "Sugarcube Corner", "Sugarcube Corner is Ponyville's premier confectionery store." }
          , { "Carousel Boutique", "The Carousel Boutique is a place." }
          , { "Sweet Apple Acres", "This describes SAA." }
          , { "Castle of Friendship", "This describes the castle." }
        };


        public static Dictionary<string, string> creatureDescriptions = new Dictionary<string, string> {
            { "Twilight Sparkle", "You're mostly over your issues with Twilight Sparkle, the princess of friendship and books and obnoxious... mostly." }
          , { "Rarity", "Ponyville's resident fashion pony. Really melodramatic and self-obsessed, in your opinion." }
          , { "Applejack", "A down-to-earth apple farmer and general rustic country bumpkin. Boring, but fairly nice." }
          , { "Pinkie Pie", "Ponyville's premier party pony. A total weirdo. Frankly, she unnerves you." }
          , { "Rainbow Dash", "One of the most arrogant and loudmouthed ponies you've ever known. Nice to have on your side, though." }
          , { "Fluttershy", "A meek and shy pegasus who spends most of her time keeping animals. Also has some thin with Discord? She puzzles you." }
          , { "Spike", "Twilight Sparkle's runty dragon assistant. He's kind of annoying." }
          , { "The Great and Powerful Trixie", "You are the Great and Powerful Trixie! Mere words are not enough to describe your glory." }


        };


        public static Dictionary<string, string> objectDescriptions = new Dictionary<string, string> {
            { "Sugarcube Corner", "Sugarcube Corner is Ponyville's premier confectionery store." }
          , { "Carousel Boutique", "The Carousel Boutique is a place." }
          , { "Sweet Apple Acres", "This describes SAA." }
          , { "Castle of Friendship", "This describes the castle." }
        };


        public static Dictionary<string, string> itemDescriptions = new Dictionary<string, string> {
            { "Sugarcube Corner", "Sugarcube Corner is Ponyville's premier confectionery store." }
          , { "Carousel Boutique", "The Carousel Boutique is a place." }
          , { "Sweet Apple Acres", "This describes SAA." }
          , { "Castle of Friendship", "This describes the castle." }
        };











        public static Dictionary<string, string[]> legitimateExits = new Dictionary<string, string[]> {

             { "Sugarcube Corner", new String[] { "Castle of Friendship", "Carousel Boutique", "Sweet Apple Acres" } }
           , { "Castle of Friendship", new String[] { "Sugarcube Corner", "Carousel Boutique", "Sweet Apple Acres" } }
           , { "Carousel Boutique", new String[] { "Castle of Friendship", "Sugarcube Corner", "Sweet Apple Acres" } }
           , { "Sweet Apple Acres", new String[] { "Castle of Friendship", "Carousel Boutique", "Sugarcube Corner" } }

        };




        public static string[,] variantNames = {

              { "Twilight Sparkle", "Twilight", "Princess Twilight Sparkle", "bookhorse" } 
           ,  { "Rarity", "Rarara", "fashionhorse", "Rarity" }

           ,  { "Pinkie Pie", "Pinkie", "Pinkamena", "partyhorse" }
           ,  { "Applejack", "Jackie", "applehorse", "Applejack" }
           ,  { "Rainbow Dash", "Rainbow", "Dash", "Dashie" }
           ,  { "Fluttershy", "Flutters", "shyhorse", "Fluttershy" }

           ,  { "Spike", "Spike the Dragon", "dragon assistant", "Spike" }
           ,  { "Trixie Lulamoon", "The Great and Powerful Trixie", "Trix", "yourself" }
           ,  { "Starlight Glimmer", "Starlight", "Glim-Glam", "Starlight Glimmer" }

           ,  { "Sugarcube Corner", "bakery", "Sugarcubecorner", "Sugar Cube Corner" }
           ,  { "Golden Oaks Library", "Ponyville Library", "Library", "Tree library" } 
           ,  { "Carousel Boutique", "fashion store", "Boutique", "Carousel" } 
           ,  { "Sweet Apple Acres", "Acres", "apple farm", "Applejack's farm" } 

        };







    }


}
