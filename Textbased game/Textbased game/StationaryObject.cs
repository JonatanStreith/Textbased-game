using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class StationaryObject
    {
        private string name;
        private string fullName;

        public StationaryObject(string inputName)
        {
            name = inputName.ToLower();
            fullName = inputName;
        }

        public string GetName()
        { return name; }

        public string GetFullName()
        { return fullName; }



    }
}
