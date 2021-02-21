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
    public partial class FormMemoryGame : Form
    {
        bool TransitionExit = false;

        public FormMemoryGame()
        {
            InitializeComponent();
        }
        private void FormMemoryGame_Load(object sender, EventArgs e)
        {
            //θέσε το τσεκμποξ να είναι checked και το κουμπί να είναι απενεργοποιημένο (αφού στην αρχή δεν υπάρχει username).
            checkBox1.Checked  = true;
            buttonPlay.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransitionExit = false;
            Close();
        }

        private void FormMemoryGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!TransitionExit)
                Application.OpenForms[0].Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMinutes.Enabled = checkBox1.Checked;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.TextLength == 0)
                buttonPlay.Enabled = false;
            else
                buttonPlay.Enabled = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            new MemoryGame_GamePlay().Show();
            TransitionExit = true;
            Close();
        }
    }
}
