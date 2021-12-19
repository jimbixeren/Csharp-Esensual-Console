using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Esensual_Console
{
    internal class Player
    {
        public string name;
        public int id;
        public int points;
        public int startpoints;

        public Player(string aName, int aId, int aPoints, int aStartpoints)
        {
            name = aName;
            id = aId;
            points = aPoints;
            startpoints = aStartpoints;


        }
    }
}
