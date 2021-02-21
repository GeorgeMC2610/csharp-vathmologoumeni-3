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

        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            Timers--;
            labelTime.Text = "Time: " + (Timers < 60 ? Timers.ToString() : TimeSpan.FromSeconds(Timers).ToString().Substring(3));
        }
    }
}
