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

namespace csharp_vathmologoumeni_3
{
    public partial class Covid_Insert : Form
    {
        String connection_str;
        OleDbConnection connection;

        bool insert = true;
        String old_email;

        Regex email_regex = new Regex("^[a-zA-Z0-9]+@[a-zA-Z]+[.][a-zA-Z]+$"); //regular expression to check email input
        Regex fullname_regex = new Regex("^[a-zA-Z][ a-zA-Z.]*$");
        Regex address_regex = new Regex(@"[^A-Za-z,. \d]+");

        public Covid_Insert()
        {
            InitializeComponent();
        }

        public Covid_Insert(String[] values) //Constructor for report modification use
        {
            InitializeComponent();

            old_email = values[1];

            insert = false;

            Text = "Modify covid case report";
            label2.Text = "Please make your changes about the selected covid case";
            label2.BackColor = Color.LightCoral;
            button1.Text = "Modify covid case";
            label1.Visible = pictureBox7.Visible = false;

            textBox1.Text = values[0];
            textBox2.Text = values[1];
            
            String text = values[2];
            text = text.Replace(", ", "\n");
            richTextBox1.AppendText(text);

            dateTimePicker1.Text = values[3];
            maskedTextBox2.Text = values[4];
            maskedTextBox1.Text = values[5];
            textBox3.Text = values[6];
            comboBox1.Text = values[7];
            numericUpDown1.Value = Int32.Parse(values[8]);
        }

        private void Covid_Load(object sender, EventArgs e)
        {
            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); //connect to database

            if (insert)
            {
                button1.BackColor = Color.DarkGray;

                DateTime date = DateTime.Now;
                String datetime = date.ToShortTimeString();

                if (datetime[1].Equals(':'))
                    datetime = datetime.Insert(0, "0");

                if (datetime.EndsWith("μμ") || datetime.EndsWith("pm"))
                {
                    String modified_time = (Int32.Parse(datetime.Substring(0, 2)) + 12).ToString();
                    datetime = datetime.Replace(datetime.Substring(0, 2), modified_time);
                }

                datetime = datetime.Substring(0, 5);

                maskedTextBox2.Text = datetime;
            }
            
        }

