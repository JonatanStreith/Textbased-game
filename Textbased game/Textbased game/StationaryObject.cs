using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class StationaryObject : GenericObject
    {


        public StationaryObject(string inputName)
        {
            name = inputName;

            if (StationaryObjectData.StationaryObjectShortNames.ContainsKey(name))
            { shortName = StationaryObjectData.StationaryObjectShortNames[name]; }
            else
            { shortName = name; }



            if (StationaryObjectData.stationaryObjectDescriptions.ContainsKey(name))
            {                description = StationaryObjectData.stationaryObjectDescriptions[name];            }
            else
            {
                Console.WriteLine($"{name} lacks description");
                description = "[description missing]";
            }

        }




    }
}
