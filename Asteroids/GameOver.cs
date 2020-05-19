using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class GameOver : UserControl
    {
        private int phase = 0;
        public GameOver()
        {
            InitializeComponent();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            phase++;

            switch (phase)
            {
                case 1:
                    this.textBox1.ForeColor = Color.Red;
                    break;
                case 2:
                    this.textBox1.ForeColor = Color.AliceBlue;
                    break;
                case 3:
                    this.textBox1.ForeColor = Color.GreenYellow;
                    break;
                case 4:
                    this.textBox1.ForeColor = Color.White;
                    break;
                default:
                    this.textBox1.ForeColor = Color.Aqua;
                    phase = 0;
                    break;
            }



        }
    }
}
