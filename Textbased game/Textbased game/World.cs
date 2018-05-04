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


        public List<Item> playerInventory = new List<Item>();



        public List<String> legitimateNouns = new List<String>();

        public List<string> legitimateCommands = new List<String> { "nouns", "look at", "look around", "look", "go to", "go", "pick up", "talk to", "quit", "drop", "brandish", "ask", "cast", "exits", "teleport to", "teleport", "help", "commands", "inventory" };
        public List<string> legitimateConjunctions = new List<String> { "to", "about", "behind", "at", "under", "in front of", "on", "in" };


        public Random diceRoll = new Random();

        public World()
        {
            //Locations
            Console.WriteLine("Creating locations...");


            locationList.Add(new Location("Sugarcube Corner", "bakery"));
            locationList.Add(new Location("Castle of Friendship", "castle"));
            locationList.Add(new Location("Carousel Boutique", "boutique"));
            locationList.Add(new Location("Sweet Apple Acres", "Acres"));

            locationList.Add(new Location("Sugarcube Corner interior", "bakery interior"));
            locationList.Add(new Location("Sugarcube Corner kitchen", "bakery kitchen"));
            locationList.Add(new Location("Pinkie Pie's room", "Pinkie's room"));
            locationList.Add(new Location("Party Cave", "partycave"));

            locationList.Add(new Location("Carousel Boutique interior", "boutique interior"));

            locationList.Add(new Location("Farmhouse interior", "Acres interior"));

            locationList.Add(new Location("Castle main hall", "main hall"));
            locationList.Add(new Location("Cutie Map room", "Map room"));
            locationList.Add(new Location("Castle library", "castle library"));
            locationList.Add(new Location("Castle kitchen", "castle kitchen"));
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

            itemList.Add(new Item("a bundle of fireworks", "fireworks"));
            itemList.Add(new Item("a juicy red apple", "apple"));
            itemList.Add(new Item("a heavy plow", "plow"));
            itemList.Add(new Item("a spool of thread", "thread"));
            itemList.Add(new Item("an unfinished dress", "dress"));
            itemList.Add(new Item("a bucket of ice cream", "ice cream"));



            //Static objects

            stationaryObjectList.Add(new StationaryObject("Cutie Map", "map"));
            stationaryObjectList.Add(new StationaryObject("Friendship thrones", "thrones"));
            stationaryObjectList.Add(new StationaryObject("Twilight's throne", "Throne of Magic"));
            stationaryObjectList.Add(new StationaryObject("Rarity's throne", "Throne of Generosity"));
            stationaryObjectList.Add(new StationaryObject("Applejack's throne", "Throne of Honesty"));
            stationaryObjectList.Add(new StationaryObject("Pinkie Pie's throne", "Throne of Laughter"));
            stationaryObjectList.Add(new StationaryObject("Fluttershy's throne", "Throne of Kindness"));
            stationaryObjectList.Add(new StationaryObject("Rainbow Dash's throne", "Throne of Loyalty"));
            stationaryObjectList.Add(new StationaryObject("Spike's throne", "tiny throne"));

            stationaryObjectList.Add(new StationaryObject("Rarity's sewing machine", "sewing machine"));

            stationaryObjectList.Add(new StationaryObject("apple tree", "tree"));
            stationaryObjectList.Add(new StationaryObject("baking oven", "oven"));


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



            genericList.AddRange(creatureList);
            genericList.AddRange(itemList);
            genericList.AddRange(stationaryObjectList);
            genericList.AddRange(locationList);



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









    }
}
