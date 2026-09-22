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
    public partial class FormRasxod : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FormRasxod(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }
        public void Update()
        {
            String sql = "Select*from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Ед.измерения";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRasxod_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoriForm f = new AddCategoriForm(con, -1);
            f.ShowDialog();
            Update();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Хотите удалить?",
                "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                NpgsqlCommand command = new NpgsqlCommand("Delete from categories where ID=:id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                Update();
            }
            else if (result == DialogResult.No) { }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            string name_cat = (string)dataGridView1.CurrentRow.Cells["name_cat"].Value;
            string unit = (string)dataGridView1.CurrentRow.Cells["unit"].Value;
            AddCategoriForm f = new AddCategoriForm(con, id, name_cat, unit);
            f.ShowDialog();
            Update();
        }
    }
}
