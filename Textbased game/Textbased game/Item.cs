using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Item : GenericObject
    {


        public Item(string inputName, string inputShortName) //Constructor
        {
            name = inputName;
            shortName = inputShortName;
                        
            if (ItemData.itemDescriptions.ContainsKey(name))
            {
                description = ItemData.itemDescriptions[name];
            }
            else
            {
                Console.WriteLine($"{name} lacks description");
                description = "[description missing]";
            }

        }




    }
}
