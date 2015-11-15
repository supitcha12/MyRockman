namespace MyRockman
{
    partial class MyRockman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRockman));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GameScreen = new System.Windows.Forms.Panel();
            this.text_Name2 = new System.Windows.Forms.Label();
            this.text_Name1 = new System.Windows.Forms.Label();
            this.text_PlayerHp2 = new System.Windows.Forms.Label();
            this.text_PlayerHp1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Health2 = new System.Windows.Forms.PictureBox();
            this.Health1 = new System.Windows.Forms.PictureBox();
            this.Bullet2 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Bullet1 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Wallpaper = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.tutor1 = new System.Windows.Forms.Label();
            this.tutor2 = new System.Windows.Forms.Label();
            this.bgSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.runSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.jumpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.hitSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.painSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.GameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painSound)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameScreen
            // 
            this.GameScreen.Controls.Add(this.text_Name2);
            this.GameScreen.Controls.Add(this.text_Name1);
            this.GameScreen.Controls.Add(this.text_PlayerHp2);
            this.GameScreen.Controls.Add(this.text_PlayerHp1);
            this.GameScreen.Controls.Add(this.label2);
            this.GameScreen.Controls.Add(this.label1);
            this.GameScreen.Controls.Add(this.Health2);
            this.GameScreen.Controls.Add(this.Health1);
            this.GameScreen.Controls.Add(this.Bullet2);
            this.GameScreen.Controls.Add(this.Player2);
            this.GameScreen.Controls.Add(this.Bullet1);
            this.GameScreen.Controls.Add(this.Player1);
            this.GameScreen.Controls.Add(this.pictureBox1);
            this.GameScreen.Controls.Add(this.pictureBox2);
            this.GameScreen.Controls.Add(this.Wallpaper);
            this.GameScreen.Location = new System.Drawing.Point(-5, -4);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(796, 294);
            this.GameScreen.TabIndex = 1;
            // 
            // text_Name2
            // 
            this.text_Name2.AutoSize = true;
            this.text_Name2.BackColor = System.Drawing.Color.Transparent;
            this.text_Name2.Location = new System.Drawing.Point(611, 228);
            this.text_Name2.Name = "text_Name2";
            this.text_Name2.Size = new System.Drawing.Size(42, 13);
            this.text_Name2.TabIndex = 13;
            this.text_Name2.Text = "Player2";
            // 
            // text_Name1
            // 
            this.text_Name1.AutoSize = true;
            this.text_Name1.BackColor = System.Drawing.Color.Transparent;
            this.text_Name1.Location = new System.Drawing.Point(108, 228);
            this.text_Name1.Name = "text_Name1";
            this.text_Name1.Size = new System.Drawing.Size(42, 13);
            this.text_Name1.TabIndex = 12;
            this.text_Name1.Text = "Player1";
            // 
            // text_PlayerHp2
            // 
            this.text_PlayerHp2.AutoSize = true;
            this.text_PlayerHp2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_PlayerHp2.ForeColor = System.Drawing.SystemColors.Control;
            this.text_PlayerHp2.Location = new System.Drawing.Point(581, 21);
            this.text_PlayerHp2.Name = "text_PlayerHp2";
            this.text_PlayerHp2.Size = new System.Drawing.Size(42, 13);
            this.text_PlayerHp2.TabIndex = 11;
            this.text_PlayerHp2.Text = "Player1";
            // 
            // text_PlayerHp1
            // 
            this.text_PlayerHp1.AutoSize = true;
            this.text_PlayerHp1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_PlayerHp1.ForeColor = System.Drawing.SystemColors.Control;
            this.text_PlayerHp1.Location = new System.Drawing.Point(22, 21);
            this.text_PlayerHp1.Name = "text_PlayerHp1";
            this.text_PlayerHp1.Size = new System.Drawing.Size(42, 13);
            this.text_PlayerHp1.TabIndex = 10;
            this.text_PlayerHp1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player1";
            // 
            // Health2
            // 
            this.Health2.BackColor = System.Drawing.SystemColors.ControlText;
            this.Health2.Location = new System.Drawing.Point(577, 16);
            this.Health2.Name = "Health2";
            this.Health2.Size = new System.Drawing.Size(200, 22);
            this.Health2.TabIndex = 5;
            this.Health2.TabStop = false;
            // 
            // Health1
            // 
            this.Health1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Health1.Location = new System.Drawing.Point(17, 16);
            this.Health1.Name = "Health1";
            this.Health1.Size = new System.Drawing.Size(200, 22);
            this.Health1.TabIndex = 4;
            this.Health1.TabStop = false;
            // 
            // Bullet2
            // 
            this.Bullet2.BackColor = System.Drawing.Color.Transparent;
            this.Bullet2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bullet2.Image = ((System.Drawing.Image)(resources.GetObject("Bullet2.Image")));
            this.Bullet2.Location = new System.Drawing.Point(624, 261);
            this.Bullet2.Name = "Bullet2";
            this.Bullet2.Size = new System.Drawing.Size(15, 15);
            this.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet2.TabIndex = 3;
            this.Bullet2.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player2.Image = ((System.Drawing.Image)(resources.GetObject("Player2.Image")));
            this.Player2.Location = new System.Drawing.Point(612, 246);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(40, 50);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // Bullet1
            // 
            this.Bullet1.BackColor = System.Drawing.Color.Transparent;
            this.Bullet1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bullet1.Image = ((System.Drawing.Image)(resources.GetObject("Bullet1.Image")));
            this.Bullet1.Location = new System.Drawing.Point(121, 261);
            this.Bullet1.Name = "Bullet1";
            this.Bullet1.Size = new System.Drawing.Size(15, 15);
            this.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet1.TabIndex = 1;
            this.Bullet1.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(108, 246);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(40, 50);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 33);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(570, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 33);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Wallpaper
            // 
            this.Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("Wallpaper.Image")));
            this.Wallpaper.Location = new System.Drawing.Point(0, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(793, 311);
            this.Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wallpaper.TabIndex = 14;
            this.Wallpaper.TabStop = false;
            // 
            // floor
            // 
            this.floor.Image = ((System.Drawing.Image)(resources.GetObject("floor.Image")));
            this.floor.Location = new System.Drawing.Point(-2, 290);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(790, 25);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 19;
            this.floor.TabStop = false;
            // 
            // tutor1
            // 
            this.tutor1.AutoSize = true;
            this.tutor1.BackColor = System.Drawing.Color.Transparent;
            this.tutor1.Location = new System.Drawing.Point(9, 293);
            this.tutor1.Name = "tutor1";
            this.tutor1.Size = new System.Drawing.Size(223, 13);
            this.tutor1.TabIndex = 12;
            this.tutor1.Text = "A : Left | D : Jump | W : Right | Space : Attack";
            // 
            // tutor2
            // 
            this.tutor2.AutoSize = true;
            this.tutor2.BackColor = System.Drawing.Color.Transparent;
            this.tutor2.Location = new System.Drawing.Point(587, 293);
            this.tutor2.Name = "tutor2";
            this.tutor2.Size = new System.Drawing.Size(190, 13);
            this.tutor2.TabIndex = 13;
            this.tutor2.Text = "< : Left | > : Right | ^ : Jump | 0 : Attack";
            // 
            // bgSound
            // 
            this.bgSound.Enabled = true;
            this.bgSound.Location = new System.Drawing.Point(0, 313);
            this.bgSound.Name = "bgSound";
            this.bgSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bgSound.OcxState")));
            this.bgSound.Size = new System.Drawing.Size(212, 48);
            this.bgSound.TabIndex = 14;
            this.bgSound.Visible = false;
            // 
            // runSound
            // 
            this.runSound.Enabled = true;
            this.runSound.Location = new System.Drawing.Point(218, 313);
            this.runSound.Name = "runSound";
            this.runSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("runSound.OcxState")));
            this.runSound.Size = new System.Drawing.Size(218, 48);
            this.runSound.TabIndex = 15;
            this.runSound.Visible = false;
            // 
            // jumpSound
            // 
            this.jumpSound.Enabled = true;
            this.jumpSound.Location = new System.Drawing.Point(442, 313);
            this.jumpSound.Name = "jumpSound";
            this.jumpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("jumpSound.OcxState")));
            this.jumpSound.Size = new System.Drawing.Size(215, 48);
            this.jumpSound.TabIndex = 16;
            this.jumpSound.Visible = false;
            // 
            // hitSound
            // 
            this.hitSound.Enabled = true;
            this.hitSound.Location = new System.Drawing.Point(0, 367);
            this.hitSound.Name = "hitSound";
            this.hitSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("hitSound.OcxState")));
            this.hitSound.Size = new System.Drawing.Size(212, 46);
            this.hitSound.TabIndex = 17;
            this.hitSound.Visible = false;
            // 
            // painSound
            // 
            this.painSound.Enabled = true;
            this.painSound.Location = new System.Drawing.Point(218, 367);
            this.painSound.Name = "painSound";
            this.painSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("painSound.OcxState")));
            this.painSound.Size = new System.Drawing.Size(218, 46);
            this.painSound.TabIndex = 18;
            this.painSound.Visible = false;
            // 
            // MyRockman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 313);
            this.Controls.Add(this.painSound);
            this.Controls.Add(this.hitSound);
            this.Controls.Add(this.jumpSound);
            this.Controls.Add(this.runSound);
            this.Controls.Add(this.bgSound);
            this.Controls.Add(this.tutor2);
            this.Controls.Add(this.tutor1);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.GameScreen);
            this.Name = "MyRockman";
            this.Text = "7";
            this.Load += new System.EventHandler(this.MyRockman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyRockman_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyRockman_KeyUp);
            this.GameScreen.ResumeLayout(false);
            this.GameScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel GameScreen;
        private System.Windows.Forms.PictureBox Bullet1;
        private System.Windows.Forms.PictureBox Bullet2;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Health1;
        private System.Windows.Forms.PictureBox Health2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label text_PlayerHp2;
        private System.Windows.Forms.Label text_PlayerHp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tutor1;
        private System.Windows.Forms.Label tutor2;
        private System.Windows.Forms.Label text_Name2;
        private System.Windows.Forms.Label text_Name1;
        private System.Windows.Forms.PictureBox Wallpaper;
        private System.Windows.Forms.PictureBox floor;
        private AxWMPLib.AxWindowsMediaPlayer bgSound;
        private AxWMPLib.AxWindowsMediaPlayer runSound;
        private AxWMPLib.AxWindowsMediaPlayer jumpSound;
        private AxWMPLib.AxWindowsMediaPlayer hitSound;
        private AxWMPLib.AxWindowsMediaPlayer painSound;
    }
}

