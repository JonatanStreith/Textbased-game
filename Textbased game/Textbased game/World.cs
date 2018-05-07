﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class World
    {
        //public List<String> LoadedLocations = new List<string>();
        //public List<String[]> LoadedCreatures = new List<string[]>();
        //public List<String> LoadedItems = new List<string>();
        //public List<String> LoadedStationaryObjects = new List<string>();

        public Dictionary<string, string> GameFlags = new Dictionary<string, string>();     //Use this to store event flags and the like!



        public string filePath;

        public List<Location> locationList = new List<Location>();      //Main lists that store all game objects
        public List<Creature> creatureList = new List<Creature>();
        public List<StationaryObject> stationaryObjectList = new List<StationaryObject>();
        public List<Item> itemList = new List<Item>();

        public List<GenericObject> genericList = new List<GenericObject>();


        public List<Item> playerInventory = new List<Item>();



        public List<String> legitimateNouns = new List<String>();

        public List<string> legitimateCommands = new List<String> { "save", "load", "nouns", "look at", "look around", "look", "go to", "go", "pick up", "talk to", "quit", "drop", "brandish", "ask", "cast", "exits", "teleport to", "teleport", "help", "commands", "inventory" };
        public List<string> legitimateConjunctions = new List<String> { "to", "about", "behind", "at", "under", "in front of", "on", "in" };


        public Random diceRoll = new Random();

        public World(string newFilePath)
        {

            filePath = newFilePath;

            BuildGenericObjectLists();                   //Create and add all objects to the main lists










            //--------------------------------

            //Add everything to the correct locations

            Console.WriteLine("Adding creatures to locations...");

            AddCreatureToLocation("Pinkie Pie", "Sugarcube Corner");
            AddCreatureToLocation("Applejack", "Sweet Apple Acres");
            AddCreatureToLocation("Rainbow Dash", "Sugarcube Corner");
            AddCreatureToLocation("Rarity", "Carousel Boutique");
            AddCreatureToLocation("Fluttershy", "Carousel Boutique");
            AddCreatureToLocation("Twilight Sparkle", "Castle library");
            AddCreatureToLocation("Spike", "Castle library");
            AddCreatureToLocation("Maud Pie", "Starlight's room");
            AddCreatureToLocation("Starlight Glimmer", "Cutie Map room");

            AddItemToLocation("a bundle of fireworks", "Sugarcube Corner");

            AddItemToLocation("a juicy red apple", "Sweet Apple Acres");
            AddItemToLocation("a heavy plow", "Sweet Apple Acres");
            AddItemToLocation("a spool of thread", "Carousel Boutique");
            AddItemToLocation("an unfinished dress", "Carousel Boutique");
            AddItemToLocation("a bucket of ice cream", "Carousel Boutique");

            AddObjectToLocation("Rarity's sewing machine", "Carousel Boutique");
            AddObjectToLocation("Cutie Map", "Cutie Map room");
            AddObjectToLocation("Friendship thrones", "Cutie Map room");
            AddObjectToLocation("Twilight's throne", "Cutie Map room");
            AddObjectToLocation("Rarity's throne", "Cutie Map room");
            AddObjectToLocation("Applejack's throne", "Cutie Map room");
            AddObjectToLocation("Pinkie Pie's throne", "Cutie Map room");
            AddObjectToLocation("Fluttershy's throne", "Cutie Map room");
            AddObjectToLocation("Rainbow Dash's throne", "Cutie Map room");
            AddObjectToLocation("Spike's throne", "Cutie Map room");









            //Note: Add Trixie last here!

            AddCreatureToLocation("Trixie", "Sugarcube Corner");

            //






            CreateProperNounList();
            SortCommandAndConjunctionLists();


        }  //End of World constructor


























        public void AddCreatureToLocation(string creature, string location)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddCreature(GetCreature(creature));
            GetCreature(creature).SetLocation(location);
        }

        public void RemoveCreatureFromLocation(string creature, string location)
        { GetLocation(location).RemoveCreature(GetCreature(creature)); }



        public void AddItemToLocation(string item, string location)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddItem(GetItem(item));
            GetItem(item).SetLocation(location);
        }

        public void RemoveItemFromLocation(string item, string location)
        { GetLocation(location).RemoveItem(GetItem(item)); }


        public void AddObjectToLocation(string stationaryObject, string location)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddObject(GetStationaryObject(stationaryObject));
            GetStationaryObject(stationaryObject).SetLocation(location);
        }

        public void RemoveObjectFromLocation(string stationaryObject, string location)
        { GetLocation(location).RemoveObject(GetStationaryObject(stationaryObject)); }


        public void AddToInventory(Item item)
        {
            playerInventory.Add(item);
            item.SetLocation("inventory");

        }

        public void RemoveFromInventory(Item item)
        { playerInventory.Remove(item); }

        public bool IsInInventory(Item item)
        { return playerInventory.Contains(item); }

        public List<Item> GetInventory()
        { return playerInventory; }


        public void CreateProperNounList()
        {
            foreach (GenericObject i in genericList)
            {
                legitimateNouns.Add(i.GetName());
                legitimateNouns.Add(i.GetShortName());
            }

            legitimateNouns.Sort((a, b) => b.CompareTo(a));     //Sorts list in reverse alphabetical order; this avoids confusion

        }


        public void SortCommandAndConjunctionLists()
        {
            legitimateCommands.Sort((a, b) => b.CompareTo(a));
            legitimateConjunctions.Sort((a, b) => b.CompareTo(a));
        }





        public Creature GetPlayer()
        { return creatureList.Find(x => x.GetName().ToLower().Contains("trixie")); }

        public Location GetPlayerLocation()
        {
            return GetLocation(GetPlayer().GetLocationName());
        }




        public Location GetLocation(String input)
        { return locationList.Find(x => x.GetName().ToLower().Contains(input.ToLower())); }


        public Creature GetCreature(String input)
        { return creatureList.Find(x => x.GetName().ToLower().Contains(input.ToLower())); }

        public Item GetItem(String input)
        { return itemList.Find(x => x.GetName().ToLower().Contains(input.ToLower())); }

        public StationaryObject GetStationaryObject(String input)
        { return stationaryObjectList.Find(x => x.GetName().ToLower().Contains(input.ToLower())); }

        public GenericObject GetGenericObject(String input)
        { return genericList.Find(x => x.GetName().ToLower().Contains(input.ToLower())); }




        public bool IsObjectPresent(string generic)
        { return ((GetPlayer().GetLocationName() == GetGenericObject(generic).GetLocationName()) || (GetGenericObject(generic).GetLocationName() == "inventory")); }

        public bool DoesObjectExist(string generic)
        { return genericList.Contains(GetGenericObject(generic)); }

        public string ReturnFullName(string name)
        {
            string fullName = name;

            if (genericList.Exists(x => x.GetShortName().Equals(name, StringComparison.InvariantCultureIgnoreCase)))        //If there exists a generic object whose short name is (name)...
            { fullName = genericList.Find(x => x.GetShortName().ToLower().Contains(name.ToLower())).GetName(); }
            else
            { fullName = genericList.Find(x => x.GetName().ToLower().Contains(name.ToLower())).GetName(); }

            return fullName;
        }






        public void BuildGenericObjectLists()
        {

            Console.WriteLine("Writing stuff...");
            using (StreamReader sr = File.OpenText($@"{filePath}Locations.txt"))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (s != "")
                    {
                        locationList.Add(new Location(s));
                    }
                }
            }
            
            using (StreamReader sr = File.OpenText($@"{filePath}Creatures.txt"))
            {
                String s = "";
                string[] s_sep;

                string[] sep = new string[] { ", " };



                while ((s = sr.ReadLine()) != null)
                {
                    if (s != "")
                    {
                        s_sep = s.Split(sep, StringSplitOptions.None);

                        creatureList.Add(new Creature(s_sep[0], s_sep[1]));
                    }
                }
            }

            using (StreamReader sr = File.OpenText($@"{filePath}Items.txt"))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (s != "")
                    {
                        itemList.Add(new Item(s));
                    }
                }
            }

            using (StreamReader sr = File.OpenText($@"{filePath}StationaryObjects.txt"))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (s != "")
                    {
                        stationaryObjectList.Add(new StationaryObject(s));
                    }
                }
            }


            genericList.AddRange(creatureList);
            genericList.AddRange(itemList);
            genericList.AddRange(stationaryObjectList);
            genericList.AddRange(locationList);
        }


    }
}
