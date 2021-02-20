using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Speech.Synthesis;
using System.Media;

namespace csharp_vathmologoumeni_3
{
    public partial class Covid_Insert : Form
    {
        String connection_str;
        OleDbConnection connection; //for database connection

        public static SoundPlayer player = new SoundPlayer("click.wav"); //initialization of SoundPlayer object(sound effect)

        bool insert = true; //if true, form is for insert, else is for modification
        String old_email; //we use this variable to store the old email value during the modification proccess

        Regex email_regex = new Regex("^[a-zA-Z0-9]+@[a-zA-Z]+[.][a-zA-Z]+$"); //regular expression to check email input
        Regex fullname_regex = new Regex("^[a-zA-Z][ a-zA-Z.]*$"); //regular expression to check fullname input
        Regex address_regex = new Regex(@"[^A-Za-z,. \d]+"); //regular expression to check for unwanted characters in home address input

        public Covid_Insert()
        {
            InitializeComponent();
        }

        public Covid_Insert(String[] values) //Constructor for report modification use."values" array contains the values from the case we want to modify
        {
            InitializeComponent();

            old_email = values[1]; //store to the old email variable the constructor email value

            insert = false; //form is for modification

            //Modify form controls to make it seem like modification form

            Text = "Modify covid case report";
            label2.Text = "Please make your changes about the selected covid case";
            label2.BackColor = Color.LightCoral;
            button1.Text = "Modify covid case";
            label1.Visible = pictureBox7.Visible = false;

            textBox1.Text = values[0]; //store full name value to textbox1
            textBox2.Text = values[1]; //store email value to textbox2

            //store one desease at each line in richtextbox(values[2] contains all the deseases in a single string splitted by ',').

            String text = values[2].Replace(", ", "\n");
            richTextBox1.AppendText(text);

            dateTimePicker1.Text = values[3]; //store date value to dateTimePicker1
            maskedTextBox2.Text = values[4]; //store time value to maskedTextBox2
            maskedTextBox1.Text = values[5]; //store phone number value to maskedTextBox1
            textBox3.Text = values[6]; //store home address value to textbox3
            comboBox1.Text = values[7]; //store phone number value to comboBox1
            numericUpDown1.Value = Int32.Parse(values[8]); //store age value to numericUpDown1
        }

        private void Covid_Load(object sender, EventArgs e)
        {
            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); //connect to database

