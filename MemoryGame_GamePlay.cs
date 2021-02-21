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

        public MemoryGame_GamePlay(int Timers)
        {
            InitializeComponent();
            this.Timers = Timers;
        }

        private void MemoryGame_GamePlay_Load(object sender, EventArgs e)
        {
            if (Timers == 0)
                label1.Text = "DISABLED TIMERS";
        }
    }
}
