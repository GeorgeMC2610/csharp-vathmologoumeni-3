﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    public partial class MemoryGame_GamePlay : Form
    {
        int Timers, TimeInitial;
        int Endgame = 2;
        int Tries = 0;
        string Username;

        public MemoryGame_GamePlay(int Timers, string Username)
        {
            InitializeComponent();
            this.Timers      = Timers;
            this.TimeInitial = Timers;
            this.Username    = Username;
        }

        private void MemoryGame_GamePlay_Load(object sender, EventArgs e)
        {
            //if the timers variable is zero 
            if (Timers == 0)
                labelTime.Visible = timerSeconds.Enabled = false;
            else
                labelTime.Visible = timerSeconds.Enabled = true;

            //clear all cache variables 
            MemoryGameIcon.AllIcons.Clear();
            MemoryGameIcon.FoundImages = 0;

            //initialize the labels
            Timers *= 60;
            labelPlayer.Text += Username;
            labelTime.Text = "Time: " + (Timers < 60 ? Timers.ToString() : TimeSpan.FromSeconds(Timers).ToString().Substring(3));
            labelWinOrLose.Visible = false;
            labelPairsFound.Text = "Pairs Found: " + MemoryGameIcon.FoundImages.ToString();
            labelTries.Text = "Tries: " + Tries.ToString();

            //initializing variables
            MemoryGameIcon icon1  = new MemoryGameIcon(pictureBox1, "Autumn");
            MemoryGameIcon icon2  = new MemoryGameIcon(pictureBox2, "Autumn");
            MemoryGameIcon icon3  = new MemoryGameIcon(pictureBox3, "Bridge");
            MemoryGameIcon icon4  = new MemoryGameIcon(pictureBox4, "Bridge");
            MemoryGameIcon icon5  = new MemoryGameIcon(pictureBox5, "Feta");
            MemoryGameIcon icon6  = new MemoryGameIcon(pictureBox6, "Feta");
            MemoryGameIcon icon7  = new MemoryGameIcon(pictureBox7, "Kareta Kareta");
            MemoryGameIcon icon8  = new MemoryGameIcon(pictureBox8, "Kareta Kareta");
            MemoryGameIcon icon9  = new MemoryGameIcon(pictureBox9, "Meteora");
            MemoryGameIcon icon10 = new MemoryGameIcon(pictureBox10, "Meteora");
            MemoryGameIcon icon11 = new MemoryGameIcon(pictureBox11, "Pyrgos");
            MemoryGameIcon icon12 = new MemoryGameIcon(pictureBox12, "Pyrgos");
            MemoryGameIcon icon13 = new MemoryGameIcon(pictureBox13, "Santorini");
            MemoryGameIcon icon14 = new MemoryGameIcon(pictureBox14, "Santorini");
            MemoryGameIcon icon15 = new MemoryGameIcon(pictureBox15, "Spring");
            MemoryGameIcon icon16 = new MemoryGameIcon(pictureBox16, "Spring");
            MemoryGameIcon icon17 = new MemoryGameIcon(pictureBox17, "Summer");
            MemoryGameIcon icon18 = new MemoryGameIcon(pictureBox18, "Summer");
            MemoryGameIcon icon19 = new MemoryGameIcon(pictureBox19, "Sunset");
            MemoryGameIcon icon20 = new MemoryGameIcon(pictureBox20, "Sunset");
            MemoryGameIcon icon21 = new MemoryGameIcon(pictureBox21, "Village");
            MemoryGameIcon icon22 = new MemoryGameIcon(pictureBox22, "Village");
            MemoryGameIcon icon23 = new MemoryGameIcon(pictureBox23, "Winter");
            MemoryGameIcon icon24 = new MemoryGameIcon(pictureBox24, "Winter");

            //randomization
            MemoryGameIcon.RandomizeLocationImages();

            //hide the icons from the player in the start.
            MemoryGameIcon.HideAllIcons();
        }


        private void AnyIconClicked(object sender, EventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;

            //we show all icons at first, so that we can do easier tests.
            MemoryGameIcon.ShowAllIcons();

            //get all selected images
            var SelectedImages = (from Icon in MemoryGameIcon.AllIcons where Icon.Selected select Icon).ToList();

            //if there is no other icon selected
            if (SelectedImages.Count == 0)
            {
                //select the clicked icon
                try
                {
                    MemoryGameIcon Clicked = (from Icon in MemoryGameIcon.AllIcons where Icon.DefaultIcon.Image.Equals(picbox.Image) && !Icon.Revealed select Icon).First();
                    Clicked.Selected = true;
                }
                catch (Exception)
                {
                    
                }
                finally
                {
                    //and hide everything else.
                    MemoryGameIcon.HideAllIcons();
                }
            }
            //otherwise we test to see if we have the same icon clicked.
            else
            {
                //get the first image found from the LINQ command.
                MemoryGameIcon PreviousImage = SelectedImages[0];

                try
                {
                    //then get the icon the user clicked
                    MemoryGameIcon Clicked = (from Icon in MemoryGameIcon.AllIcons where Icon.DefaultIcon.Image.Equals(picbox.Image) && !Icon.Revealed select Icon).First();

                    //test to see if the icons have the same name (but not the same picture box, which means that the player hasn't clicked the same picture twice)
                    if (PreviousImage.Name.Equals(Clicked.Name) && PreviousImage.DefaultIcon != Clicked.DefaultIcon)
                    {
                        //and if they do, reveal them.
                        Clicked.Revealed = PreviousImage.Revealed = true;
                        //Increment the found images.
                        MemoryGameIcon.FoundImages++;
                        labelPairsFound.Text = "Pairs Found: " + MemoryGameIcon.FoundImages.ToString();

                        //if the player found all 12 pairs, finish the game with a win.
                        if (MemoryGameIcon.FoundImages == 12)
                            FinishGame(true);

                    }

                    //then deselect the images
                    Clicked.Selected = PreviousImage.Selected = false;

                    //increment the number of tries the user did
                    Tries++;
                    labelTries.Text = "Tries: " + Tries.ToString();
                }
                catch (Exception)
                {

                }
                finally
                {
                    //if something goes wrong, just deselect the images.
                    PreviousImage.Selected = false;
                    MemoryGameIcon.HideAllIcons();
                }
            }
        }

        private void FinishGame(bool WinOrLose)
        {
            //save the game stats
            MemoryGameIO.SaveGame(Username, MemoryGameIcon.FoundImages, Tries, Timers, TimeInitial);

            //first make the label that indicates losing or winning to be visible and disable the timer that counts down the time.
            labelWinOrLose.Visible   = true;
            timerSeconds.Enabled     = false;

            //then  determine what the label should output
            labelWinOrLose.Text      = WinOrLose ? "YOU WON!" : "YOU LOST!";
            labelWinOrLose.ForeColor = WinOrLose ? Color.Green : Color.Red;

            //disable every other control
            foreach (Control c in Controls)
            {
                if (!c.Name.Equals("labelWinOrLose"))
                {
                    c.Enabled = false;
                }
            }

            //reveal all the cards.
            MemoryGameIcon.ShowAllIcons();

            //and give a small countdown before the form closes
            timerEndgame.Enabled = true;            
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            //decrement the time
            Timers--;

            //update the label
            labelTime.Text = "Time: " + (Timers < 60 ? Timers.ToString() : TimeSpan.FromSeconds(Timers).ToString().Substring(3));

            //and if the time ends, finish the game with a loss.
            if (Timers == 0)
                FinishGame(false);
        }

        private void timerEndgame_Tick(object sender, EventArgs e)
        {
            //show the message for just a bit to the player
            Endgame--;

            //and once the player sees the message, return back to the form.
            if (Endgame == 0)
            {
                timerEndgame.Enabled = false;
                
                Close();
            }
        }
        private void MemoryGame_GamePlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMemoryGame().Show();
        }
    }
}
