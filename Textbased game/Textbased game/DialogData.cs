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







        public static Dictionary<string, int> askCreature = new Dictionary<string, int>
        {

              { "Twilight Sparkle", 0 }
            , { "Rarity" , 1 }
            , { "Applejack", 2 }
            , { "Pinkie Pie", 3 }
            , { "Rainbow Dash", 4 }
            , { "Fluttershy", 5 }
            , { "Spike", 6 }
        };


        public static Dictionary<string, int> askTopic = new Dictionary<string, int>
        {
              {"magic", 0 }
            , {"friendship", 1 }
            , {"ponyville", 2 }
        };




        public static string[,] askArray = new string[,]
        {
             {"Twilight talks about magic.",         "Twilight talks about friendship.",     "Twilight talks about Ponyville.", }
           , {"Rarity talks about magic.",           "Rarity talks about friendship.",       "Rarity talks about Ponyville.", }
           , {"Applejack talks about magic.",        "Applejack talks about friendship.",    "Applejack talks about Ponyville.", }
           , {"Pinkie Pie talks about magic.",       "Pinkie Pie talks about friendship.",   "Pinkie Pie talks about Ponyville.", }
           , {"Rainbow Dash talks about magic.",     "Rainbow Dash talks about friendship.", "Rainbow Dash talks about Ponyville.", }
           , {"Fluttershy talks about magic.",       "Fluttershy talks about friendship.",   "Fluttershy talks about Ponyville.", }
           , {"Spike talks about magic.",            "Spike talks about friendship.",        "Spike talks about Ponyville.", }
           , {"Twilight talks about magic.",         "Twilight talks about friendship.",     "Twilight talks about Ponyville.", }
        };









    }
}
