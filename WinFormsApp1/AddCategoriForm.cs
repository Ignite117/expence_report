using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddCategoriForm : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddCategoriForm(NpgsqlConnection con, int id)
        {
            this.con = con;
            this.id = id;
            InitializeComponent();
        }
        public AddCategoriForm(NpgsqlConnection con, int id, string name_cat, string unit)
        {
            InitializeComponent();
            textBox1.Text = name_cat;
            textBox2.Text = unit;
            this.con = con;
            this.id = id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO categories(name_cat,unit) VALUES (:name_cat,:unit)", con);
                    command.Parameters.AddWithValue("name_cat", textBox1.Text);
                    command.Parameters.AddWithValue("unit", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE categories SET name_cat=:name_cat, unit=:unit WHERE ID=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name_cat", textBox1.Text);
                    command.Parameters.AddWithValue("unit", textBox2.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
        }
    }
}
