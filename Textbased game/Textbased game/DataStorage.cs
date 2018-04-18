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

        public static string[] legitimateCommands = { "go", "pick up", "talk to" };

    public static void CreateAllLocations()
    {
            Console.WriteLine("Creating SCC");

            Location SCC = new Location("Sugarcube Corner", 0, 0);
            Location Library = new Location("Golden Oaks Library", 0, 1);
            Location Boutique = new Location("Carousel Boutique", 1, 0);
            Location SAA = new Location("Sweet Apple Acres", 1, 1);

            locationList.Add(SCC);
            locationList.Add(Library);
            locationList.Add(Boutique);
            locationList.Add(SAA);
        }




    }


}
