using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Item : GenericObject
    {


        public Item(string inputName) //Constructor
        {
            name = inputName;

            if (ItemData.ItemShortNames.ContainsKey(name))
            { shortName = ItemData.ItemShortNames[name]; }
            else
            { shortName = name; }






            if (ItemData.itemDescriptions.ContainsKey(name))
            {                description = ItemData.itemDescriptions[name];            }
            else
            {
                Console.WriteLine($"{name} lacks description");
                description = "[description missing]";
            }

        }




    }
}
