﻿using System;
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
        private string location;

        private List<String> inventory = new List<string>();

        public Creature(string inputName, string inputRace)
        {
            name = inputName;
            race = inputRace;
        }


        public string GetName()
        { return name; }


        public string GetRace()
        { return race; }

        public string GetLocation()
        {
            return location;
        }

        public void SetLocation(string loc)
        {
            location = loc;
        }

    }
}
