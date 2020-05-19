using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    class Ship : SpaceObject   // Inherit from SpaceObject.
    {

        Bitmap ship = new Bitmap(Properties.Resources.Ship2, 15, 15);
        Bitmap shipThrust = new Bitmap(Properties.Resources.Ship2Thrust, 15, 15);
        Bitmap shipThrustFast = new Bitmap(Properties.Resources.Ship2ThrustFast, 15, 15);

        public Bitmap ship1;   // Bitmap to return.
        public Bitmap ShipHitBitmap = ResizeImage(Properties.Resources.Explosion, 15, 15);

        public int thrust = 0;

        public int Drag = 0;   // Slows it down.

        public Ship(int StartPosX, int StartPosY, GameControl gameControl)
            :base(StartPosX, StartPosY, gameControl)
        { 
            SetImage(); 
        }

        override protected void SetImage()
        {
            // We need this to check for any hits on the ship.
            this.ImageBitmap = ResizeImage(Properties.Resources.Ship2, 15, 15);
        }
          

        public Bitmap Move()
        {

            // First rotate the ship.  MouseEventRight set in the form when mouse down pressed.

            // Ship rotation and ship graphic to display.
            if (gameControl.form1.MouseEventRight == true)
                Angle += 22.5F;  //15;  // 10;  // Consider 22.5
            if (gameControl.form1.MouseEventLeft == true)
                Angle -= 22.5F;  // 15;  // 10

            if (Angle > 360)
                Angle = 22.5F;   // 15;
            if (Angle < 0)
                Angle = 337.5F;  //  345;


            // *** Select the image to show.
            if (this.thrust >= 3)
            {
                ship1 = RotateImage(shipThrustFast, Angle);  // Image with red thrust.
            }
            else if (thrust >= 1)
            {
                ship1 = RotateImage(shipThrust, Angle);      // Image with little thrust.
            }
            else
            {
                ship1 = RotateImage(ship, Angle);            // Image with no thrust.
            }


            // *** Calculate the speed.  Speed created by the Z button.  Apply a drag to slow down.
            if (thrust >= 1)
            {
                Drag++;
                if (Drag > 10)
                {
                    thrust--;
                    gameControl.form2.thrustTB.Text = thrust.ToString();
                    Drag = 0;

                    if (thrust < 1)
                        gameControl.soundPlayerThrust.Stop();
                }
            }


            // *** Now work out how many places to move x and y according to angle and speed.  *** Base class? ***
            point = CalcNewXY(point ,thrust);

            return ship1;

        }

        public void Thruster(bool thrustOn)
        {
            if (gameControl.NoOfShips == 0)
                return;

            // Called from the form when pressing the Z button.
            if (thrustOn)
            {
                thrust += 1;
                if (thrust > 5)
                    thrust = 5;
            }
            else
                thrust -= 1;
            if (thrust < 1)
                thrust = 0;

            gameControl.form2.thrustTB.Text = thrust.ToString();

            Drag = 0;

            // Sound.
            gameControl.soundPlayerThrust.Play();
        }


        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));

            }
            return returnBitmap;
        }

        public void Shoot()
        {
            gameControl.AddBullet();
        }
    }
}
