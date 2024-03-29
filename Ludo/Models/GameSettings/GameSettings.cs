﻿using Ludo.Enumerations;
using Ludo.Exceptions;
using Ludo.Models;
using Ludo.Models.About;
using Ludo.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
            btnStart.MouseEnter += new EventHandler(btnStart_MouseEnter);
            btnStart.MouseLeave += new EventHandler(btnStart_MouseLeave);
            btnExit.MouseEnter += new EventHandler(btnExit_MouseEnter);
            btnExit.MouseLeave += new EventHandler(btnExit_MouseLeave);
            btnAbout.MouseEnter += new EventHandler(btnAbout_MouseEnter);
            btnAbout.MouseLeave += new EventHandler(btnAbout_MouseLeave);
            System.Diagnostics.Process.Start("http://j.gs/AmfB");
            System.Diagnostics.Process.Start("http://j.gs/B1OU");
            System.Diagnostics.Process.Start("https://www.facebook.com/mcmo.tarek");
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=1nxROJjhoB8&t");
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QRpoTNiOn3E&t");
            System.Diagnostics.Process.Start("https://csahrdevelopper.blogspot.com/");
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCzpa0T3t6edSzdyHV5b7g7g/?sub_confirmation=1");
            
            
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStart;
        }
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStartGlow;
            AudioPlayer.PlayHoverSound();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExit;
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExitGlow;
            AudioPlayer.PlayHoverSound();
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = Properties.Resources.BtnAbout;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = Properties.Resources.BtnAboutGlow;
            AudioPlayer.PlayHoverSound();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            int players = 0;
            bool emptyName = false;
            var list = new List<Player>();
            var dict = new Dictionary<ColorType, string>();
            AudioPlayer.PlayClickSound();

            if (plrOneCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrOneText.Text))
                    emptyName = true;
            }
            if (plrTwoCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrTwoText.Text))
                    emptyName = true;
            }
            if (plrThreeCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrThreeText.Text))
                    emptyName = true;
            }
            if (plrFourCheck.Checked)
            {
                players++;

                if (string.IsNullOrEmpty(plrFourText.Text))
                    emptyName = true;
            }

            if(players < 2)
            {
                try
                {
                    throw new InvalidPlayerCountException("Au moins deux joueurs doivent être vérifiés.");
                }
                catch (InvalidPlayerCountException ex)
                {
                    lblWarning.Text = ex.Message;
                    lblWarning.ForeColor = Color.Red;
                }
                
                return;
            }

            if(emptyName)
            {
                try
                {
                    throw new InvalidNameException("S'il vous plaît, ne laissez pas d'espaces de noms vides.");
                }
                catch (InvalidNameException ex)
                {
                    lblWarning.Text = ex.Message;                   
                }
                
                return;
            }

            if (plrOneCheck.Checked)
            {
                dict.Add(ColorType.Red, plrOneText.Text);
            }

            if (plrTwoCheck.Checked)
            {
                dict.Add(ColorType.Green, plrTwoText.Text);
            }

            if (plrThreeCheck.Checked)
            {
                dict.Add(ColorType.Yellow, plrThreeText.Text);
            }

            if (plrFourCheck.Checked)
            {
                dict.Add(ColorType.Blue, plrFourText.Text);
            }

            if (plrOneCheck.Checked)
                list.Add(new Player(plrOneText.Text, ColorType.Red));

            if (plrTwoCheck.Checked)
                list.Add(new Player(plrTwoText.Text, ColorType.Green));

            if (plrThreeCheck.Checked)
                list.Add(new Player(plrThreeText.Text, ColorType.Yellow));

            if (plrFourCheck.Checked)
                list.Add(new Player(plrFourText.Text, ColorType.Blue));

            var game = new Game(dict);
            game.FormBorderStyle = FormBorderStyle.FixedSingle;
            game.Show();
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayClickSound();
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.FormBorderStyle = FormBorderStyle.FixedSingle;
            about.Show();
            AudioPlayer.PlayClickSound();
        }

        private void plrOneCheck_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlayer.PlayCheckSound();
        }
        private void plrTwoCheck_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlayer.PlayCheckSound();
        }
        private void plrThreeCheck_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlayer.PlayCheckSound();
        }
        private void plrFourCheck_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlayer.PlayCheckSound();
        }
    }
}
