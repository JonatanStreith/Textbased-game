using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class GenericObject
    {
        protected string name;
        protected string shortName;

        protected string description;


        public string GetName()
        { return name; }


        public string GetShortName()
        { return shortName; }

        public string GetDescription()
        { return description; }


    }
}
