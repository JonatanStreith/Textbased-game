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


        public List<String> properNoun = new List<String>();



        public World()
        {
            Location Sugarcube = new Location("Sugarcube Corner", 0, 0);
            Location Library = new Location("Golden Oaks Library", 0, 1);
            Location Boutique = new Location("Carousel Boutique", 1, 0);
            Location Acres = new Location("Sweet Apple Acres", 1, 1);

            DataStorage.worldMap[0, 0] = Sugarcube;
            DataStorage.worldMap[0, 1] = Library;
            DataStorage.worldMap[1, 0] = Boutique;
            DataStorage.worldMap[1, 1] = Acres;



            locationList.Add(Sugarcube);
            locationList.Add(Library);
            locationList.Add(Boutique);
            locationList.Add(Acres);


            Creature Trixie = new Creature("Trixie", "unicorn");

            Creature PinkiePie = new Creature("Pinkie Pie", "earth pony");
            Creature Applejack = new Creature("Applejack", "earth pony");
            Creature RainbowDash = new Creature("Rainbow Dash", "pegasus");
            Creature Fluttershy = new Creature("Fluttershy", "pegasus");
            Creature Rarity = new Creature("Rarity", "unicorn");
            Creature TwilightSparkle = new Creature("Twilight Sparkle", "unicorn");
            Creature Spike = new Creature("Spike", "dragon");

            creatureList.Add(Trixie);
            creatureList.Add(PinkiePie);
            creatureList.Add(Applejack);
            creatureList.Add(RainbowDash);
            creatureList.Add(Fluttershy);
            creatureList.Add(Rarity);
            creatureList.Add(TwilightSparkle);
            creatureList.Add(Spike);

            AddCreatureToLocation("Sugarcube Corner", "Trixie");

            AddCreatureToLocation("Sugarcube Corner", "Pinkie Pie");
            AddCreatureToLocation("Sweet Apple Acres", "Applejack");
            AddCreatureToLocation("Sugarcube Corner", "Rainbow Dash");
            AddCreatureToLocation("Carousel Boutique", "Rarity");
            AddCreatureToLocation("Carousel Boutique", "Fluttershy");
            AddCreatureToLocation("Golden Oaks Library", "Twilight Sparkle");
            AddCreatureToLocation("Golden Oaks Library", "Spike");




            //


            CreateProperNounList();

        }



        public void AddCreatureToLocation(string location, string creature)
        {

            //Adds "creature" to "location"
            locationList.Find(x => x.GetName().Contains(location)).AddCreature(creatureList.Find(x => x.GetName().Contains(creature)));
            creatureList.Find(x => x.GetName().Contains(creature)).SetLocation(location);
        }

        public void CreateProperNounList()
        {

            foreach (Creature i in creatureList)
            { properNoun.Add(i.GetName()); }

            foreach (StationaryObject i in stationaryObjectList)
            { properNoun.Add(i.GetName()); }

            foreach (Item i in itemList)
            { properNoun.Add(i.GetName()); }

            foreach (Location i in locationList)
            { properNoun.Add(i.GetName()); }


        }


        public Creature GetPlayer()
        { return creatureList.Find(x => x.GetName().Contains("Trixie")); }


        public Location GetLocation(String input)
        { return locationList.Find(x => x.GetName().Contains(input)); }


        public Creature GetCreature(String input)
        { return creatureList.Find(x => x.GetName().Contains(input)); }

        public Item GetItem(String input)
        { return itemList.Find(x => x.GetName().Contains(input)); }

        public StationaryObject GetStationaryObject(String input)
        { return stationaryObjectList.Find(x => x.GetName().Contains(input)); }


    }
}
