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

        private List<String> inventory = new List<string>();

        public Creature(string inputName, string inputRace)
        {
            name = inputName;
            race = inputRace;

            if (CreatureData.CreatureShortNames.ContainsKey(name))
            { shortName = CreatureData.CreatureShortNames[name]; }
            else
            { shortName = name; }





            if (CreatureData.creatureDescriptions.ContainsKey(name))
            { description = CreatureData.creatureDescriptions[name]; }
            else
            {
                Console.WriteLine($"{name} lacks description");
                description = "[description missing]";
            }

        }



        public string GetRace()
        { return race; }


    }
}