            if (insert) //if form is for insertion
            {
                button1.BackColor = Color.DarkGray; //make the button color look more like is disabled

                DateTime date = DateTime.Now;
                String datetime = date.ToShortTimeString(); //get the current computer time

                if (datetime[1].Equals(':'))
                    datetime = datetime.Insert(0, "0"); //if it has one digit at hours add a "0" at the beginning

                if (datetime.EndsWith("μμ") || datetime.EndsWith("pm")) //if it is not at 24 hour format at 12 to hours
                {
                    String modified_time = (Int32.Parse(datetime.Substring(0, 2)) + 12).ToString();
                    datetime = datetime.Replace(datetime.Substring(0, 2), modified_time);
                }

                datetime = datetime.Substring(0, 5); //get the hours and minutes substring

                maskedTextBox2.Text = datetime; //store the time at maskedTextBox2
            }
            else //if form is for modification
            {
                BackgroundImage = Image.FromFile("images/modify.png"); //change the background image
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e) //function for all the yellow triangle pictureboxes click, except the one that is for the gender
        {
            String pb_name = ((PictureBox)sender).Name.ToString(); //get picturebox name
            int label_number = Int32.Parse(pb_name[10].ToString()) + 2; //get the last digit of picturebox name and add 2 to it
            String labelname = "label" + label_number; //the digit we got is the number of the label which text is the one we want to show 

            foreach(Control c in Controls) //find the label control that matches the name we want to find
            {
                if (c.Name.Equals(labelname))
                {
                    MessageBox.Show("Invalid " + c.Text + " format","Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                                   
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) //function for gender picture box click
        {
            MessageBox.Show("Please choose a gender","Choose gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Covid_TextChanged(object sender, EventArgs e) //function for every textbox/maskedtextbox/combobox/numericupdown text change
        {
            switch (((Control)sender).Name) //depending on the control name we execute the corresponding case
            {
                //for the full name, we check the regex and if it contains double spaces
                //depending on the above, we show or hide the corresponding picturebox

                case "textBox1": 
                    if (fullname_regex.IsMatch(textBox1.Text) && !textBox1.Text.Contains("  "))
                        pictureBox1.Visible = false;
                    else
                        pictureBox1.Visible = true;
                    break;

                //for the email, we check the regex

                case "textBox2":
                    if (email_regex.IsMatch(textBox2.Text))
                        pictureBox2.Visible = false;
                    else
                        pictureBox2.Visible = true;
                    break;

                //for the home address:

                //we check the regex we dont want to match
                //if contains double spaces
                //if starts with space
                //if it's null

                case "textBox3":
                    if (!textBox3.Text.Equals("") && !textBox3.Text.StartsWith(" ") && !textBox3.Text.Contains("  ") && !address_regex.IsMatch(textBox3.Text))
                        pictureBox5.Visible = false;
                    else
                        pictureBox5.Visible = true;
                    break;

                //for the phone number, we check if maskedTextBox1 is full

                case "maskedTextBox1":
                    if (maskedTextBox1.MaskFull)
                        pictureBox4.Visible = false;
                    else
                        pictureBox4.Visible = true;
                    break;

                //for the time, we check if maskedTextBox2 is full and if it is, we check if time has the correct format

                case "maskedTextBox2":
                    if (maskedTextBox2.MaskFull && (Int32.Parse(maskedTextBox2.Text.Substring(0, 2)) > 23 || Int32.Parse(maskedTextBox2.Text.Substring(3, 2)) > 59) || !maskedTextBox2.MaskFull)
                        pictureBox3.Visible = true;
                    else
                        pictureBox3.Visible = false;
                    break;

                //for the gender, if the value changes, thats enough to accept its value

                case"comboBox1":
                    pictureBox6.Visible = false;
                    break;
            }

            //Check all the pictureboxes except the one that is for exit (picturebox7)
            //if at least one is visible, that means at least one detail is incorrect, so we disable the button and we return

            foreach (Control c in Controls) 
            {
                if(c.GetType() == typeof(PictureBox) && c.Visible == true && !c.Name.Equals("pictureBox7"))
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.DarkGray;
                    return;
                }

            }

            //if we dont find any visible picturebox,the details are correct so we enable the button

            button1.Enabled = true;
            button1.BackColor = Color.PaleGreen;
        }

        private void pictureBox7_Click(object sender, EventArgs e) //on picturebox7 click(exit arrow picturebox)
        {
            player.Play();
            Close();
        }

        private void button1_Click(object sender, EventArgs e) //on insert/modify button click
        {
            player.Play();

            //check for email duplicate if we are doing insertion or modification but the old mail is different than the new one
            //we dont want to check for email duplicate if we are doing modification and we dont want to change the email

            if (insert || !insert && !old_email.Equals(textBox2.Text)) 
            {
                connection.Open();

                OleDbCommand check_email = new OleDbCommand("Select Email from Covid_cases where Email=@email", connection);
                check_email.Parameters.AddWithValue("@email", textBox2.Text);
                OleDbDataReader reader = check_email.ExecuteReader();

                if (reader.Read())
                {
                    //if there is already an email that is same with the one that user gave, return

                    MessageBox.Show("There is already a report with email: " + textBox2.Text, "Email already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }

                connection.Close();
            }

            //Make a CovidCase(custom class) object with the user's details as constructor parameters

            CovidCase cov_case = new CovidCase(textBox1.Text, textBox2.Text, richTextBox1.Lines, dateTimePicker1.Text, 
            maskedTextBox2.Text, maskedTextBox1.Text, textBox3.Text, comboBox1.Text, numericUpDown1.Text);

            String text = ""; //text we are going to show depending on the "insert" variale value

            if (insert) //if we are doing insertion
            {
                cov_case.insertCase(); //insert report into database            
                text = "Report has been successfully added!";

            }
            else //if we are doing modification 
            {               
                cov_case.updateCase(old_email); //update the report with the old email in database
                old_email = textBox2.Text; //set as old email the changed email
                text = "Report has been successfully modified!";
                
                ((Modify_covid)Application.OpenForms[2]).cleartxtbox(); //clear input on search and modify form
            }   

            try //try to select a certain voice and tell the results
            {
                SpeechSynthesizer engine = new SpeechSynthesizer();
                
                engine.SelectVoice("Microsoft Mark");
                engine.SpeakAsync(text);
            }
            catch (Exception) //if exception occurs, print something in console
            {
                Console.WriteLine("There is no such voice.");
            }

            MessageBox.Show(text, "Success");
        }       


        private void aboutValuesToolStripMenuItem_Click(object sender, EventArgs e) //About values option in menustrip
        {
            player.Play();

            MessageBox.Show("Acceptable formats for each value:\n\nFullname: Only letters,comas and fullstops with space between them(double space is not accepted)\n\n" +
            "Email: xxx@yyy.yyy where x = letters or numbers and y = letters\n\nUnderlying diseases: No restrictions\n\nDate of record: Any selected date\n\n" +
            "Time of record: A correct time format(hours are represented from 00-23)\n\nPhone number: Only numbers\n\nHome address: Only letters,comas,fullstops and numbers with space between them(double space is not accepted)\n\n" +
            "Gender: Any selected gender\n\nAge: Any age between 1-100", "Acceptable formats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Covid_Insert_FormClosed(object sender, FormClosedEventArgs e) //on form close
        {
            if (insert) //if we are doing insertion, we show the first Covid app form
                Application.OpenForms[1].Show();   
        }
    }
}
