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
        private string fullName;
        //private int coordX;
        //private int coordY;
        private string description;

        private string[] legitimateExits;


        //IMPORTANT! Locations should store a list/array/Enumerator of legitimate exits: direction, and which location it leads to. FIGURE OUT!



        public List<Creature> creaturesAtLocation = new List<Creature>();
        private List<Object> objectsAtLocation = new List<Object>();
        private List<Item> itemsAtLocation = new List<Item>();

        public Location(string inputName, string[] exits)
        {

            name = inputName.ToLower();
            fullName = inputName;

            legitimateExits = exits;

            description = DataStorage.placeDescriptions[fullName];
        }

        public string GetName()
        { return name; }

        public string GetFullName()
        { return fullName; }

        public string GetDescription()
        { return description; }


        public void AddCreature(Creature name)
        { creaturesAtLocation.Add(name); }

        public void RemoveCreature(Creature name)
        { creaturesAtLocation.Remove(name); }

        public void AddObject(Object name)
        { objectsAtLocation.Add(name); }

        public void RemoveObject(Object name)
        { objectsAtLocation.Remove(name); }

        public void AddItem(Item name)
        { itemsAtLocation.Add(name); }

        public void RemoveItem(Item name)
        { itemsAtLocation.Remove(name); }

        public string[] GetExits()
        { return legitimateExits; }


    }
}
