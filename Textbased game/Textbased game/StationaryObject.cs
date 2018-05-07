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
            name = inputName;
            shortName = inputShortName;

            if (StationaryObjectData.stationaryObjectDescriptions.ContainsKey(name))
            {
                description = StationaryObjectData.stationaryObjectDescriptions[name];
            }
            else
            {
                Console.WriteLine($"{name} lacks description");
                description = "[description missing]";
            }

        }




    }
}
