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


        public List<String> legitimateNouns = new List<String>();

        public Random diceRoll = new Random();

        public World()
        {
            Location Sugarcube = new Location("Sugarcube Corner", DataStorage.legitimateExits["Sugarcube Corner"]);
            Location Library = new Location("Golden Oaks Library", DataStorage.legitimateExits["Golden Oaks Library"]);
            Location Boutique = new Location("Carousel Boutique", DataStorage.legitimateExits["Carousel Boutique"]);
            Location Acres = new Location("Sweet Apple Acres", DataStorage.legitimateExits["Sweet Apple Acres"]);




            locationList.Add(Sugarcube);
            locationList.Add(Library);
            locationList.Add(Boutique);
            locationList.Add(Acres);



            Creature PinkiePie = new Creature("Pinkie Pie", "earth pony");
            Creature Applejack = new Creature("Applejack", "earth pony");
            Creature RainbowDash = new Creature("Rainbow Dash", "pegasus");
            Creature Fluttershy = new Creature("Fluttershy", "pegasus");
            Creature Rarity = new Creature("Rarity", "unicorn");
            Creature TwilightSparkle = new Creature("Twilight Sparkle", "unicorn");
            Creature Spike = new Creature("Spike", "dragon");



            Creature Trixie = new Creature("Trixie", "unicorn");

            creatureList.Add(PinkiePie);
            creatureList.Add(Applejack);
            creatureList.Add(RainbowDash);
            creatureList.Add(Fluttershy);
            creatureList.Add(Rarity);
            creatureList.Add(TwilightSparkle);
            creatureList.Add(Spike);
            creatureList.Add(Trixie);


            AddCreatureToLocation("Sugarcube Corner", "Pinkie Pie");
            AddCreatureToLocation("Sweet Apple Acres", "Applejack");
            AddCreatureToLocation("Sugarcube Corner", "Rainbow Dash");
            AddCreatureToLocation("Carousel Boutique", "Rarity");
            AddCreatureToLocation("Carousel Boutique", "Fluttershy");
            AddCreatureToLocation("Golden Oaks Library", "Twilight Sparkle");
            AddCreatureToLocation("Golden Oaks Library", "Spike");







            AddCreatureToLocation("Sugarcube Corner", "Trixie");

            //


            CreateProperNounList();

        }



        public void AddCreatureToLocation(string location, string creature)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddCreature(GetCreature(creature));
            GetCreature(creature).SetLocation(location);
        }

        public void RemoveCreatureFromLocation(string location, string creature)
        {
            GetLocation(location).RemoveCreature(GetCreature(creature));
        }


        public void CreateProperNounList()
        {

            foreach (Creature i in creatureList)
            { legitimateNouns.Add(i.GetName()); }

            foreach (StationaryObject i in stationaryObjectList)
            { legitimateNouns.Add(i.GetName()); }

            foreach (Item i in itemList)
            { legitimateNouns.Add(i.GetName()); }

            foreach (Location i in locationList)
            { legitimateNouns.Add(i.GetName()); }


        }


        public Creature GetPlayer()
        { return creatureList.Find(x => x.GetName().Contains("trixie")); }


        public Location GetLocation(String input)
        { return locationList.Find(x => x.GetName().Contains(input.ToLower())); }


        public Creature GetCreature(String input)
        { return creatureList.Find(x => x.GetName().Contains(input.ToLower())); }

        public Item GetItem(String input)
        { return itemList.Find(x => x.GetName().Contains(input.ToLower())); }

        public StationaryObject GetStationaryObject(String input)
        { return stationaryObjectList.Find(x => x.GetName().ToLower().Contains(input)); }


    }
}
