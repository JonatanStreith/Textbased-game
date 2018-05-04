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
            Location FriendshipCastle = new Location("the Castle of Friendship", "castle");
            Location Sugarcube = new Location("Sugarcube Corner", "bakery");
            Location Boutique = new Location("the Carousel Boutique", "boutique");
            Location Acres = new Location("Sweet Apple Acres", "Acres");

            Location SCCInteror = new Location("Sugarcube Corner interior", "bakery interior");
            Location SCCKitchen = new Location("Sugarcube Corner kitchen", "bakery kitchen");
            Location SCCPinkieroom = new Location("Pinkie Pie's room", "Pinkie's room");
            Location SCCPartycave = new Location("the Party Cave", "partycave");

            Location BoutiqueInside = new Location("the Carousel Boutique interior", "boutique interior");

            Location AcresInterior = new Location("Farmhouse interior", "Acres interior");

            Location CastleMainHall = new Location("Castle main hall", "main hall");
            Location CastleMapRoom = new Location("Cutie Map room", "Map room");
            Location CastleLibrary = new Location("the castle library", "castle library");
            Location CastleKitchen = new Location("the castle kitchen", "castle kitchen");
            Location CastleStarlightRoom = new Location("Starlight's room", "starlights room");











            locationList.Add(Sugarcube);
            locationList.Add(FriendshipCastle);
            locationList.Add(Boutique);
            locationList.Add(Acres);

            locationList.Add(SCCInteror);
            locationList.Add(SCCKitchen);
            locationList.Add(SCCPinkieroom);
            locationList.Add(SCCPartycave);

            locationList.Add(BoutiqueInside);

            locationList.Add(AcresInterior);

            locationList.Add(CastleMainHall);
            locationList.Add(CastleMapRoom);
            locationList.Add(CastleLibrary);
            locationList.Add(CastleKitchen);
            locationList.Add(CastleStarlightRoom);





            Creature PinkiePie = new Creature("Pinkie Pie", "Pinkie", "earth pony");
            Creature Applejack = new Creature("Applejack", "AJ", "earth pony");
            Creature RainbowDash = new Creature("Rainbow Dash", "RD", "pegasus");
            Creature Fluttershy = new Creature("Fluttershy", "Fluttershy", "pegasus");
            Creature Rarity = new Creature("Rarity", "Rarity", "unicorn");
            Creature TwilightSparkle = new Creature("Twilight Sparkle", "Twilight", "alicorn");
            Creature Spike = new Creature("Spike", "Spike", "dragon");

            //Add Maud, Starlight

            Creature Trixie = new Creature("Trixie", "The Great and Powerful Trixie", "unicorn");

            creatureList.Add(PinkiePie);
            creatureList.Add(Applejack);
            creatureList.Add(RainbowDash);
            creatureList.Add(Fluttershy);
            creatureList.Add(Rarity);
            creatureList.Add(TwilightSparkle);
            creatureList.Add(Spike);
            creatureList.Add(Trixie);


            AddCreatureToLocation("Sugarcube Corner", "Pinkie Pie");
            AddCreatureToLocation("Sugarcube Corner", "Applejack");
            AddCreatureToLocation("Sugarcube Corner", "Rainbow Dash");
            AddCreatureToLocation("Sugarcube Corner", "Rarity");
            AddCreatureToLocation("Sugarcube Corner", "Fluttershy");
            AddCreatureToLocation("Sugarcube Corner", "Twilight Sparkle");
            AddCreatureToLocation("Sugarcube Corner", "Spike");




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
        { GetLocation(location).RemoveCreature(GetCreature(creature)); }



        public void AddItemToLocation(string location, string item)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddItem(GetItem(item));
            GetCreature(item).SetLocation(location);
        }

        public void RemoveItemFromLocation(string location, string item)
        { GetLocation(location).RemoveItem(GetItem(item)); }


        public void AddObjectToLocation(string location, string stationaryObject)
        {
            //Adds "creature" to "location"
            GetLocation(location).AddObject(GetStationaryObject(stationaryObject));
            GetCreature(stationaryObject).SetLocation(location);
        }

        public void RemoveObjectFromLocation(string location, string stationaryObject)
        { GetLocation(location).RemoveObject(GetStationaryObject(stationaryObject)); }



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
