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

namespace WinFormsApp1
{
    public partial class AddEmployeeForm : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddEmployeeForm(NpgsqlConnection con, int id)
        {
            this.con = con;
            this.id = id;
            InitializeComponent();
        }
        public AddEmployeeForm(NpgsqlConnection con, int id, string name_em, string phone, string job)
        {
            InitializeComponent();
            textBox1.Text = name_em;
            textBox2.Text = phone;
            textBox3.Text = job;
            this.con = con;
            this.id = id;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Close();
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
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO employees(name_em,phone,job) VALUES (:name_em,:phone,:job)", con);
                    command.Parameters.AddWithValue("name_em", textBox1.Text);
                    command.Parameters.AddWithValue("phone", textBox2.Text);
                    command.Parameters.AddWithValue("job", textBox3.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE employees SET name_em=:name_em, phone=:phone,job=:job  WHERE ID=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name_em", textBox1.Text);
                    command.Parameters.AddWithValue("phone", textBox2.Text);
                    command.Parameters.AddWithValue("job", textBox3.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
        }
    }
}
