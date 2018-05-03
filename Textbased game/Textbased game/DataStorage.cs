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




        public static Dictionary<string, string> placeDescriptions = new Dictionary<string, string> {
            { "Sugarcube Corner", "Sugarcube Corner is Ponyville's premier confectionery store. You don't know why it's built like a giant gingerbread house." }
          , { "Sugarcube Corner interior", "The shop is busy with ponies enjoying baked goods." }
          , { "Sugarcube Corner kitchen", "This is where the magic happens! And by magic, you mean baking and not actually magic. Why are you even here?" }
          , { "Pinkie Pie's room", "This is Pinkie Pie's room. It's a complete mess." }
          , { "the Party Cave", "This underground sanctum is where Pinkie Pie stores most of her party supplies, and also where she maintains surveillance on everypony's birthdays and other anniversaries. EVERYPONY'S. The implications are terrifying." }


          , { "the Carousel Boutique", "The Carousel Boutique is a bright and airy shop full of outfits of all kinds, all hoof-made by its proprietor, Rarity. Of course, already being dressed to perfection, you have no need of her services." }
          , { "the Carousel Boutique interior", "The shop is full of ponyquins and displays showing Rarity's latest creations. It's surprisingly roomy." }


          , { "Sweet Apple Acres", "Sweet Apple Acres is a beautiful pastoral farmstead, run by the Apple family. Unsurprisingly, they grow apples." }
          , { "Farmhouse interior", "This rustic home is where Applejack and her family lives. It's cozy, quaint and so stereotypical you almost gag." }

          , { "the Castle of Friendship", "The Castle of Friendship is a majestic crystal structure that looks incredibly out of place with the rest of Ponyville. It's a nice place to hang out, though." }
          , { "Castle main hall", "This is the main hall, which leads to every other room in the castle. Try not to get lost again." }
          , { "Cutie Map room", "The room is dominated by the grand Cutie Map, and the six... seven thrones from which Twilight Sparkle and her friends do friendship stuff, or something." }
          , { "castle library","The library holds copies of every book in Equestria that Twilight Sparkle could get her hooves on. If you need to look something up, you suppose you could come here." }
          , { "castle kitchen","The castle kitchen is a great place to stock up on snacks. As long as Spike doesn't catch you." }
          , {"Starlight's room","Starlight's room. You hang out here sometimes." }


        };


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











        public static Dictionary<string, List<string>> legitimateExits = new Dictionary<string, List<string>> {


            //Main cells (outside)
             { "Sugarcube Corner", new List<string> { "the Castle of Friendship", "the Carousel Boutique", "Sweet Apple Acres", "Sugarcube Corner interior" } }
           , { "the Carousel Boutique", new List<string> { "the Castle of Friendship", "Sugarcube Corner", "Sweet Apple Acres", "the Carousel Boutique interior" } }
           , { "Sweet Apple Acres", new List<string> { "the Castle of Friendship", "the Carousel Boutique", "Sugarcube Corner", "Farmhouse interior" } }
           , { "the Castle of Friendship", new List<string> { "Sugarcube Corner", "the Carousel Boutique", "Sweet Apple Acres", "Castle main hall" } }


           , { "Sugarcube Corner interior", new List<string> { "Sugarcube Corner", "Sugarcube Corner kitchen", "Pinkie Pie's room", "the Party Cave" } }
           , { "Sugarcube Corner kitchen", new List<string> { "Sugarcube Corner interior" } }
           , { "Pinkie Pie's room", new List<string> { "Sugarcube Corner interior" } }
           , { "the Party Cave", new List<string> { "the Party Cave" } }

           , { "the Carousel Boutique interior", new List<string> { "the Carousel Boutique" } }

           , { "Farmhouse interior", new List<string> { "Sweet Apple Acres" } }

           , { "Castle main hall", new List<string> { "the Castle of Friendship", "Cutie Map room", "castle library", "castle kitchen", "Starlight's room" } }

           , { "Cutie Map room", new List<string> { "Castle main hall" } }
           , { "castle library", new List<string> { "Castle main hall" } }
           , { "castle kitchen", new List<string> { "Castle main hall" } }
           , { "Starlight's room", new List<string> { "Castle main hall" } }



            //,            "Sugarcube Corner interior"
          //,  "Sugarcube Corner kitchen"
          //,  "Pinkie Pie's room"
          //,  "the Party Cave"


          //,  "the Carousel Boutique interior"
          //,  "Farmhouse interior"
          //,  "Castle main hall"

          //,  "Cutie Map room"
          //,  "castle library"
          //,  "castle kitchen"
          //,  "Starlight's room"


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
