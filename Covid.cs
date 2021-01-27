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
    public partial class Covid : Form
    {
        Regex email_regex = new Regex("^[a-zA-Z0-9]+@[a-zA-Z]+[.][a-zA-Z]+$"); //regular expression to check email input

        public Covid()
        {
            InitializeComponent();
        }

        private void Covid_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (email_regex.IsMatch(textBox5.Text))
                pictureBox1.Visible = false;
            else
                pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e) //function for all the pictureboxes
        {
            switch (((PictureBox)sender).Name)
            {
                //case "pictureBox1":


            }


        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox2.MaskFull && (Int32.Parse(maskedTextBox2.Text.Substring(0,2)) > 23 || Int32.Parse(maskedTextBox2.Text.Substring(3, 2)) > 59) || !maskedTextBox2.MaskFull)
                pictureBox4.Visible = true;
            else
                pictureBox4.Visible = false;
        }
    }
}
