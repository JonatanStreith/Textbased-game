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
        private string race;
        private int locX;
        private int locY;


        private List<String> inventory = new List<string>();

        public Creature(string inputName, string inputRace, int x, int y)
        {
            name = inputName;
            race = inputRace;
            locX = x;
            locY = y;
        }


        public string GetName()
        { return name; }


        public string GetRace()
        { return race; }

        public int GetX()
        { return locX; }

        public int GetY()
        { return locY; }
    }
}
