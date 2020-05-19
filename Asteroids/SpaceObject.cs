using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class SpaceObject
    {
        /// <summary>
        ///  Base class for ship, shots, asteroids.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="thrust"></param>
        /// <returns></returns>
        /// 
        public float Angle = 0.0F;

        public Point point = new Point();   // Keeps the x and y coordinates.

        // Any objects we may need.
        public GameControl gameControl;

        public Bitmap ImageBitmap;  // { get; set; }
        public Rectangle Area { get { return new Rectangle(point, ImageBitmap.Size); } }  // We can use the contains to see if this has been hit.


        public SpaceObject(int StartPosX, int StartPosY, GameControl gameControl)
        {
            this.gameControl = gameControl;   // Reference to the calling GameControl class.

            this.point.X = StartPosX;
            point.Y = StartPosY;
        }


        public Point CalcNewXY(Point point, int thrust)
        {
            // Work out how many spaces to send the objects x and y coordinates.
            // We rotate by 22.5 degrees.
            // Move 2 places each time and 1 place for the .5 degrees e.g 22.5.

            switch (Angle)
            {
                case 0:
                    point.Y -= thrust * 2;
                    break;
                case 22.5F:
                    point.X += thrust;
                    point.Y -= thrust * 2;
                    break;
                case 45:
                    point.X += thrust * 2;
                    point.Y -= thrust * 2;
                    break;
                case 67.5F:
                    point.X += thrust * 2;
                    point.Y -= thrust;
                    break;
                case 90:
                    point.X += thrust * 2;
                    break;
                case 112.5F:
                    point.X += thrust * 2;
                    point.Y += thrust;
                    break;
                case 135:
                    point.X += thrust * 2;
                    point.Y += thrust * 2;
                    break;
                case 157.5F:
                    point.X += thrust;
                    point.Y += thrust * 2;
                    break;
                case 180:
                    point.Y += thrust * 2;
                    break;
                case 202.5F:
                    point.X -= thrust;
                    point.Y += thrust * 2;
                    break;
                case 225:
                    point.X -= thrust * 2;
                    point.Y += thrust * 2;
                    break;
                case 247.5F:
                    point.X -= thrust * 2;
                    point.Y += thrust;
                    break;
                case 270:
                    point.X -= thrust * 2;
                    break;
                case 292.5F:
                    point.X -= thrust * 2;
                    point.Y -= thrust;
                    break;
                case 315:
                    point.X -= thrust * 2;
                    point.Y -= thrust;
                    break;
                case 337.5F:
                    point.X -= thrust;
                    point.Y -= thrust * 2;
                    break;
                case 360:
                    point.Y -= thrust * 2;
                    break;

            }

            if (point.X >= gameControl.FormSizeX)
                point.X = 1;
            if (point.X <= 0)
                point.X = gameControl.FormSizeX - 1;

            if (point.Y >= gameControl.FormSizeY)
                point.Y = 1;
            if (point.Y <= 0)
                point.Y = gameControl.FormSizeY - 1;

            return point;
        }


        // Static method to resize the bitmaps.
        public static Bitmap ResizeImage(Image ImageToResize, int Width, int Height)
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(ImageToResize, 0, 0, Width, Height);
            }

            bitmap.MakeTransparent(Color.Black);
            return bitmap;
        }

        virtual protected void SetImage()
        {

        }
    }
}
