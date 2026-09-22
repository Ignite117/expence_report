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
    public partial class AddAvaForm2 : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddAvaForm2(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }
        private void UpdateA()
        {
            String sql = "Select*from employees";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name_em";
            comboBox1.ValueMember = "ID";
        }

        private void AddAvaForm2_Load(object sender, EventArgs e)
        {
            UpdateA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {double amount = Convert.ToDouble(textBox1.Text);
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO advances (employee_id,date_,amount,balance)" +
                    "VALUES(:employee_id,:date_,:amount,:amount)", con);
                DateTime dt = this.dateTimePicker1.Value.Date;
                command.Parameters.AddWithValue("employee_id", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("date_", dt);
                command.Parameters.AddWithValue("amount", Convert.ToDouble( textBox1.Text));
                command.ExecuteNonQuery();
                Close();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
