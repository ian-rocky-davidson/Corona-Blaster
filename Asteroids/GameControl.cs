using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    /// <summary>
    /// Author: Ian Davidson - United Kingdom
    /// Date:   April 2020
    /// Initial version 1.0
    /// Additional functionality to be added.  Enemy spaceship, shields etc.
    /// Shoot up the Corona virus.
    /// </summary>
    class GameControl
    {
        public Form1 form1;
        public Form2 form2;
        public Ship ship;

        public int NoOfShips = 3;
        public int FormSizeX { get; set; }
        public int FormSizeY { get; set; }

        public int Level;

        // List<T> array object for the shots.
        public List<Bullets> bullets;
        public int maxBullets = 50;
        public int BullettsFired = 0;

        // List<T> for Asteroid objects.
        public List<Asteroid> asteroids;

        // Player stats and score.
        public int PlayerScore { get; set; }

        // Sounds
        public System.Media.SoundPlayer soundPlayerLaser = new System.Media.SoundPlayer(@"C:\IansThings\DotNetProjects\Asteroids\Sounds\Laser-SoundBible.com-602495617.wav");
        public System.Media.SoundPlayer soundPlayerLaserFast = new System.Media.SoundPlayer(@"C:\IansThings\DotNetProjects\Asteroids\Sounds\Alien_Machine_Gun-Matt_Cutillo-2023875589.wav");
        public System.Media.SoundPlayer soundPlayerLaseR = new System.Media.SoundPlayer(Properties.Resources.Laser_SoundBible_com_602495617);

        public System.Media.SoundPlayer soundPlayerMachineGun = new System.Media.SoundPlayer(Properties.Resources.Alien_Machine_Gun_Matt_Cutillo_2023875589);
        public System.Media.SoundPlayer soundPlayerGlass = new System.Media.SoundPlayer(Properties.Resources.Glass_Break);
        public System.Media.SoundPlayer soundPlayerDyingRobot = new System.Media.SoundPlayer(Properties.Resources.Dying_Robot);
        public System.Media.SoundPlayer soundPlayerThrust = new System.Media.SoundPlayer(Properties.Resources.Rocket_Thrusters);

        public Random random = new Random();

        // For graphics in form1
        public int ShowExplosion = 0;   // Number of time to show the explosion.
        public Point ExplosionPoint;

        public GameControl(Form1 form1, Form2 form2)
        {
            this.form1 = form1;
            this.form2 = form2;

            FormSizeX = form1.FormSizeX;
            FormSizeY = form1.FormSizeY;

            Level = 1;
            NewLevel(Level);
        }

        public void NewLevel(int level)
        {
            form2.levelTB.Text = Level.ToString();
            if (Level > 1)
            {
                soundPlayerMachineGun.Play();
            }


            System.Threading.Thread.Sleep(1000);   // Wait for sound.
            // Create the inital and new levels.

            // Create Ship
            int startPosX = FormSizeX / 2;
            int startPosY = FormSizeY / 2;
            ship = new Ship(startPosX, startPosY, this);
            ship.thrust = 0;
            ship.Drag = 0;

            // Reset any bullets.
            bullets = new List<Bullets>();
            // if (bullets. > 0)
            //    bullets.Clear();

            // Create some asteroids / corona virus objects.
            asteroids = new List<Asteroid>();

            // Each level adds 5 extra asteroids.

            for (int i = 0; i < 5 * level; i++)
            {

                Point asteroidPoint = new Point();

                asteroidPoint.X = random.Next(0, FormSizeX);
                asteroidPoint.Y = random.Next(0, FormSizeY);

                // Just in case this asteroid is near the ship let's create another point instead.
                if (Math.Abs(asteroidPoint.X - startPosX) <= 10 &&
                    Math.Abs(asteroidPoint.Y - startPosY) <= 10)
                {
                    asteroidPoint.X = random.Next(0, FormSizeX);
                    asteroidPoint.Y = random.Next(0, FormSizeY);
                }

                Asteroid asteroid = new Asteroid(asteroidPoint.X, asteroidPoint.Y, this, Asteroid.Sizes.Large, Asteroid.Colours.Blue);

                asteroids.Add(asteroid);
            }

 

        }

        public void Iteration()
        {
            /// Fired by the form timer.  This will Move and process all of the space objects.
            ship.Move();

            // Move along the shots.
            // Delete any old ones.

            // Bullet Loop
             for (int i = bullets.Count - 1; i>= 0; i--)
            {
                Bullets bullet = bullets[i];
                bullet.Move();

                if (bullet.Iterations > bullet.life)
                {
                    bullets.Remove(bullet);
                    BullettsFired--;
                }  

                // Check if we have hit an asteroid.
                for (int a = asteroids.Count - 1; a >= 0; a--)
                {
                    Asteroid asteroid = asteroids[a];

                     if (asteroid.Area.Contains(bullet.point) )
                    {
                        // Add to score.
                        PlayerScore += asteroid.Score;
                        form2.playerScore.Text = PlayerScore.ToString();

                        // We have a hit.  Remove this asteroid and create more smaller ones if appropriate.
                        int createQty = 1;

                        if (asteroid.Size == Asteroid.Sizes.Large)
                        {

                            createQty = random.Next(1, Level);
                            for (int x = 0; x < createQty; x++)
                            {
                                Asteroid newAsteroid = new Asteroid(asteroid.point.X + 2, asteroid.point.Y, this, Asteroid.Sizes.Medium, asteroid.Colour);
                                asteroids.Add(newAsteroid);
                            }
                        }

                        if (asteroid.Size == Asteroid.Sizes.Medium)
                        {
                            createQty = random.Next(1, Level * 2);
                            for (int x = 0; x < createQty; x++)
                            {
                                Asteroid newAsteroid = new Asteroid(asteroid.point.X + 2, asteroid.point.Y, this, Asteroid.Sizes.Small, asteroid.Colour);
                                asteroids.Add(newAsteroid);
                            }
                        }

                        if (asteroid.Size == Asteroid.Sizes.Small)
                        {
                            createQty = random.Next(1, Level * 3);
                            for (int x = 0; x < createQty; x++)
                            {
                                Asteroid newAsteroid = new Asteroid(asteroid.point.X + 2, asteroid.point.Y, this, Asteroid.Sizes.Tiny, asteroid.Colour);
                                asteroids.Add(newAsteroid);
                            }
                        }

                        asteroids.Remove(asteroid);

                        bullets.Remove(bullet);
                        BullettsFired--;

                    }
                }

                // See is all asteroids have gone.  Need to start the next level.
                if (asteroids.Count <= 0)
                {
                    Level++;
                    NewLevel(Level);
                    return;
                }
            }   // End Bullet list loop.


            // Move the Asteroids.
            foreach (Asteroid asteroid in asteroids)
            {
                asteroid.Move();

                // See if this has hit our ship.
                if (asteroid.Area.IntersectsWith(ship.Area))
                {
                    // Oh dear we have been hit.  Call the NewShip routine.
                    NewShip();
                    ShowExplosion = 20;    // Number of times to show explosion
                    ExplosionPoint = asteroid.point;

                    break;

 
                }
            }

            // Fire the form paint event.
            form1.Invalidate();
        }



        public void AddBullet()
        {
            if (BullettsFired >= maxBullets)
                return;

            // Need to positon the bullet otherwise always fires from the upper left of the rectancle.
            Point bulletPoint;
            bulletPoint = ship.point;
            bulletPoint.X += 8;
            bulletPoint.Y += 8;

            bulletPoint = ship.CalcNewXY(bulletPoint, ship.thrust * 2);   // If you are moving fast the bullets are painted behind the ship.


            Bullets bullet = new Bullets(bulletPoint.X, bulletPoint.Y, this);

            bullet.Angle = ship.Angle; 
            
            bullets.Add(bullet);

            BullettsFired = bullets.Count();

            // Noise here
            //  System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\IansThings\DotNetProjects\Asteroids\Sounds\Laser-SoundBible.com-602495617.wav");
            //soundPlayerLaser.Play();
            soundPlayerLaseR.Play();

        }

        public void NewShip()
        {

            soundPlayerLaseR.Play();
            System.Threading.Thread.Sleep(500);
            soundPlayerGlass.Play();
            System.Threading.Thread.Sleep(500);

            NoOfShips--;

            switch (NoOfShips)
            {
                case 0:
                    form2.shipPB1.Visible = false;      // 1st ship image.
                    soundPlayerThrust.Stop();
                    form1.GameOver();
                    break;
                case 1:
                    form2.pictureBox1.Visible = false;  // 2nd ship image.
                    break;
                case 2:
                    form2.pictureBox3.Visible = false;  // 3rd ship image
                    break;
                case 3:
                    // Need to code for bonus ship.
                    break;
            }

            if (NoOfShips == 0)
                return;

            ship.thrust = 0;
            ship.Drag = 0;
            // Position ship again

            int startPosX = FormSizeX / 2;
            int startPosY = FormSizeY / 2;
            ship.point.X = startPosX;
            ship.point.Y = startPosY;

            // *** Check that the new start location is not on top of an existing asteroid.
            var looper = true;
            while (looper)
            {
                var pointTaken =
                    from asteroid in asteroids
                    where asteroid.Area.IntersectsWith(ship.Area)
                    select asteroid;

                if (pointTaken.Count() > 0)
                {
                    // Calculate a new start position for the ship.
                    ship.point.X += 50;
                    ship.point.Y += 50;
                }
                else    // No overlap so we are good.
                    looper = false;

            }

        }

    }
}
