using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Asteroid : SpaceObject
    {
        public enum Colours { Red, Blue, White, Green}
        public enum Sizes { Large, Medium, Small, Tiny}

        public Colours Colour { get; set; }
        public Sizes Size { get; set; }

      //  public Bitmap ImageBitmap;  // { get; set; }

      //  public Rectangle Area { get { return new Rectangle(point, ImageBitmap.Size); } }  // We can use the contains to see if this has been hit.

        public int Score { get; set; }  // No of points to score when hit.


        // Constructor takes the base and adds size as well.
        public Asteroid(int StartPosX, int StartPosY, GameControl gameControl, Sizes size, Colours colour)
             : base(StartPosX, StartPosY, gameControl)
        {
            this.Size = size;

            if (this.Size == Sizes.Large)
                this.Colour = (Colours)gameControl.random.Next(4);  // Random coluor if new.
            else
                this.Colour = colour;

            this.Angle = gameControl.random.Next(17) * 22.5F;   // Get a random angle.

            SetImage();

            SetScore();
        }

        public void Move()
        {
            // For Tiny red lets' make them chase the ship.
            if (this.Colour == Colours.Red && this.Size == Sizes.Tiny)
            {
                if (this.point.X == gameControl.ship.point.X)
                {
                    if (this.point.Y < gameControl.ship.point.Y)
                        Angle = 180.0F;
                    if (this.point.Y > gameControl.ship.point.Y)
                        Angle = 0.0F;
                }

                if (this.point.Y == gameControl.ship.point.Y)
                {
                    if (this.point.X < gameControl.ship.point.X)
                        Angle = 90.0F;
                    if (this.point.X > gameControl.ship.point.X)
                        Angle = 270.0F;
                }
                
            } 


            // *** Now work out how many places to move x and y according to angle and speed.  *** See base class? ***
            point = CalcNewXY(point, 1);
           
        }

        override protected void SetImage()
        {


            if (Colour == Colours.White)
            {
                // Only two size for white.
                if (Size == Sizes.Large || Size == Sizes.Medium) this.ImageBitmap = ResizeImage(Properties.Resources.CVLargeWhite, 75, 75);
                if (Size == Sizes.Small || Size == Sizes.Tiny) this.ImageBitmap = ResizeImage(Properties.Resources.CVLargeWhite, 25, 25);

            }
            else if (Colour == Colours.Blue)
            {

                if (Size == Sizes.Large) this.ImageBitmap = ResizeImage(Properties.Resources.CVLargeBlueTrans, 25, 25);
                if (Size == Sizes.Medium) this.ImageBitmap = ResizeImage(Properties.Resources.CVMediumBlue, 15, 15);
                if (Size == Sizes.Small) ImageBitmap = ResizeImage(Properties.Resources.CVSmallBlue, 10, 10);
                if (Size == Sizes.Tiny) ImageBitmap = ResizeImage(Properties.Resources.CVTinyBlue, 5, 5);
            }
                
            else if (Colour == Colours.Red)
            {
                if (Size == Sizes.Large) this.ImageBitmap = ResizeImage(Properties.Resources.CVLargeRed, 20, 20);
                if (Size == Sizes.Medium) ImageBitmap = ResizeImage(Properties.Resources.CVLargeRed, 15, 15);
                if (Size == Sizes.Small) ImageBitmap = ResizeImage(Properties.Resources.CVLargeRed, 10, 10);
                if (Size == Sizes.Tiny) ImageBitmap = ResizeImage(Properties.Resources.CVTinyRed, 5, 5);
            }
                            
            else if (Colour == Colours.Green)
            {
               
                if (Size == Sizes.Large) ImageBitmap = ResizeImage(Properties.Resources.CVLargeGreen, 15, 15);
                if (Size == Sizes.Medium) ImageBitmap = ResizeImage(Properties.Resources.CVMediumGreen, 12, 12);
                if (Size == Sizes.Small) ImageBitmap = ResizeImage(Properties.Resources.CVSmallGreen, 8, 8);
                if (Size == Sizes.Tiny) ImageBitmap = ResizeImage(Properties.Resources.CVTinyGreen, 5, 5);
            }
     
        }

        private void SetScore()
        {
            if (Size == Sizes.Large) Score = 5;
            if (Size == Sizes.Medium) Score = 3;
            if (Size == Sizes.Small) Score = 2;
            if (Size == Sizes.Tiny) Score = 1;
        }


        //// Static method to resize the bitmaps.  Meant to speed things up.
        //public static Bitmap ResizeImage(Image ImageToResize, int Width, int Height)
        //{
        //    Bitmap bitmap = new Bitmap(Width, Height);
        //    using (Graphics graphics = Graphics.FromImage(bitmap))
        //    {
        //        graphics.DrawImage(ImageToResize, 0, 0, Width, Height);
        //    }

        //    bitmap.MakeTransparent(Color.Black);
        //    return bitmap;
        //}

    }
}

