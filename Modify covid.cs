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
        OleDbConnection connection;
        List<Color> colorlist = new List<Color>() {Color.Red,Color.Blue,Color.Green};

        public Modify_covid()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modify_covid_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Insert the " + comboBox1.Text + " to search cases for";

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(RichTextBox))
                    ((RichTextBox)c).Clear();
            }

            textBox1.Text = "";
        }

        private void Modify_covid_Load(object sender, EventArgs e)
        {
            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); //connect to database
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(RichTextBox))
                    ((RichTextBox)c).Clear();
            }

            connection.Open();

            //CHCECK LATER IF THIS IS NOT NEEDED
            int tmp;
            if (comboBox1.Text.Equals("Age") && !Int32.TryParse(textBox1.Text, out tmp))
            {
                connection.Close();
                return;
            }
                
            OleDbCommand search = new OleDbCommand("Select * from Covid_cases where "+ comboBox1.Text +" = @txtboxtext",connection);
            search.Parameters.AddWithValue("@txtboxtext", textBox1.Text);            
            OleDbDataReader row = search.ExecuteReader();

            int col=0;
            int id;
            while (row.Read())
            {
                if (col == 3)
                    col = 0;

                foreach (Control c in Controls)
                {                   
                    if (c.GetType() == typeof(RichTextBox))
                    {
                        id = Int32.Parse(c.Name[11].ToString());
                        ((RichTextBox)c).SelectionColor = colorlist[col];
                        ((RichTextBox)c).AppendText(row[id-1].ToString());
                        ((RichTextBox)c).AppendText("\n");
                    }
                        
                }
                col++;               
            }

            connection.Close();

        }
    }
}
