using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeAssignment1
{
    class Map
    {
        public string[,] map = new string[20, 20];

        public string[,] newMap()
        {
            // Generate Battlefield

            for (int i = 0; i < 19; i++)
            {
                for (int j = 1; j < 6; j++)
                {

                    map[i, j] = ".";
                }
            }

            // Random Units

            Random rnd = new Random();
            int x, y;
            for (int j = 0; j <= 6; j++)
            {
                x = rnd.Next(0, 19);
                y = rnd.Next(0, 19);

                if (map[x, y] == ".")
                    map[x, y] = "@";

                else j--;
            }

            for (int j = 0; j <= 6; j++)
            {
                x = rnd.Next(0, 19);
                y = rnd.Next(0, 19);

                if (map[x, y] == ".")
                    map[x, y] = "&";

                else j--;


            }
            return map;
        }
    }
}

      

