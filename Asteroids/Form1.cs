using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        // Objects
        GameControl gameControl;

        float shipAngle = 0.0F;

        public bool MouseEventLeft = false;
        public bool MouseEventRight = false;

        public bool SpaceBarDown = false;   // For laser sounds.

        Bitmap ship = new Bitmap(Properties.Resources.Ship2, 15, 15);
        Bitmap shipThrust = new Bitmap(Properties.Resources.Ship2Thrust, 15, 15);
        Bitmap shipThrustFast = new Bitmap(Properties.Resources.Ship2ThrustFast, 15, 15);

        public int FormSizeX = 1000;
        public int FormSizeY = 600;

        Random random = new Random(0);

        private bool startGame = false;
        StartGraphics startGraphics = null;

        // Attached stats form.
        private Form2 form2 = new Form2();

        // Atmosphere sounds.
        public System.Media.SoundPlayer soundPlayerStart = new System.Media.SoundPlayer(Properties.Resources.alien_spaceship);



        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new System.Drawing.Size(FormSizeX, FormSizeY);   // Set the form size.
            this.Location = new Point(20, 20);

            SetAssociatedForms();
            form2.Show(this);
            SetAssociatedForms();

            gameControl = new GameControl(this, form2);  // Create the GameControl class and pass in this form for reference.

            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (Pen greyPen = new Pen(Color.Gray))
            //using (Graphics g = CreateGraphics())
            //{
            //    Point point1 = new Point(10, 10);
            //    Point point2 = new Point(20, 10);
            //    Point point3 = new Point(15, 20);
            //    //  Point point4 = new Point(10, 10);
            //    Point[] polyPoints = { point1, point2, point3 };  //, point4 };
            //    g.DrawPolygon(greyPen, polyPoints);

            //    g.RotateTransform(20);
            //}
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Paint the ship on the screen.
            //e.Graphics.DrawImageUnscaled(ship1, shipLocX, shipLocY);
            if (gameControl.ship.ship1 != null)
                e.Graphics.DrawImageUnscaled(gameControl.ship.ship1, gameControl.ship.point.X, gameControl.ship.point.Y);

         
            foreach (Bullets bullet in gameControl.bullets)
            {
               e.Graphics.DrawImageUnscaled(Properties.Resources.BulletImage, bullet.point.X, bullet.point.Y);
            }

            foreach(Asteroid asteroid in gameControl.asteroids)
            {
                e.Graphics.DrawImageUnscaled(asteroid.ImageBitmap, asteroid.point.X, asteroid.point.Y);
            }

            // Ship hit graphics.
            if (gameControl.ShowExplosion > 0)
            {
                if (gameControl.ShowExplosion % 2  == 0)
                    e.Graphics.DrawImageUnscaled(gameControl.ship.ShipHitBitmap, gameControl.ExplosionPoint.X, gameControl.ExplosionPoint.Y);
                else
                    e.Graphics.DrawImageUnscaled(gameControl.ship.ship1, gameControl.ExplosionPoint.X, gameControl.ExplosionPoint.Y);

                gameControl.ShowExplosion --;
 
            }


            form2.angleTB.Text = gameControl.ship.Angle.ToString();
        }


        
        

        private void button2_Click(object sender, EventArgs e)
        {
            using (Pen greyPen = new Pen(Color.Gray))
            using (Graphics g = CreateGraphics())
            {
                g.DrawImageUnscaled(Properties.Resources.Ship1, 30, 30);
                g.RotateTransform(45);
            }
        }

        private void rotate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("rotate_click calling!");

            shipAngle += 15.0F;

            Invalidate();

            //  RotateBitmap(ship, angle);
        }

        private void PaintForm()
        {

        }

        private void SetAssociatedForms()
        {
            // Attach the stats form ten points to the right of this form.
            // Form2 has it's start position set to manual.
            form2.Location = new Point(Location.X + Width + 1, Location.Y + 32);
            form2.Height = this.Height - 39;
            form2.Width = 110;

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // *** Needed to set KeyPreview = true to get keys at forlevel.
               // MessageBox.Show("Key pressed = " + e.KeyData);

            if (startGame == false)
            {
                // *** Lets start the game. ***
                startGame = true;

                // Remove the user control.
                using (startGraphics)
                {
                    Controls.Remove(startGraphics);
                }
                startGraphics = null;

                // Start the timer
                this.gameTimer.Enabled = true;

            }

            if (e.Modifiers == Keys.Control ) //  || e.KeyData == Keys.Z)
                // Thrust up.
                gameControl.ship.Thruster(true);

            if (e.KeyData == Keys.X || e.KeyData == Keys.Z)
                // Brake
                gameControl.ship.Thruster(false);

            if (e.KeyData == Keys.Space)
            {
                gameControl.ship.Shoot();
                gameControl.soundPlayerLaseR.Play();
                SpaceBarDown = true;
            }
             

         //   Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    MessageBox.Show("Key pressed = " + e.KeyChar);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // while (e.Button == MouseButtons.Left  || e.Button == MouseButtons.Right)
                Console.WriteLine(e.Button.ToString());
            //  MessageBox.Show(e.Button.ToString());
            // ************************
            if (e.Button == MouseButtons.Left)
            {
               // shipAngle -= 15;
                this.MouseEventLeft = true;
            }
            if (e.Button == MouseButtons.Right)
            {
               // shipAngle += 15;
                this.MouseEventRight = true;
            }

            Invalidate();

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse up fired!");
          //  mouseTimer1.Enabled = false;

            this.MouseEventLeft = false;
            this.MouseEventRight = false;
        }

        private void mouseTimer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("mouseTimer1 fired! Right = " + MouseEventRight + " Left = " + MouseEventLeft);
 
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Key up triggered! Key = " + e.KeyData);

            if (e.KeyData == Keys.Space)
                gameControl.soundPlayerLaseR.Play();
                SpaceBarDown = false;

        }



        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // *** Game Timer
            gameControl.Iteration();

         }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void StartGame()
        {
            // Display our user control with the flashing message.
            Point point = new Point();
            point.X = (gameControl.FormSizeX / 2) - 140;
            point.Y = (gameControl.FormSizeY / 2) - 100;
 
            startGraphics = new StartGraphics() { Location = point };
            Controls.Add(startGraphics);

            // *** Form1_KeyDown will start the game timer.


            // Get any previous high score.
            string HSfile = AppDomain.CurrentDomain.BaseDirectory;
            HSfile = HSfile.Replace(@"Asteroids\bin\Debug", "");
            HSfile += "HighScore.txt";

            int highScore = 0;
            try
            {
                using (StreamReader reader = new StreamReader(HSfile))
                {
                    string highScoreString = reader.ReadLine();
                    highScore = int.Parse(highScoreString);
                    reader.Close();
                }
            }
            catch
            {
                // No file yet.
            }

            form2.highScoreLabel.Text = "High Score: " + highScore;

            // Some atmospheric sound.
            soundPlayerStart.Play();
    }


        public void GameOver()
        {
            this.gameTimer.Enabled = false;

            GameOver gameOver = null;
            Point point = new Point();
            point.X = (gameControl.FormSizeX / 2) - 50;
            point.Y = gameControl.FormSizeY / 2;

            if (gameOver == null)
            {
                gameOver = new GameOver() { Location = point };
                Controls.Add(gameOver);
            }

            // Get the recorded score if any and update if appropriate.
            // Get the directory to record the file.  Remove \bin\debug from the basedirectory as it won't let us write in there.
            string HSfile = AppDomain.CurrentDomain.BaseDirectory;
            HSfile = HSfile.Replace(@"Asteroids\bin\Debug", "");
            HSfile += "HighScore.txt";

            int highScore = 0;
            try
            {
                using (StreamReader reader = new StreamReader(HSfile))
                {
                    string highScoreString = reader.ReadLine();
                    highScore = int.Parse(highScoreString);
                    reader.Close();
                }
            }
            catch { }


            if (gameControl.PlayerScore > highScore)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(HSfile);
                    streamWriter.WriteLine(gameControl.PlayerScore.ToString());
                    streamWriter.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            // Some atmospheric sound.
            soundPlayerStart.PlayLooping();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            // If this form moves set the associated forms.
            SetAssociatedForms();
        }
    }
}
