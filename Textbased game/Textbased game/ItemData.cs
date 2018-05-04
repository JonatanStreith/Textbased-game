using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class ItemData
    {

        public static Dictionary<string, string> itemDescriptions = new Dictionary<string, string> {
            { "rock", "It's a rock. You saw enough of them during your time on the rock farm." }
          , { "wooden crate", "A wooden crate for putting things in." }
          , { "bundle of fireworks", "A bunch of magical fireworks, crafted by yours truly. Handle with care!" }
          , { "Trixie's hat", "Your hat. Anypony who sees it will know that they're dealing with a magnificent magician. Good for keeping the sun out of your eyes, too." }
          , { "Trixie's cape", "Your cape. Anypony who sees it will know that they're dealing with a magnificent magician. Keeps you warm during travels, too." }
        };

    }
}
