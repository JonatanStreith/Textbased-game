﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Location
    {

        private string name;
        private int coordX;
        private int coordY;
        private string description;

        private List<Creature> creaturesAtLocation = new List<Creature>();
        private List<Object> objectsAtLocation = new List<Object>();
        private List<Item> creaturesitemsAtLocation = new List<Item>();

        public Location(string inputName, int x, int y)
        {

            name = inputName;
            coordX = x;
            coordY = y;
            description = $"This is {name}";
        }

        public string GetName()
        { return name; }
        public string GetDescription()
        { return description; }
        public int GetX()
        { return coordX; }
        public int GetY()
        { return coordY; }


    }
}
