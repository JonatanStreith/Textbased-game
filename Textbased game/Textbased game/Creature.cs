using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Creature
    {
        private string name;
        private string fullName;

        private string shortName;
        private string race;
        private string locationName;

        private List<String> inventory = new List<string>();

        public Creature(string inputName, string inputRace)
        {
            name = inputName.ToLower();
            fullName = inputName;
            race = inputRace;
            shortName = CreatureData.shortNames[fullName];

        }


        public string GetName()
        { return name; }
        public string GetFullName()
        { return fullName; }

        public string GetShortName()
        { return shortName; }


        public string GetRace()
        { return race; }

        public string GetLocationName()
        {
            return locationName;
        }

        public void SetLocation(string loc)
        {
            locationName = loc;
        }

    }
}
