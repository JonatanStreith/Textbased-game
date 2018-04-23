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
        protected string fullName;
        protected string shortName;

        protected string description;


        public string GetName()
        { return name; }

        public string GetFullName()
        { return fullName; }

        public string GetShortName()
        { return shortName; }

        public string GetDescription()
        { return description; }


    }
}
