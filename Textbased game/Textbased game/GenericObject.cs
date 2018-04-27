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

        protected string objectType;

        protected string description;

        protected string locationName;


        public string GetName()
        { return name; }

                public string GetShortName()
        { return shortName; }

        public string GetObjectType()
        { return objectType; }

        public string GetDescription()
        { return description; }

        public string GetLocationName()
        { return locationName; }

        public void SetLocation(string loc)
        { locationName = loc; }

    }
}
