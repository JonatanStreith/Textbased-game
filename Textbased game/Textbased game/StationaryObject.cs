using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class StationaryObject : GenericObject
    {


        public StationaryObject(string inputName, string inputShortName)
        {
            name = inputName.ToLower();
            fullName = inputName;
            shortName = inputShortName;

            description = DataStorage.objectDescriptions[fullName];

        }




    }
}
