using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class World
    {

        public List<Location> locationList = new List<Location>();
        public List<Creature> creatureList = new List<Creature>();
        public List<StationaryObject> stationaryObjectList = new List<StationaryObject>();
        public List<Item> itemList = new List<Item>();


        public List<GenericObject> genericList = new List<GenericObject>();


        public List<String> legitimateNouns = new List<String>();

        public Random diceRoll = new Random();

        public World()
        {
            //Locations
            Console.WriteLine("Creating locations...");


            locationList.Add(new Location("Sugarcube Corner", "bakery"));
            locationList.Add(new Location("the Castle of Friendship", "castle"));
            locationList.Add(new Location("the Carousel Boutique", "boutique"));
            locationList.Add(new Location("Sweet Apple Acres", "Acres"));

            locationList.Add(new Location("Sugarcube Corner interior", "bakery interior"));
            locationList.Add(new Location("Sugarcube Corner kitchen", "bakery kitchen"));
            locationList.Add(new Location("Pinkie Pie's room", "Pinkie's room"));
            locationList.Add(new Location("the Party Cave", "partycave"));

            locationList.Add(new Location("the Carousel Boutique interior", "boutique interior"));

            locationList.Add(new Location("Farmhouse interior", "Acres interior"));

            locationList.Add(new Location("Castle main hall", "main hall"));
            locationList.Add(new Location("Cutie Map room", "Map room"));
            locationList.Add(new Location("the castle library", "castle library"));
            locationList.Add(new Location("the castle kitchen", "castle kitchen"));
            locationList.Add(new Location("Starlight's room", "starlights room"));






            //Creatures

            Console.WriteLine("Creating creatures...");

            creatureList.Add(new Creature("Pinkie Pie", "Pinkie", "earth pony"));
            creatureList.Add(new Creature("Applejack", "AJ", "earth pony"));
            creatureList.Add(new Creature("Rainbow Dash", "RD", "pegasus"));
            creatureList.Add(new Creature("Fluttershy", "Fluttershy", "pegasus"));
            creatureList.Add(new Creature("Rarity", "Rarity", "unicorn"));
            creatureList.Add(new Creature("Twilight Sparkle", "Twilight", "alicorn"));
            creatureList.Add(new Creature("Spike", "Spike", "dragon"));

            creatureList.Add(new Creature("Maud Pie", "Maud", "earth pony"));
            creatureList.Add(new Creature("Starlight Glimmer", "Starlight", "unicorn"));

            

            creatureList.Add(new Creature("Trixie", "The Great and Powerful Trixie", "unicorn"));


            //Items

            itemList.Add(new Item("bundle of fireworks", "fireworks"));

            //Static objects

            stationaryObjectList.Add(new StationaryObject("Cutie Map", "map"));






            //--------------------------------

            //Add everything to the correct locations

            Console.WriteLine("Adding creatures to locations...");

            AddCreatureToLocation("Pinkie Pie", "Sugarcube Corner");
            AddCreatureToLocation("Applejack", "Sweet Apple Acres");
            AddCreatureToLocation("Rainbow Dash", "Sugarcube Corner");
            AddCreatureToLocation("Rarity", "the Carousel Boutique");
            AddCreatureToLocation("Fluttershy", "the Carousel Boutique");
            AddCreatureToLocation("Twilight Sparkle", "the castle library");
            AddCreatureToLocation("Spike", "the castle library");
            AddCreatureToLocation("Maud Pie", "Starlight's room");
            AddCreatureToLocation("Starlight Glimmer", "Cutie Map room");

            AddItemToLocation("bundle of fireworks", "Sugarcube Corner");

            AddObjectToLocation("Cutie Map", "Cutie Map room");




            //Note: Add Trixie last here!

            AddCreatureToLocation("Trixie", "Sugarcube Corner");

            //



            genericList.AddRange(creatureList);
            genericList.AddRange(itemList);
            genericList.AddRange(stationaryObjectList);
            genericList.AddRange(locationList);



            CreateProperNounList();



        }



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



        public void CreateProperNounList()
        {
            foreach (GenericObject i in genericList)
            {
                legitimateNouns.Add(i.GetName());
                legitimateNouns.Add(i.GetShortName());
            }

            legitimateNouns.Sort((a, b) => b.CompareTo(a));     //Sorts list in reverse alphabetical order; this avoids confusion

        }





        public Creature GetPlayer()
        { return creatureList.Find(x => x.GetName().ToLower().Contains("trixie")); }


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
        { return (GetPlayer().GetLocationName() == GetGenericObject(generic).GetLocationName()); }

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









    }
}
