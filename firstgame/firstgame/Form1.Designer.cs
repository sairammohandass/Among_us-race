namespace firstgame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.lane2 = new System.Windows.Forms.PictureBox();
            this.lane3 = new System.Windows.Forms.PictureBox();
            this.lane1 = new System.Windows.Forms.PictureBox();
            this.lane4 = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::firstgame.Properties.Resources.Screenshot__426__removebg_preview;
            this.player.Location = new System.Drawing.Point(52, 83);
            this.player.Margin = new System.Windows.Forms.Padding(1);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.superman_Click);
            // 
            // lane2
            // 
            this.lane2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lane2.Image = global::firstgame.Properties.Resources.green_among_us;
            this.lane2.Location = new System.Drawing.Point(302, 212);
            this.lane2.Margin = new System.Windows.Forms.Padding(1);
            this.lane2.Name = "lane2";
            this.lane2.Size = new System.Drawing.Size(66, 47);
            this.lane2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane2.TabIndex = 1;
            this.lane2.TabStop = false;
            // 
            // lane3
            // 
            this.lane3.Image = global::firstgame.Properties.Resources.among_us__2_;
            this.lane3.Location = new System.Drawing.Point(430, 308);
            this.lane3.Margin = new System.Windows.Forms.Padding(2);
            this.lane3.Name = "lane3";
            this.lane3.Size = new System.Drawing.Size(64, 56);
            this.lane3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane3.TabIndex = 2;
            this.lane3.TabStop = false;
            // 
            // lane1
            // 
            this.lane1.Image = ((System.Drawing.Image)(resources.GetObject("lane1.Image")));
            this.lane1.Location = new System.Drawing.Point(420, -5);
            this.lane1.Margin = new System.Windows.Forms.Padding(2);
            this.lane1.Name = "lane1";
            this.lane1.Size = new System.Drawing.Size(74, 62);
            this.lane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane1.TabIndex = 3;
            this.lane1.TabStop = false;
            // 
            // lane4
            // 
            this.lane4.Image = global::firstgame.Properties.Resources.among_us__1_;
            this.lane4.Location = new System.Drawing.Point(302, 385);
            this.lane4.Margin = new System.Windows.Forms.Padding(2);
            this.lane4.Name = "lane4";
            this.lane4.Size = new System.Drawing.Size(66, 59);
            this.lane4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane4.TabIndex = 4;
            this.lane4.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("SimSun", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoretext.Location = new System.Drawing.Point(8, 471);
            this.scoretext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(86, 19);
            this.scoretext.TabIndex = 5;
            this.scoretext.Text = "SCORE:0";
            this.scoretext.Click += new System.EventHandler(this.label1_Click);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-4, 458);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(705, 45);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 502);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lane4);
            this.Controls.Add(this.lane1);
            this.Controls.Add(this.lane3);
            this.Controls.Add(this.lane2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "game1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox player;
        private PictureBox lane2;
        private PictureBox lane3;
        private PictureBox lane1;
        private PictureBox lane4;
        private Label scoretext;
        private PictureBox ground;
        private System.Windows.Forms.Timer gametimer;
    }
}