        private void databaseFunction(bool is_insertion)
        {
            OleDbCommand comand;

            if (is_insertion)
            {
                comand = new OleDbCommand("Insert into Covid_cases(Full_name,Email,Underlying_diseases,Date_of_record," +
                "Time_of_record,Phone_number,Home_address,Gender,Age) values(@fn,@email,@ud,@dor,@tor,@pn,@ha,@gender,@age)", connection);
            }
            else
            {
                comand = new OleDbCommand("Update Covid_cases set Full_name = @fn, Email = @email, Underlying_diseases=@ud, Date_of_record=@dor, " +
                "Time_of_record=@tor, Phone_number=@pn, Home_address=@ha, Gender=@gender, Age=@age where Email = @oldemail", connection);
            }

            comand.Parameters.AddWithValue("@fn", textBox1.Text);
            comand.Parameters.AddWithValue("@email", textBox2.Text);

            String[] lines = richTextBox1.Lines;
            StringBuilder diseases = new StringBuilder("");

            if (lines.Length != 0)
            {
                foreach (String line in lines)
                {
                    diseases.Append(line);
                    diseases.Append(", ");
                }
                diseases.Remove(diseases.Length - 2, 2);
            }
            else
                diseases.Append("none");

            comand.Parameters.AddWithValue("@ud", diseases.ToString());
            comand.Parameters.AddWithValue("@dor", dateTimePicker1.Text);
            comand.Parameters.AddWithValue("@tor", maskedTextBox2.Text);
            comand.Parameters.AddWithValue("@pn", maskedTextBox1.Text);
            comand.Parameters.AddWithValue("@ha", textBox3.Text);
            comand.Parameters.AddWithValue("@gender", comboBox1.Text);
            comand.Parameters.AddWithValue("@age", numericUpDown1.Text);

            if (!is_insertion)
            {
                comand.Parameters.AddWithValue("@oldemail", old_email);
                old_email = textBox2.Text;

                MessageBox.Show("Report has been successfully modified!", "Success");

                ((Modify_covid)Application.OpenForms[2]).cleartxtbox();
            }
            else
                MessageBox.Show("Report has been successfully added!", "Success");

            comand.ExecuteNonQuery();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //function for all the pictureboxes
        {
            String pb_name = ((PictureBox)sender).Name.ToString(); //get picturebox name
            int label_number = Int32.Parse(pb_name[10].ToString()) + 2; //get last digit of picturebox name and add 2 to it
            String labelname = "label" + label_number; //the digit we got is the number of the label which text is the one we want to show 

            foreach(Control c in Controls)
            {
                if (c.Name.Equals(labelname))
                {
                    MessageBox.Show("Invalid " + c.Text + " format");
                    break;
                }
                                   
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose a gender");
        }

        private void Covid_TextChanged(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case("textBox1"):
                    if (fullname_regex.IsMatch(textBox1.Text) && !textBox1.Text.Contains("  "))
                        pictureBox1.Visible = false;
                    else
                        pictureBox1.Visible = true;
                    break;

                case("textBox2"):
                    if (email_regex.IsMatch(textBox2.Text))
                        pictureBox2.Visible = false;
                    else
                        pictureBox2.Visible = true;
                    break;

                case("textBox3"):
                    if (!textBox3.Text.Equals("") && !textBox3.Text.StartsWith(" ") && !textBox3.Text.Contains("  ") && !address_regex.IsMatch(textBox3.Text))
                        pictureBox5.Visible = false;
                    else
                        pictureBox5.Visible = true;
                    break;

                case("maskedTextBox1"):
                    if (maskedTextBox1.MaskFull)
                        pictureBox4.Visible = false;
                    else
                        pictureBox4.Visible = true;
                    break;

                case("maskedTextBox2"):
                    if (maskedTextBox2.MaskFull && (Int32.Parse(maskedTextBox2.Text.Substring(0, 2)) > 23 || Int32.Parse(maskedTextBox2.Text.Substring(3, 2)) > 59) || !maskedTextBox2.MaskFull)
                        pictureBox3.Visible = true;
                    else
                        pictureBox3.Visible = false;
                    break;

                case("comboBox1"):
                    pictureBox6.Visible = false;
                    break;
            }

            foreach (Control c in Controls)
            {
                if(c.GetType() == typeof(PictureBox) && c.Visible == true && !c.Name.Equals("pictureBox7"))
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.DarkGray;
                    return;
                }

            }

            button1.Enabled = true;
            button1.BackColor = Color.PaleGreen;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            //check for email duplicate if we are doing insertion or modification but the old mail is different than the new one

            if (insert || !insert && !old_email.Equals(textBox2.Text)) 
            {
                OleDbCommand check_email = new OleDbCommand("Select Email from Covid_cases where Email=@email", connection);
                check_email.Parameters.AddWithValue("@email", textBox2.Text);
                OleDbDataReader reader = check_email.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("There is already a report with email: " + textBox2.Text, "Email already exists");
                    connection.Close();
                    return;
                }
            }

            connection.Close();

            //EDW ALLAZEI SOBARA /////////////////////////////////////////////////////////////////////////////////////////////////////

            //databaseFunction(insert); //if insert = true we are doing insertion else modification

            CovidCase cov_case = new CovidCase(textBox1.Text, textBox2.Text, richTextBox1.Lines, dateTimePicker1.Text, 
            maskedTextBox2.Text, maskedTextBox1.Text, textBox3.Text, comboBox1.Text, numericUpDown1.Text);

            if (insert)
            {
                cov_case.insertCase();
                MessageBox.Show("Report has been successfully added!", "Success");
            }
            else
            {
                cov_case.updateCase(old_email);
                old_email = textBox2.Text;
                MessageBox.Show("Report has been successfully modified!", "Success");
                ((Modify_covid)Application.OpenForms[2]).cleartxtbox();
            }



            
        }

        private void aboutValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acceptable formats for each value:\n\nFullname: Only letters,comas and fullstops with space between them(double space is not accepted)\n\n" +
            "Email: xxx@yyy.yyy where x = letters or numbers and y = letters\n\nUnderlying diseases: No restrictions\n\nDate of record: Any selected date\n\n" +
            "Time of record: A correct time format(hours are represented from 00-23)\n\nPhone number: Only numbers\n\nHome address: Only letters,comas,fullstops and numbers with space between them(double space is not accepted)\n\n" +
            "Gender: Any selected gender\n\nAge: Any age between 1-100", "Acceptable formats");
        }

        private void Covid_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (insert)
                Application.OpenForms[1].Show();   
        }
    }
}
