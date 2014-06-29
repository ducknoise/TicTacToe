namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.xPic = new System.Windows.Forms.PictureBox();
            this.oPic = new System.Windows.Forms.PictureBox();
            this.lblAnounce = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblOWins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(79, 230);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(23, 22);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(59, 60);
            this.pb0.TabIndex = 2;
            this.pb0.TabStop = false;
            this.pb0.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(88, 22);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(66, 60);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(161, 22);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(65, 60);
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(23, 88);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(59, 69);
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(88, 88);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(66, 69);
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(160, 88);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(66, 69);
            this.pb5.TabIndex = 7;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(23, 163);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(59, 61);
            this.pb6.TabIndex = 8;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(88, 163);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(66, 61);
            this.pb7.TabIndex = 9;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(160, 163);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(66, 61);
            this.pb8.TabIndex = 10;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // xPic
            // 
            this.xPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xPic.Image = ((System.Drawing.Image)(resources.GetObject("xPic.Image")));
            this.xPic.Location = new System.Drawing.Point(12, 279);
            this.xPic.Name = "xPic";
            this.xPic.Size = new System.Drawing.Size(51, 63);
            this.xPic.TabIndex = 11;
            this.xPic.TabStop = false;
            // 
            // oPic
            // 
            this.oPic.BackColor = System.Drawing.Color.White;
            this.oPic.Image = ((System.Drawing.Image)(resources.GetObject("oPic.Image")));
            this.oPic.Location = new System.Drawing.Point(201, 279);
            this.oPic.Name = "oPic";
            this.oPic.Size = new System.Drawing.Size(52, 63);
            this.oPic.TabIndex = 12;
            this.oPic.TabStop = false;
            // 
            // lblAnounce
            // 
            this.lblAnounce.AutoSize = true;
            this.lblAnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnounce.Location = new System.Drawing.Point(79, 294);
            this.lblAnounce.Name = "lblAnounce";
            this.lblAnounce.Size = new System.Drawing.Size(0, 16);
            this.lblAnounce.TabIndex = 13;
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Location = new System.Drawing.Point(23, 260);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(13, 13);
            this.lblXWins.TabIndex = 14;
            this.lblXWins.Text = "0";
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Location = new System.Drawing.Point(219, 260);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(13, 13);
            this.lblOWins.TabIndex = 15;
            this.lblOWins.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 369);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.lblAnounce);
            this.Controls.Add(this.oPic);
            this.Controls.Add(this.xPic);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox xPic;
        private System.Windows.Forms.PictureBox oPic;
        private System.Windows.Forms.Label lblAnounce;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblOWins;
    }
}

