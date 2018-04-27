using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class Location : GenericObject
    {


        private List<string> legitimateExits;


        //IMPORTANT! Locations should store a list/array/Enumerator of legitimate exits: direction, and which location it leads to. FIGURE OUT!



        private List<Creature> creaturesAtLocation = new List<Creature>();
        private List<StationaryObject> objectsAtLocation = new List<StationaryObject>();
        private List<Item> itemsAtLocation = new List<Item>();

        public Location(string inputName, string inputShortName, List<string> exits)
        {

            name = inputName;
            shortName = inputShortName;
            objectType = "item";
            description = DataStorage.placeDescriptions[name];

            legitimateExits = exits;

            locationName = name;

        }


        public List<Creature> GetCreaturesAtLocation()
        { return creaturesAtLocation; }
        public List<StationaryObject> GetObjectsAtLocation()
        { return objectsAtLocation; }
        public List<Item> GetItemsAtLocation()
        { return itemsAtLocation; }



        public void AddCreature(Creature name)
        { creaturesAtLocation.Add(name); }

        public void RemoveCreature(Creature name)
        { creaturesAtLocation.Remove(name); }

        public void AddObject(StationaryObject name)
        { objectsAtLocation.Add(name); }

        public void RemoveObject(StationaryObject name)
        { objectsAtLocation.Remove(name); }

        public void AddItem(Item name)
        { itemsAtLocation.Add(name); }

        public void RemoveItem(Item name)
        { itemsAtLocation.Remove(name); }

        public List<string> GetExits()
        { return legitimateExits; }


    }
}
