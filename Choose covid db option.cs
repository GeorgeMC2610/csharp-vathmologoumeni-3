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
    public partial class Choose_covid_db_option : Form
    {
        int old_width;
        int old_height;

        public Choose_covid_db_option()
        {           
            InitializeComponent();           
        }
        private void Choose_covid_db_option_Load(object sender, EventArgs e)
        {
            old_height = this.Height;
            old_width = this.Width;

            button3.Location = new Point((this.Width - button3.Width) / 2, this.Height - button3.Height - 50);

            axWindowsMediaPlayer1.URL = "Health Tips To Prevent Coronavirus.mp4";
        }

        private void Choose_covid_db_option_Resize(object sender, EventArgs e)
        {
            button3.Location = new Point((this.Width - button3.Width) / 2, this.Height - button3.Height - 50);

            axWindowsMediaPlayer1.Width += this.Width - old_width;
            axWindowsMediaPlayer1.Height += this.Height - old_height;

            old_height = this.Height;
            old_width = this.Width;
        }

        private void addCovidCaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();

            Hide();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Covid_Insert cov = new Covid_Insert();
            cov.Show();
        }

        private void searchAndModifyCovidCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();

            Hide();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Modify_covid mc = new Modify_covid();
            mc.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();

            DialogResult result = MessageBox.Show("Quit covid case reports application?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Close();

        }

        private void aboutTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();
            MessageBox.Show("Welcome to covid case reports application!\n\nSelect 'Database' option in the menustrip, in order to make an insertion or a modification in covid case reports.\n" +
            "More info for the insertion/modification can be found at the corresponding forms.\n\nPress the button bellow to visit the covid cases website.\nThere, you can have a look " +
            "at all case reports and at some statistics about them.\n\nSelect Quit to return back in the applications menu.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();
            MessageBox.Show("You have to open Covid_Website project first.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://localhost:44390/WebForm1.aspx"); 
        }

        private void Choose_covid_db_option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Covid_Insert.player.Play();
        }
    }
}
