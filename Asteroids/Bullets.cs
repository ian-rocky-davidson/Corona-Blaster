using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Bullets : SpaceObject
    {
        public int life = 80;  //100;   // How many iterations the bullet can last.
        public int Iterations { get; set; }

        public bool Enemy = false;

        public Bullets(int StartPosX, int StartPosY, GameControl gameControl)
        : base(StartPosX, StartPosY, gameControl)
        { }

        public void Move()
        {
            // *** Now work out how many places to move x and y according to angle and speed.  *** See base class? ***
            point = CalcNewXY(point,2);

            Iterations++;
        }
    }
}
