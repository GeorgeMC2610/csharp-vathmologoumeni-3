using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    public partial class Modify_covid : Form
    {
        String connection_str;
        OleDbConnection connection; //database connection string and connection object

        List<Color> colorlist = new List<Color>() {Color.Red,Color.Blue,Color.Green}; //a color list we are going to use in order to color search results
        int col = 0; //index we are going to use for the list above 

        public Modify_covid()
        {
            InitializeComponent();
        }

        private void Modify_covid_Load(object sender, EventArgs e) //on form load
        {
            comboBox1.SelectedIndex = 0; //select the first element of combobox(Full_name)
            button1.BackColor = button2.BackColor = Color.Silver; //set back color silver(disabled) for the buttons

            //connect to database

            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); 
            connection.Open(); //open database
        }

        private void clearRichTextBoxes()  //clear all the richtextboxes function
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(RichTextBox))
                    ((RichTextBox)c).Clear();
            }
        }

        public void cleartxtbox() //clear textbox1 function
        {
            textBox1.Text = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e) //on picturebox7 click
        {
            Covid_Insert.player.Play(); //play click sound
            Close(); //close this form
        }

        private void comboBox1_TextChanged(object sender, EventArgs e) //on combobox text change
        {
            label3.Text = "Insert the " + comboBox1.Text + " to search cases for"; //modify the label3 text, depending to the chosen combobox value

            clearRichTextBoxes(); //clear all the results from richtextboxes 

            textBox1.Text = ""; //clear the search input 
        }
        private void button1_Click(object sender, EventArgs e) //On modify button click
        {
            Covid_Insert.player.Play(); //play click sound

            //store the chosen line's results from all the richtextboxes to "values" array

            String[] values = {richTextBox1.Lines[(int)numericUpDown1.Value - 1], richTextBox2.Lines[(int)numericUpDown1.Value - 1], richTextBox3.Lines[(int)numericUpDown1.Value - 1],
            richTextBox4.Lines[(int)numericUpDown1.Value - 1],richTextBox5.Lines[(int)numericUpDown1.Value - 1],richTextBox6.Lines[(int)numericUpDown1.Value - 1],
            richTextBox7.Lines[(int)numericUpDown1.Value - 1],richTextBox8.Lines[(int)numericUpDown1.Value - 1],richTextBox9.Lines[(int)numericUpDown1.Value - 1]};

            Covid_Insert ci = new Covid_Insert(values);  //show covid case insert form with overloaded constructor(constructor for modification)
            ci.Show(); 
        }

        private void button2_Click(object sender, EventArgs e) //on Delete button click
        {
            Covid_Insert.player.Play();

            //confirm deletion
            DialogResult choice = MessageBox.Show("Are you sure you want to delete row " + numericUpDown1.Value.ToString() + " from results?", "Delete row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) //if we want to delete a row
            {
                //Make a CovidCase(custom class) object which takes the email from the desirable row we want to delete, as constructor parameter
                CovidCase cov_case = new CovidCase(richTextBox2.Lines[(int)numericUpDown1.Value - 1]); 

                cov_case.deleteCase(); //Delete the report(that has the chosen email) from database 

                String[] lines; //an array on which we are going to store the lines of a rich text box

                //For each richtextbox control
                //1//Store richtextbox's lines at "lines" array
                //2//Delete the desired line from the array
                //3//Clear richtextbox
                //4//Rewrite the lines that are not null from the array back to the richtextbox(each line has a different color)

                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(RichTextBox))
                    {
                        col = 0;

                        lines = ((RichTextBox)c).Lines;
                        lines[(int)numericUpDown1.Value - 1] = "";

                        ((RichTextBox)c).Clear();

                        for (int i = 0; i < lines.Length - 1; i++)
                        {
                            if (!lines[i].Equals(""))
                            {
                                if (col == 3)
                                    col = 0;

                                ((RichTextBox)c).SelectionColor = colorlist[col];
                                ((RichTextBox)c).AppendText(lines[i]);
                                ((RichTextBox)c).AppendText("\n");

                                col++;
                            }
                        }
                    }
                }

                if (numericUpDown1.Maximum != 1) //if we have 1 or more lines after the deletion in a richttextbox, substract one from the maximum value of numericupdown
                    numericUpDown1.Maximum -= 1;
                else
                {
                    button2.Enabled = button1.Enabled = false; //else there is not any line remaining.We disable the delete button and we set the back color to sliver
                    button1.BackColor = button2.BackColor = Color.Silver;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //On every textbox1(search input) text change
        {
            button1.Enabled = button2.Enabled = false; 
            button1.BackColor = button2.BackColor = Color.Silver; //disable the buttons
            numericUpDown1.Maximum = 1; //set numericupdown max = 1

            clearRichTextBoxes(); //clear all the richtextboxes

            //Select the database rows that have the search input's value

            OleDbCommand search = new OleDbCommand("Select * from Covid_cases where "+ comboBox1.Text +" = @txtboxtext",connection);
            search.Parameters.AddWithValue("@txtboxtext", textBox1.Text);            
            OleDbDataReader row = search.ExecuteReader();

            if (row.HasRows) //if reader has rows(if we find results)
            {
                button1.Enabled = button2.Enabled = true;
                button1.BackColor = Color.Bisque;
                button2.BackColor = Color.LightCoral; //enable the buttons

                col = 0;
                int id;

                while (row.Read()) //for each reader row(the row results we found)
                {
                    numericUpDown1.Maximum += 1; //add one to the numeric up down max value

                    if (col == 3)
                        col = 0;

                    foreach (Control c in Controls) //append to each richtextbox the correct row element
                    {
                        if (c.GetType() == typeof(RichTextBox))
                        {
                            id = Int32.Parse(c.Name[11].ToString());
                            ((RichTextBox)c).SelectionColor = colorlist[col];
                            ((RichTextBox)c).AppendText(row[id - 1].ToString());
                            ((RichTextBox)c).AppendText("\n");
                        }

                    }
                    col++;
                }

                numericUpDown1.Maximum -= 1; //because we begin with maximum = 1, after the addition of n lines maximum will be n+1.So we substract one
            }    
        }

       
        private void aboutModificationToolStripMenuItem_Click(object sender, EventArgs e) //About modification option on toolstrip menu 
        {
            Covid_Insert.player.Play();
            MessageBox.Show("After a search for cases(refer in 'About search' option), select the desired row from the search results in the numericupdown control.\n\n" +
            "Press the 'Modify' button in order for the app to transfer you in the report modification form.\n\nThere, you will be requested to modify the selected report values.","About modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutDeleteToolStripMenuItem_Click(object sender, EventArgs e) //About delete option on toolstrip menu 
        {
            Covid_Insert.player.Play();
            MessageBox.Show("After a search for cases(refer in 'About search' option), select the desired row from the search results in the numericupdown control.\n\n" +
            "Press the 'Delete' button and then, choose 'yes' in the confirmation message, in order for the app to delete the selected row from the database.", "About deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutSearchToolStripMenuItem_Click(object sender, EventArgs e) //About search option on toolstrip menu 
        {
            Covid_Insert.player.Play();
            MessageBox.Show("Select in the top combobox, the category you want to search cases by.\nThen, write what you want to look about in the middle textbox.\n\n" +
            "If the application find any row from database that contains what you are looking for, the whole row is beeing added as a result in the bottom richtextboxes.", "About search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Modify_covid_FormClosed(object sender, FormClosedEventArgs e) //on form close
        {
            connection.Close(); //close database connection
            Application.OpenForms[1].Show(); //open the first Covid App form
        }
    }
}
