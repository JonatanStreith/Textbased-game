using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Creature : GenericObject
    {
        private string race;
        private string locationName;

        private List<String> inventory = new List<string>();

        public Creature(string inputName, string inputShortName, string inputRace)
        {
            name = inputName.ToLower();
            fullName = inputName;
            race = inputRace;
            shortName = inputShortName;

            description = DataStorage.creatureDescriptions[fullName];

        }



        public string GetRace()
        { return race; }

        public string GetLocationName()
        { return locationName; }

        public void SetLocation(string loc)
        { locationName = loc; }

    }
}
