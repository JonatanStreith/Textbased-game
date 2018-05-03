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


        public static string[] legitimateCommands = { "look at", "look around", "look", "go to", "go", "pick up", "talk to", "quit", "place", "brandish", "ask", "cast", "exits", "teleport to", "teleport" };
        public static string[] legitimateConjunctions = { "to", "about", "behind", "at", "under", "in front of", "on", "in" };






        public static Dictionary<string, string> creatureDescriptions = new Dictionary<string, string> {
            { "Twilight Sparkle", "You're mostly over your issues with Twilight Sparkle, the princess of friendship and books and obnoxious... mostly." }
          , { "Rarity", "Ponyville's resident fashion pony. Really melodramatic and self-obsessed, in your opinion." }
          , { "Applejack", "A down-to-earth apple farmer and general rustic country bumpkin. Boring, but fairly nice." }
          , { "Pinkie Pie", "Ponyville's premier party pony. A total weirdo. Frankly, she unnerves you." }
          , { "Rainbow Dash", "One of the most arrogant and loudmouthed ponies you've ever known. Nice to have on your side, though." }
          , { "Fluttershy", "A meek and shy pegasus who spends most of her time keeping animals. Also has some thing with Discord? She puzzles you." }
          , { "Spike", "Twilight Sparkle's runty dragon assistant. He's kind of annoying." }
          , { "Trixie", "You are the Great and Powerful Trixie! You are Equestria's greatest stage magician, a unicorn of peerless beauty and magical ability, a brave and fearless hero, and also very humble.." }
          , { "Starlight Glimmer", "Starlight Glimmer is your best friend. She's talented, understanding, fun... and she knows what it's like to have a troubled past. She's the best."}
          , { "Maud Pie", "Maud Pie is... strange.  In some ways she's even weirder than Pinkie Pie. Are they really sisters? At least she doesn't judge you."}
          , { "Celestia", "The Princess of the Sun, diarch of Equestria. It's one of your dreams to one day get to perform at her court."}
          , { "Luna", "The Princess of the Moon, diarch of Equestria. You've always felt a certain kinship with her, and her plight. She keeps the night safe."}
          , { "Discord", "The grand Chaos Noodle himself. Weird, obnoxious, egocentric, annoying... okay, sometimes he's kind of fun, but don't let him hear that."}
          , { "Placeholder4", ""}

        };



        public static Dictionary<string, string> objectDescriptions = new Dictionary<string, string> {
            { "cutie map", "The Cutie Map serves as a magic display for 'friendship emergencies', or something. Starlight won't let you go near it after... the incident." }
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
