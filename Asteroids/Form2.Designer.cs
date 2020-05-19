namespace Asteroids
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.angleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.levelTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.thrustTB = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shipPB1 = new System.Windows.Forms.PictureBox();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPB1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // playerScore
            // 
            this.playerScore.BackColor = System.Drawing.SystemColors.ControlText;
            this.playerScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(72, 214);
            this.playerScore.Name = "playerScore";
            this.playerScore.ReadOnly = true;
            this.playerScore.Size = new System.Drawing.Size(66, 19);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // angleTB
            // 
            this.angleTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.angleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.angleTB.ForeColor = System.Drawing.Color.White;
            this.angleTB.Location = new System.Drawing.Point(72, 282);
            this.angleTB.Name = "angleTB";
            this.angleTB.ReadOnly = true;
            this.angleTB.Size = new System.Drawing.Size(63, 19);
            this.angleTB.TabIndex = 5;
            this.angleTB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Large = 5 points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Medium = 3 points";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Small = 2 points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiny = 1 point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "LABEL7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Level";
            // 
            // levelTB
            // 
            this.levelTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.levelTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelTB.ForeColor = System.Drawing.Color.White;
            this.levelTB.Location = new System.Drawing.Point(72, 246);
            this.levelTB.Name = "levelTB";
            this.levelTB.ReadOnly = true;
            this.levelTB.Size = new System.Drawing.Size(100, 19);
            this.levelTB.TabIndex = 17;
            this.levelTB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thrust";
            // 
            // thrustTB
            // 
            this.thrustTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.thrustTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thrustTB.ForeColor = System.Drawing.Color.White;
            this.thrustTB.Location = new System.Drawing.Point(72, 316);
            this.thrustTB.Name = "thrustTB";
            this.thrustTB.Size = new System.Drawing.Size(100, 19);
            this.thrustTB.TabIndex = 19;
            this.thrustTB.Text = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Asteroids.Properties.Resources.NHS;
            this.pictureBox7.Location = new System.Drawing.Point(31, 820);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(94, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Asteroids.Properties.Resources.CVTinyRed;
            this.pictureBox6.Location = new System.Drawing.Point(59, 655);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(11, 10);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Asteroids.Properties.Resources.CVSmallBlue;
            this.pictureBox5.Location = new System.Drawing.Point(56, 582);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Asteroids.Properties.Resources.CVLargeRed;
            this.pictureBox4.Location = new System.Drawing.Point(38, 491);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Asteroids.Properties.Resources.CVLargeWhite;
            this.pictureBox2.Location = new System.Drawing.Point(16, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Asteroids.Properties.Resources.Ship2;
            this.pictureBox3.Location = new System.Drawing.Point(100, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asteroids.Properties.Resources.Ship2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // shipPB1
            // 
            this.shipPB1.Image = global::Asteroids.Properties.Resources.Ship2;
            this.shipPB1.Location = new System.Drawing.Point(44, 134);
            this.shipPB1.Name = "shipPB1";
            this.shipPB1.Size = new System.Drawing.Size(22, 30);
            this.shipPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shipPB1.TabIndex = 2;
            this.shipPB1.TabStop = false;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.highScoreLabel.Location = new System.Drawing.Point(14, 181);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(105, 20);
            this.highScoreLabel.TabIndex = 21;
            this.highScoreLabel.Text = "High Score: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 705);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 109);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mouse = Rotate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Space = Shoot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Control = Thrust";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(8, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Z or X = Brake";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(27, 883);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "For Little Ted";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(156, 991);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.thrustTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.levelTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angleTB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shipPB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPB1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox playerScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox angleTB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox levelTB;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox thrustTB;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox shipPB1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}