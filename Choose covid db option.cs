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
        int old_height; //width,height variables to calculate the difference between form's old hight/width and form's new hight/width after a resize

        public Choose_covid_db_option() //constructor
        {           
            InitializeComponent();           
        }

        private void Choose_covid_db_option_Load(object sender, EventArgs e) //on load
        {
            old_height = this.Height;
            old_width = this.Width; //set the first values for old width/height

            button.Location = new Point((this.Width - button.Width) / 2, this.Height - button.Height - 50); //set button location

            axWindowsMediaPlayer1.URL = "Health Tips To Prevent Coronavirus.mp4"; //load file to player
        }

        private void Choose_covid_db_option_Resize(object sender, EventArgs e) //on resize
        {
            //1//Increase or reduce the width/height of the media player depend on the form resize.
            //2//Change the location of button.

            button.Location = new Point((this.Width - button.Width) / 2, this.Height - button.Height - 50);

            axWindowsMediaPlayer1.Width += this.Width - old_width;
            axWindowsMediaPlayer1.Height += this.Height - old_height; //add the difference between form's old hight/width and form's new hight/width after a resize, in player control

            old_height = this.Height;
            old_width = this.Width;
        }

        private void addCovidCaseReportToolStripMenuItem_Click(object sender, EventArgs e) //Add option in toolstrip menu
        {
            Covid_Insert.player.Play(); //play click sound

            Hide(); //hide this form
            axWindowsMediaPlayer1.Ctlcontrols.pause(); //pause player
            Covid_Insert cov = new Covid_Insert();
            cov.Show(); //show covid case insert form
        }

        private void searchAndModifyCovidCaseToolStripMenuItem_Click(object sender, EventArgs e) //Search and modify option in toolstrip menu
        {
            Covid_Insert.player.Play(); //play click sound

            Hide(); //hide this form
            axWindowsMediaPlayer1.Ctlcontrols.pause(); //pause player
            Modify_covid mc = new Modify_covid();
            mc.Show(); //show covid case insert form
        }
        private void databaseToolStripMenuItem_Click(object sender, EventArgs e) //Database option in toolstrip menu(includes the 2 options above)
        {
            Covid_Insert.player.Play(); //play click sound
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) //Quit option in toolstrip menu
        {
            Covid_Insert.player.Play(); //play click sound

            DialogResult result = MessageBox.Show("Quit covid case reports application?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 

            if (result == DialogResult.Yes) //if quit confirmation is yes, close this form
                Close();

        }

        private void aboutTheApplicationToolStripMenuItem_Click(object sender, EventArgs e) //About option in toolstrip menu
        {
            Covid_Insert.player.Play(); //play click sound

            MessageBox.Show("Welcome to covid case reports application!\n\nSelect 'Database' option in the menustrip, in order to make an insertion or a modification in covid case reports.\n" +
            "More info for the insertion/modification can be found at the corresponding forms.\n\nPress the button bellow to visit the covid cases website.\nThere, you can have a look " +
            "at all case reports and at some statistics about them.\n\nSelect Quit to return back in the applications menu.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button_Click(object sender, EventArgs e) //on button click
        {
            Covid_Insert.player.Play(); //play click sound

            DialogResult result =  MessageBox.Show("Is the Covid_Website project open?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(result == DialogResult.Yes) //if dialog result is yes, open project asp.net website
                System.Diagnostics.Process.Start("https://localhost:44390/WebForm1.aspx"); 
        }

        private void Choose_covid_db_option_FormClosed(object sender, FormClosedEventArgs e) //on form close
        {
            Application.OpenForms[0].Show(); //show first form (application menu)
        }      
    }
}
