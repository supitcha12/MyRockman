using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRockman
{
    public partial class MyRockman : Form
    {
        bool right, left, jump, BulletOut, BulletIn, FaceRight,
             right2, left2, jump2, BulletOut2, BulletIn2, FaceRight2;

        private void MyRockman_Load(object sender, EventArgs e)
        {
            bgSound.URL = @"background.wav";
            bgSound.settings.setMode("loop", true);
            bgSound.Ctlcontrols.play();

            runSound.URL = @"run.mp3";
            runSound.settings.setMode("loop", true);
            runSound.settings.volume = 20;
            runSound.Ctlcontrols.stop();

            jumpSound.URL = @"jump.mp3";
            jumpSound.settings.volume = 10;
            jumpSound.Ctlcontrols.stop();

            hitSound.URL = @"hit.wav";
            hitSound.settings.volume = 20;
            hitSound.Ctlcontrols.stop();

            painSound.URL = @"pain.wav";
            painSound.settings.volume = 20;
            painSound.Ctlcontrols.stop();
        }

        int G = 25, force, force2, BulletSpd = 15, BulletForce, BulletForce2;
        int PlayerHp1 = 100, PlayerHp2 = 100;

        public MyRockman()
        {
            InitializeComponent();
        }

        private void MyRockman_KeyDown(object sender, KeyEventArgs e)
        {
            tutor1.Hide();
            tutor2.Hide();
            if (e.KeyCode == Keys.D)
            {
                runSound.Ctlcontrols.play();
                right = true;
                if (BulletOut != true && BulletIn != true) FaceRight = true;
            }
            if (e.KeyCode == Keys.A)
            {
                runSound.Ctlcontrols.play();
                left = true;
                if (BulletOut != true && BulletIn != true) FaceRight = false;
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.W)
                {
                    jumpSound.Ctlcontrols.play();
                    jump = true;
                    force = G;
                }
            }
            if (BulletOut != true && BulletIn != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    BulletForce = BulletSpd;
                    BulletOut = true;
                }
            }
            //---------------------------------------------------------------Player2vv
            if (e.KeyCode == Keys.Right)
            {
                runSound.Ctlcontrols.play();
                right2 = true;
                if (BulletOut2 != true && BulletIn2 != true) FaceRight2 = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                runSound.Ctlcontrols.play();
                left2 = true;
                if (BulletOut2 != true && BulletIn2 != true) FaceRight2 = false;
            }

            if (jump2 != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jumpSound.Ctlcontrols.play();
                    jump2 = true;
                    force2 = G;
                }
            }
            if (BulletOut2 != true && BulletIn2 != true)
            {
                if (e.KeyCode == Keys.NumPad0)
                {
                    BulletForce2 = BulletSpd;
                    BulletOut2 = true;
                }
            }
        }

        private void MyRockman_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                runSound.Ctlcontrols.stop();
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                runSound.Ctlcontrols.stop();
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                runSound.Ctlcontrols.stop();
                right2 = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                runSound.Ctlcontrols.stop();
                left2 = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
                Player1.Left += 5;
                Player1.Image = Image.FromFile("player1_right.png");
            }
            if (left == true)
            {
                Player1.Left -= 5;
                Player1.Image = Image.FromFile("player1_left.png");
            }
            if (jump == true)
            {
                Player1.Top -= force;
                force -= 1;
            }
            if (Player1.Top + Player1.Height >= GameScreen.Height)
            {
                Player1.Top = GameScreen.Height - Player1.Height;
                jump = false;
            }
            else
            {
                Player1.Top += 5;
            }
            if (Player1.Left < GameScreen.Left) Player1.Left = GameScreen.Left;
            if (Player1.Right > GameScreen.Right) Player1.Left = GameScreen.Right - Player1.Width;

            if (BulletOut == true)
            {
                if (FaceRight == true) Bullet1.Left += BulletForce;
                if (FaceRight == false) Bullet1.Left -= BulletForce;
                BulletForce -= 1;
                if (BulletForce == 0)
                {
                    BulletOut = false;
                    BulletIn = true;
                }
            }
            if (BulletIn == true)
            {
                if (FaceRight == true) Bullet1.Left -= BulletForce;
                if (FaceRight == false) Bullet1.Left += BulletForce;
                BulletForce += 1;
                if ((FaceRight != true && Bullet1.Left >= Player1.Left) || (FaceRight == true && Bullet1.Left <= Player1.Left))
                {
                    BulletIn = false;
                }
            }
            if (BulletIn != true && BulletOut != true)
            {
                Bullet1.Left = Player1.Left + (Player1.Width / 8);
            }
            Bullet1.Top = Player1.Top + (Player1.Height / 4);

            //------------------------------------------------------------------------Player2vv
            if (right2 == true)
            {
                Player2.Left += 5;
                Player2.Image = Image.FromFile("player2_right.png");
            }
            if (left2 == true)
            {
                Player2.Left -= 5;
                Player2.Image = Image.FromFile("player2_left.png");
            }
            if (jump2 == true)
            {
                Player2.Top -= force2;
                force2 -= 1;
            }
            if (Player2.Top + Player2.Height >= GameScreen.Height)
            {
                Player2.Top = GameScreen.Height - Player2.Height;
                jump2 = false;
            }
            else
            {
                Player2.Top += 5;
            }
            if (Player2.Left < GameScreen.Left) Player2.Left = GameScreen.Left;
            if (Player2.Right > GameScreen.Right) Player2.Left = GameScreen.Right - Player2.Width;

            if (BulletOut2 == true)
            {
                if (FaceRight2 == true) Bullet2.Left += BulletForce2;
                if (FaceRight2 == false) Bullet2.Left -= BulletForce2;
                BulletForce2 -= 1;
                if (BulletForce2 == 0)
                {
                    BulletOut2 = false;
                    BulletIn2 = true;
                }
            }
            if (BulletIn2 == true)
            {
                if (FaceRight2 == true) Bullet2.Left -= BulletForce2;
                if (FaceRight2 == false) Bullet2.Left += BulletForce2;
                BulletForce2 += 1;
                if ((FaceRight2 != true && Bullet2.Left >= Player2.Left) || (FaceRight2 == true && Bullet2.Left <= Player2.Left))
                {
                    BulletIn2 = false;
                }
            }
            if (BulletIn2 != true && BulletOut2 != true)
            {
                Bullet2.Left = Player2.Left + (Player2.Width / 8);
            }
            Bullet2.Top = Player2.Top + (Player2.Height / 4);

            //---------------------------------------------------------------- User Interface

            if (PlayerHp1 < 0) PlayerHp1 = 0; if (PlayerHp2 < 0) PlayerHp2 = 0;
            Health1.Width = 2 * PlayerHp1; Health2.Width = 2 * PlayerHp2;
            text_PlayerHp1.Text = PlayerHp1.ToString(); text_PlayerHp2.Text = PlayerHp2.ToString();

            text_Name1.Top = Player1.Top - 15; text_Name2.Top = Player2.Top - 15;
            text_Name1.Left = Player1.Left - 10; text_Name2.Left = Player2.Left - 10;

            //---------------------------------------------------------------- Attack Collision
            if (Bullet1.Left > Player2.Left && Bullet1.Right < Player2.Right && Bullet1.Top > Player2.Top && Bullet1.Bottom < Player2.Bottom) 
            {
                hitSound.Ctlcontrols.play();
                painSound.Ctlcontrols.play();
                PlayerHp2 -= 1;
            }
            if (Bullet2.Left > Player1.Left && Bullet2.Right < Player1.Right && Bullet2.Top > Player1.Top && Bullet2.Bottom < Player1.Bottom)
            {
                hitSound.Ctlcontrols.play();
                painSound.Ctlcontrols.play();
                PlayerHp1 -= 1;
            }
        }
    }
}
