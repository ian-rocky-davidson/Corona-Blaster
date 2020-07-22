using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class EnemyShip : SpaceObject   // Inherit from SpaceObject.
    {
        public EnemyShip(int StartPosX, int StartPosY, GameControl gameControl)
            : base(StartPosX, StartPosY, gameControl)
        {
            SetImage();
        }


        override protected void SetImage()
        {
            // We need this to check for any hits on the ship.
            this.ImageBitmap = ResizeImage(Properties.Resources.EnemyShip, 13, 13);
        }

        public void Move()
        {
            // *** Now work out how many places to move x and y according to angle and speed.  *** Base class? ***
            point = CalcNewXY(point, 1);    //  thrust=1;
        }

        public void Shoot()  // ***
        {
            gameControl.AddEnemyBullet();
        }
    }
}
