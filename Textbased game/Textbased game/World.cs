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
            Location Sugarcube = new Location("Sugarcube Corner", "bakery", DataStorage.legitimateExits["Sugarcube Corner"]);
            Location FriendshipCastle = new Location("Castle of Friendship", "castle", DataStorage.legitimateExits["Castle of Friendship"]);
            Location Boutique = new Location("Carousel Boutique", "boutique", DataStorage.legitimateExits["Carousel Boutique"]);
            Location Acres = new Location("Sweet Apple Acres", "Acres", DataStorage.legitimateExits["Sweet Apple Acres"]);




            locationList.Add(Sugarcube);
            locationList.Add(FriendshipCastle);
            locationList.Add(Boutique);
            locationList.Add(Acres);



            Creature PinkiePie = new Creature("Pinkie Pie", "Pinkie", "earth pony");
            Creature Applejack = new Creature("Applejack", "AJ", "earth pony");
            Creature RainbowDash = new Creature("Rainbow Dash", "RD", "pegasus");
            Creature Fluttershy = new Creature("Fluttershy", "Fluttershy", "pegasus");
            Creature Rarity = new Creature("Rarity", "Rarity", "unicorn");
            Creature TwilightSparkle = new Creature("Twilight Sparkle", "Twilight", "alicorn");
            Creature Spike = new Creature("Spike", "Spike", "dragon");



            Creature Trixie = new Creature("The Great and Powerful Trixie", "Trixie", "unicorn");

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
            AddCreatureToLocation("Castle of Friendship", "Twilight Sparkle");
            AddCreatureToLocation("Castle of Friendship", "Spike");







            AddCreatureToLocation("Sugarcube Corner", "Trixie");

            //



            genericList.AddRange(creatureList);
            genericList.AddRange(itemList);
            genericList.AddRange(stationaryObjectList);
            genericList.AddRange(locationList);



            CreateProperNounList();


            //foreach (string item in legitimateNouns)
            //{
            //    Console.WriteLine(item);
            //}


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

            foreach (GenericObject i in genericList)
            {
                legitimateNouns.Add(i.GetName());
                legitimateNouns.Add(i.GetShortName());
            }




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







        public string ReturnFullName(string name)
        {
            string fullName = name;

            if (genericList.Exists(x => x.GetShortName().Equals(name, StringComparison.InvariantCultureIgnoreCase)))        //If there exists a generic object whose short name is (name)...
            {
                fullName = genericList.Find(x => x.GetShortName().ToLower().Contains(name.ToLower())).GetName();
            }



            return fullName;
        }






    }
}
