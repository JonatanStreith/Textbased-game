using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class DataStorage
    {
        public static List<Location> locationList = new List<Location>();
        public static List<Creature> creatureList = new List<Creature>();
        public static List<Object> objectList = new List<Object>();
        public static List<Item> itemList = new List<Item>();


        public static string[] legitimateCommands = { "go", "pick up", "talk to" };



    }


}
