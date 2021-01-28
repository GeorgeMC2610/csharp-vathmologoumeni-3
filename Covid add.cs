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

namespace csharp_vathmologoumeni_3
{
    public partial class Covid_Insert : Form
    {
        Regex email_regex = new Regex("^[a-zA-Z0-9]+@[a-zA-Z]+[.][a-zA-Z]+$"); //regular expression to check email input
        Regex fullname_regex = new Regex("^[a-zA-Z][ a-zA-Z]*$");
        Regex address_regex = new Regex(@"^[a-zA-Z][ a-zA-Z]*\d*$");
        public Covid_Insert()
        {
            InitializeComponent();
        }

        private void Covid_Load(object sender, EventArgs e)
        {
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
                    if (address_regex.IsMatch(textBox3.Text))
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
                    if(comboBox1.Text.Equals("Choose"))
                        pictureBox6.Visible = true;
                    else
                        pictureBox6.Visible = false;
                    break;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Covid_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }
    }
}
