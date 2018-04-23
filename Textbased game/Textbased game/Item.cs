using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Item
    {
        private string name;
        private string fullName;

        public Item(string inputName) //Constructor
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
