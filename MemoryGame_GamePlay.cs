using System;
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
        int Timers;
        string Username;

        public MemoryGame_GamePlay(int Timers, string Username)
        {
            InitializeComponent();
            this.Timers   = Timers;
            this.Username = Username;
        }

        private void MemoryGame_GamePlay_Load(object sender, EventArgs e)
        {
            if (Timers == 0)
                labelPlayer.Visible = false;
            else
                timerSeconds.Enabled = true;

            Timers *= 60;
            labelPlayer.Text += Username;

            MemoryGameIcon icon1  = new MemoryGameIcon(pictureBox1);
            MemoryGameIcon icon2  = new MemoryGameIcon(pictureBox2);
            MemoryGameIcon icon3  = new MemoryGameIcon(pictureBox3);
            MemoryGameIcon icon4  = new MemoryGameIcon(pictureBox4);
            MemoryGameIcon icon5  = new MemoryGameIcon(pictureBox5);
            MemoryGameIcon icon6  = new MemoryGameIcon(pictureBox6);
            MemoryGameIcon icon7  = new MemoryGameIcon(pictureBox7);
            MemoryGameIcon icon8  = new MemoryGameIcon(pictureBox8);
            MemoryGameIcon icon9  = new MemoryGameIcon(pictureBox9);
            MemoryGameIcon icon10 = new MemoryGameIcon(pictureBox10);
            MemoryGameIcon icon11 = new MemoryGameIcon(pictureBox11);
            MemoryGameIcon icon12 = new MemoryGameIcon(pictureBox12);
            MemoryGameIcon icon13 = new MemoryGameIcon(pictureBox13);
            MemoryGameIcon icon14 = new MemoryGameIcon(pictureBox14);
            MemoryGameIcon icon15 = new MemoryGameIcon(pictureBox15);
            MemoryGameIcon icon16 = new MemoryGameIcon(pictureBox16);
            MemoryGameIcon icon17 = new MemoryGameIcon(pictureBox17);
            MemoryGameIcon icon18 = new MemoryGameIcon(pictureBox18);
            MemoryGameIcon icon19 = new MemoryGameIcon(pictureBox19);
            MemoryGameIcon icon20 = new MemoryGameIcon(pictureBox20);
            MemoryGameIcon icon21 = new MemoryGameIcon(pictureBox21);
            MemoryGameIcon icon22 = new MemoryGameIcon(pictureBox22);
            MemoryGameIcon icon23 = new MemoryGameIcon(pictureBox23);
            MemoryGameIcon icon24 = new MemoryGameIcon(pictureBox24);

            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
            MemoryGameIcon.RandomizeLocationImages();
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            Timers--;
            labelTime.Text = "Time: " + (Timers < 60 ? Timers.ToString() : TimeSpan.FromSeconds(Timers).ToString().Substring(3));
        }

        private void AnyIconClicked(object sender, EventArgs e)
        {

        }
    }
}
