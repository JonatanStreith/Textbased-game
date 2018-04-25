using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_game
{
    class HelpfulMethods
    {


        public static string IsOrAre(int num)
        {
            string output = "is";
            if (num > 1) { output = "are"; };

            return output;
        }


        public static String TurnListIntoString(List<GenericObject> list)     //Takes a list of objects, pieces together their names into one string
        {
            string fullString = list[0].GetName();
            list.RemoveAt(0);

            if (list.Count > 0)
            {
                while (list.Count > 1)
                {
                    fullString = fullString + $", {list[0].GetName()}";
                    list.RemoveAt(0);
                }
                fullString = fullString + $" and {list[0].GetName()}";
            }

            return fullString;

        }










    }
}
