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
            //όταν πατάμε το κουμπί να φύγουμε από την φόρμα, λέμε στο πρόγραμμα να πάει στο κύριο μενού
            TransitionExit = false;
            Close();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //όταν πατάμε το κουμπί να παίξουμε, κλείνουμε τη φόρμα, απλά με τρόπο τέτοιον ώστε να μην πάμε στο κύριο μενού
            new MemoryGame_GamePlay(checkBox1.Checked? (int)numericUpDownMinutes.Value : 0, textBoxUsername.Text).Show();
            TransitionExit = true;
            Close();
        }

        private void FormMemoryGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //υπάρχουν δύο περιπτώσεις όταν κλείνει η φόρμα. Ή πάμε στο κύριο μενού, επειδή ο χρήστης φεύγει, ή πάμε στο παιχνίδι, επειδή ο χρήστης πάτησε το αντίστοιχο κουμπί
            if (!TransitionExit)
                Application.OpenForms[0].Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //αν το τσεκ μποξ έχει τικ, τότε ανοίγουμε και το numericUpDown των λεπτών
            numericUpDownMinutes.Enabled = checkBox1.Checked;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //θα μπορεί να ξεκινήσει κάποιο παιχνίδι, μόνο αν ο χρήστης έχει βάλει username
            if (textBoxUsername.TextLength == 0)
                buttonPlay.Enabled = false;
            else
                buttonPlay.Enabled = true;
        }

    }
}
