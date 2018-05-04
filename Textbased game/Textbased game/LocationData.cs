using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class LocationData
    {

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
          , { "the castle library","The library holds copies of every book in Equestria that Twilight Sparkle could get her hooves on. If you need to look something up, you suppose you could come here." }
          , { "the castle kitchen","The castle kitchen is a great place to stock up on snacks. As long as Spike doesn't catch you." }
          , {"Starlight's room","Starlight's room. You hang out here sometimes." }


        };





        public static Dictionary<string, List<string>> legitimateExits = new Dictionary<string, List<string>> {


            //Main cells (outside)
             { "Sugarcube Corner", new List<string> { "the Castle of Friendship", "the Carousel Boutique", "Sweet Apple Acres", "Sugarcube Corner interior" } }
           , { "the Carousel Boutique", new List<string> { "the Castle of Friendship", "Sugarcube Corner", "Sweet Apple Acres", "the Carousel Boutique interior" } }
           , { "Sweet Apple Acres", new List<string> { "the Castle of Friendship", "the Carousel Boutique", "Sugarcube Corner", "Farmhouse interior" } }
           , { "the Castle of Friendship", new List<string> { "Sugarcube Corner", "the Carousel Boutique", "Sweet Apple Acres", "Castle main hall" } }

            //Sugercube Corner
           , { "Sugarcube Corner interior", new List<string> { "Sugarcube Corner", "Sugarcube Corner kitchen", "Pinkie Pie's room", "the Party Cave" } }
           , { "Sugarcube Corner kitchen", new List<string> { "Sugarcube Corner interior" } }
           , { "Pinkie Pie's room", new List<string> { "Sugarcube Corner interior" } }
           , { "the Party Cave", new List<string> { "the Party Cave" } }


            //Carousel Boutique
           , { "the Carousel Boutique interior", new List<string> { "the Carousel Boutique" } }


            //Sweet Apple Acres
           , { "Farmhouse interior", new List<string> { "Sweet Apple Acres" } }

            //Castle of Friendship
           , { "Castle main hall", new List<string> { "the Castle of Friendship", "Cutie Map room", "the castle library", "the castle kitchen", "Starlight's room" } }
           , { "Cutie Map room", new List<string> { "Castle main hall" } }
           , { "the castle library", new List<string> { "Castle main hall" } }
           , { "the castle kitchen", new List<string> { "Castle main hall" } }
           , { "Starlight's room", new List<string> { "Castle main hall" } }


        };



    }
}
