﻿using System.Drawing;

namespace Ludo
{
    partial class GameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettings));
            this.plrOneCheck = new System.Windows.Forms.CheckBox();
            this.plrTwoCheck = new System.Windows.Forms.CheckBox();
            this.plrThreeCheck = new System.Windows.Forms.CheckBox();
            this.plrFourCheck = new System.Windows.Forms.CheckBox();
            this.plrOneText = new System.Windows.Forms.TextBox();
            this.plrTwoText = new System.Windows.Forms.TextBox();
            this.plrThreeText = new System.Windows.Forms.TextBox();
            this.plrFourText = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plrOneCheck
            // 
            this.plrOneCheck.AutoSize = true;
            this.plrOneCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plrOneCheck.Location = new System.Drawing.Point(42, 30);
            this.plrOneCheck.Name = "plrOneCheck";
            this.plrOneCheck.Size = new System.Drawing.Size(15, 14);
            this.plrOneCheck.TabIndex = 1;
            this.plrOneCheck.UseVisualStyleBackColor = true;
            this.plrOneCheck.CheckedChanged += new System.EventHandler(this.plrOneCheck_CheckedChanged);
            // 
            // plrTwoCheck
            // 
            this.plrTwoCheck.AutoSize = true;
            this.plrTwoCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plrTwoCheck.Location = new System.Drawing.Point(42, 61);
            this.plrTwoCheck.Name = "plrTwoCheck";
            this.plrTwoCheck.Size = new System.Drawing.Size(15, 14);
            this.plrTwoCheck.TabIndex = 2;
            this.plrTwoCheck.UseVisualStyleBackColor = true;
            this.plrTwoCheck.CheckedChanged += new System.EventHandler(this.plrTwoCheck_CheckedChanged);
            // 
            // plrThreeCheck
            // 
            this.plrThreeCheck.AutoSize = true;
            this.plrThreeCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plrThreeCheck.Location = new System.Drawing.Point(42, 95);
            this.plrThreeCheck.Name = "plrThreeCheck";
            this.plrThreeCheck.Size = new System.Drawing.Size(15, 14);
            this.plrThreeCheck.TabIndex = 3;
            this.plrThreeCheck.UseVisualStyleBackColor = true;
            this.plrThreeCheck.CheckedChanged += new System.EventHandler(this.plrThreeCheck_CheckedChanged);
            // 
            // plrFourCheck
            // 
            this.plrFourCheck.AutoSize = true;
            this.plrFourCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plrFourCheck.Location = new System.Drawing.Point(42, 128);
            this.plrFourCheck.Name = "plrFourCheck";
            this.plrFourCheck.Size = new System.Drawing.Size(15, 14);
            this.plrFourCheck.TabIndex = 4;
            this.plrFourCheck.UseVisualStyleBackColor = true;
            this.plrFourCheck.CheckedChanged += new System.EventHandler(this.plrFourCheck_CheckedChanged);
            // 
            // plrOneText
            // 
            this.plrOneText.Location = new System.Drawing.Point(63, 24);
            this.plrOneText.Name = "plrOneText";
            this.plrOneText.Size = new System.Drawing.Size(102, 20);
            this.plrOneText.TabIndex = 5;
            this.plrOneText.Text = "Player 1";
            // 
            // plrTwoText
            // 
            this.plrTwoText.Location = new System.Drawing.Point(63, 58);
            this.plrTwoText.Name = "plrTwoText";
            this.plrTwoText.Size = new System.Drawing.Size(102, 20);
            this.plrTwoText.TabIndex = 6;
            this.plrTwoText.Text = "Player 2";
            // 
            // plrThreeText
            // 
            this.plrThreeText.Location = new System.Drawing.Point(63, 92);
            this.plrThreeText.Name = "plrThreeText";
            this.plrThreeText.Size = new System.Drawing.Size(102, 20);
            this.plrThreeText.TabIndex = 7;
            this.plrThreeText.Text = "Player 3";
            // 
            // plrFourText
            // 
            this.plrFourText.Location = new System.Drawing.Point(63, 125);
            this.plrFourText.Name = "plrFourText";
            this.plrFourText.Size = new System.Drawing.Size(102, 20);
            this.plrFourText.TabIndex = 8;
            this.plrFourText.Text = "Player 4";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(17, 172);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Ludo.Properties.Resources.BtnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(221, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 22);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Ludo.Properties.Resources.BtnStart;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(221, 42);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 22);
            this.btnStart.TabIndex = 14;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::Ludo.Properties.Resources.BtnAbout;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(221, 70);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(66, 22);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.BackgroundImage = global::Ludo.Properties.Resources.PawnBlue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(182, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.BackgroundImage = global::Ludo.Properties.Resources.PawnYellow;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(182, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.BackgroundImage = global::Ludo.Properties.Resources.PawnGreen;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(182, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(182, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(315, 195);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.plrFourText);
            this.Controls.Add(this.plrThreeText);
            this.Controls.Add(this.plrTwoText);
            this.Controls.Add(this.plrOneText);
            this.Controls.Add(this.plrFourCheck);
            this.Controls.Add(this.plrThreeCheck);
            this.Controls.Add(this.plrTwoCheck);
            this.Controls.Add(this.plrOneCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélectionner le nombre de joueurs";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox plrOneCheck;
        private System.Windows.Forms.CheckBox plrTwoCheck;
        private System.Windows.Forms.CheckBox plrThreeCheck;
        private System.Windows.Forms.CheckBox plrFourCheck;
        private System.Windows.Forms.TextBox plrOneText;
        private System.Windows.Forms.TextBox plrTwoText;
        private System.Windows.Forms.TextBox plrThreeText;
        private System.Windows.Forms.TextBox plrFourText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWarning;
    }
}

