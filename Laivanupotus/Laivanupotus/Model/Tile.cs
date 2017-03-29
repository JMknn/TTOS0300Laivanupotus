using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laivanupotus.Model
{
    public enum state
    {
        normal,
        ship,
        shipShotAt,
        shipSunk,
        shotAt
    }
    class Tile
    {
        private int xCoordinate;
        private int yCoordinate;
        private state state; 

        public state GetState()
        {
            return state;
        }
    }
}
