﻿using System;
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
        int col = 0;

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
            connection.Close();
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
            comboBox1.SelectedIndex = 0;

            connection_str = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;";
            connection = new OleDbConnection(connection_str); //connect to database
            connection.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = false;
            numericUpDown1.Maximum = 1;
            
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(RichTextBox))
                    ((RichTextBox)c).Clear();
            }
            
            OleDbCommand search = new OleDbCommand("Select * from Covid_cases where "+ comboBox1.Text +" = @txtboxtext",connection);
            search.Parameters.AddWithValue("@txtboxtext", textBox1.Text);            
            OleDbDataReader row = search.ExecuteReader();

            if (row.HasRows)
            {
                button1.Enabled = button2.Enabled = true;

                col = 0;
                int id;

                while (row.Read())
                {
                    numericUpDown1.Maximum += 1;

                    if (col == 3)
                        col = 0;

                    foreach (Control c in Controls)
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

                numericUpDown1.Maximum -= 1;
            }    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please make your changes in the column elements bellow. Click ");
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(RichTextBox))
                { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete row "+numericUpDown1.Value.ToString() + " from results?","Test",MessageBoxButtons.YesNo);
            if(choice == DialogResult.Yes)
            {
                OleDbCommand delete = new OleDbCommand("Delete from Covid_cases where Email = @email", connection);
                delete.Parameters.AddWithValue("@email", richTextBox2.Lines[(int)numericUpDown1.Value - 1]);
                delete.ExecuteNonQuery();

                String[] lines;               
                foreach(Control c in Controls)
                {
                    if (c.GetType() == typeof(RichTextBox))
                    {
                        col = 0;

                        lines = ((RichTextBox)c).Lines;
                        lines[(int)numericUpDown1.Value - 1] = "";

                        ((RichTextBox)c).Clear();

                        for (int i = 0; i<lines.Length-1; i++)
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

                if (numericUpDown1.Maximum != 1)
                    numericUpDown1.Maximum -= 1;
                else
                {
                    button2.Enabled = button1.Enabled = false;
                }
                    
            }          
        }     
    }
}
