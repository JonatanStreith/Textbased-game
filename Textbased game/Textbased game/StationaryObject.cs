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

        public StationaryObject(string inputName)
        {
            name = inputName;
        }

        public string GetName()
        { return name; }



    }
}
