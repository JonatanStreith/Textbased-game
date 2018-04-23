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
            name = inputName.ToLower();
            fullName = inputName;
            shortName = inputShortName;

            description = DataStorage.itemDescriptions[fullName];

        }




    }
}
