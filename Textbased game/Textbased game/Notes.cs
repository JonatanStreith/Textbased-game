using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Notes
    {

        //This is mostly just to store helpful notes and useful syntax.

        //Location loc = DataStorage.locationList.Find(x => x.GetName().Contains("Sugarcube Corner"));

        //DataStorage.locationList.Find(x => x.GetName().Contains("Sugarcube Corner")).AddCreature(PinkiePie);

        //              This helpful line adds "Pinkie Pie" to "Sugarcube Corner".
        //              DataStorage.locationList.Find(x => x.GetName().Contains("Sugarcube Corner")).AddCreature(DataStorage.creatureList.Find(x => x.GetName().Contains("Pinkie Pie")));





        //Set something up so "shorthand" nouns (like "library" or "Twilight's library" for "Golden Oaks Library", and "Pinkie" for Pinkie Pie") get translated to their full forms. Figure something out!


        //Keep a dictionary of bools to track which ponies you're talked to, so they say something special the first time.


        //On moving around: Since locations are "proper nouns", the parser can take a location. If I write "Go to Sweet Apple Acres", it can see that SAA is a proper noun, check if SAA is adjacent, and go there if possible.
        //Should also be able to "Go west".


        //      Add "spells" as an new class, make list. Can use "cast" command. Trixie may know some spells, and learn others.

        //      Make sure that ALL commands that change things in the world, call on methods in the world object so changes happen THERE.



    }
}
