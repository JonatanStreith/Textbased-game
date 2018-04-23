using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Spell : GenericObject
    {


        public Spell(string inputName, string inputShortName)
        {
            name = inputName.ToLower();
            fullName = inputName;
            shortName = inputShortName;

        }
    }
}
