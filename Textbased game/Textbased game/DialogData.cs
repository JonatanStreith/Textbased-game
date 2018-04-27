using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class DialogData            //This stores dialog lines
    {

        public static Dictionary<string, string[]> casualDialog = new Dictionary<string, string[]> {

             { "Twilight Sparkle", new String[] { "She looks at you with a frown. \"Oh... hello, Trixie.\"", "\"Do you want something?\"", "\"Please don't bother me while I'm busy.\"", "\"I'm sure Starlight is around here somewhere.\"" } }
           , { "Rarity", new String[] { "\"Hello, Trixie.\"", "\"Yes, dear?\"", "\"Please. I'm 'in the zone' at the moment.\"", "\"Do you want something? A new outfit?\"" } }
           , { "Applejack", new String[] { "\"Hey there, Trixie.\"", "\"You want somethin'?\"", "\"For the love o' Celestia, don't cause another mess.\"", "She snorts. \"Unlike some ponies, I'm too darn busy to stand around gawkin'.\"" } }
           , { "Pinkie Pie", new String[] { "\"Hi Trixie!\"", "\"Yeah? You want something? You want me to throw you a party?\"", "\"Hey, what's your favorite flavor? Blueberry? Chocolate? Chili pepper? Nooo reason...\"", "\"I think the programmer is trying to come up with new things for me to say.\"" } }
           , { "Rainbow Dash", new String[] { "\"Oh, hey.\"", "\"When did you get here?\"", "\"Hey, can you do fireworks on demand?\"", "\"Zzzzz... uh? Huh?\"" } }
           , { "Fluttershy", new String[] { "\"Umm...\"", "Fluttershy looks away bashfully.", "\"Um. Yes? D-do you want something?\"", "\"I... um... nevermind.\" *squeak*" } }
           , { "Spike", new String[] { "\"What do you want?\"", "\"Please tell me you're not going to break stuff again.\"", "\"Oh... I think I've got stuff to do. Elsewhere.\"", "\"Starlight's in the library, I think. Go bother her.\"" } }
           , { "Trixie", new String[] { "Talking to yourself is usually pointless.", "Much as you're a wonderful conversationalist, there's not much point.", "You'd rather not. Other ponies think you're weird enough as it is." } }
           , { "Placeholder", new String[] { "\"\"", "\"\"", "\"\"", "\"\"" } }


        };







        public static Dictionary<int, string> askCreature = new Dictionary<int, string>
        {

        };


        public static Dictionary<int, string> askTopic = new Dictionary<int, string>
        {

        };




        public static string[,] askArray = new string[,]
        {

        };









    }
}
