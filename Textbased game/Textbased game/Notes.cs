using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Notes
    {


        //IMPORTANT! REVISE A LOT OF THINGS so objects use "ID" instead of names, in case we want to use similar names for things.


        //Teleport: You could teleport to other ponies! Maybe?

        //Tidy up the "GetExit" command!



        //Keep a dictionary of bools to track which ponies you're talked to, so they say something special the first time.


        //On moving around: Since locations are "proper nouns", the parser can take a location. If I write "Go to Sweet Apple Acres", it can see that SAA is a proper noun, check if SAA is adjacent, and go there if possible.
        //Should also be able to "Go west".


        //      Add "spells" as an new class, make list. Can use "cast" command. Trixie may know some spells, and learn others.

        //      Make sure that ALL commands that change things in the world, call on methods in the world object so changes happen THERE.



    }
}
