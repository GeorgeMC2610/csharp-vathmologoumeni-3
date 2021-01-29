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

        Regex email_regex = new Regex("^[a-zA-Z0-9]+@[a-zA-Z]+[.][a-zA-Z]+$"); //regular expression to check email input
        Regex fullname_regex = new Regex("^[a-zA-Z][ a-zA-Z]*$");
        Regex address_regex = new Regex(@"[^A-Za-z \d]+");

        public Covid_Insert()
        {
            InitializeComponent();
        }

        private void Covid_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;

            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); //connect to database
            
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
                    if (fullname_regex.IsMatch(textBox1.Text))
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
            OleDbCommand comand = new OleDbCommand("Insert into Covid_cases(Full_name,Email,Underlying_diseases,Date_of_record,Time_of_record,Phone_number,Home_address,Gender,Age) values(@fn,@email,@ud,@dor,@tor,@pn,@ha,@gender,@age)",connection);
            
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
            comand.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Report has been successfully added!");
        }

        private void Covid_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }
    }
}
