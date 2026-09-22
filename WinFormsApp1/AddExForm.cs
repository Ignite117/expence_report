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
    public partial class AddExForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int id;
        public AddExForm(NpgsqlConnection con, int id)
        {
            this.con = con;
            this.id = id;
            InitializeComponent();
        }
        private void UpdateE()
        {
            String sql = "Select*from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name_cat";
            comboBox1.ValueMember = "ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddExForm_Load(object sender, EventArgs e)
        {
            UpdateE();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                NpgsqlCommand check = new NpgsqlCommand(
    "SELECT balance FROM advances WHERE id = @id", con);

                check.Parameters.AddWithValue("id", id);

                double balance = Convert.ToDouble(check.ExecuteScalar());
                double amount = Convert.ToDouble(textBox2.Text);

                if (amount > balance)
                {
                    MessageBox.Show("Расход превышает остаток!");
                    return;
                }
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO expenses (advance_id ,category_id,date_,quantity,amount)" +
                    "VALUES(:advance_id,:category_id,:date_,:quantity,:amount)", con);
                DateTime dt = this.dateTimePicker1.Value.Date;
                command.Parameters.AddWithValue("category_id", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("advance_id", id);
                command.Parameters.AddWithValue("date_", dt);
                command.Parameters.AddWithValue("quantity", Convert.ToInt32(textBox1.Text));
                command.Parameters.AddWithValue("amount", Convert.ToDouble(textBox2.Text));
                command.ExecuteNonQuery();
                Close();
            }
             catch { }
        }
    }
}
