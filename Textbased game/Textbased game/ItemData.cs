﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class ItemData
    {

        public static Dictionary<string, string> itemDescriptions = new Dictionary<string, string> {
            { "a rock", "It's a rock. You saw enough of them during your time on the rock farm." }
          , { "a wooden crate", "A wooden crate for putting things in." }
          , { "a bundle of fireworks", "A bunch of magical fireworks, crafted by yours truly. Handle with care!" }
          , { "Trixie's hat", "Your hat. Anypony who sees it will know that they're dealing with a magnificent magician. Good for keeping the sun out of your eyes, too." }
          , { "Trixie's cape", "Your cape. Anypony who sees it will know that they're dealing with a magnificent magician. Keeps you warm during travels, too." }
          , {"a juicy red apple", "Fragrant and delicious, just the thing for a quick snack."}
          , {"a heavy plow", "A piece of farming equipment used by earth ponies. You've done enough farming in your life already."}
          , {"a spool of thread", "A spool of blue thread. Rarity probably won't miss it."}
          , {"an unfinished dress", "This outfit is clearly far from complete, unless Rarity's fashion standards have changed very dramatically in the last week."}
          , {"a bucket of ice cream", "A bucket of chocolate-chip ice cream. You're certain you've earned yourself a treat today."}

        };

        public static Dictionary<string, string> ItemShortNames = new Dictionary<string, string> {

              { "a bundle of fireworks", "fireworks" }
            , { "a juicy red apple", "apple" }
            , { "a heavy plow", "plow" }
            , { "a spool of thread", "thread" }
           ,  { "an unfinished dress", "dress" }
           ,  { "a bucket of ice cream", "ice cream" }




    };

    }
}
