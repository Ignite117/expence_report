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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
namespace WinFormsApp1
{
    public partial class FormAva : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataSet ds1 = new DataSet();
        DataTable dt2 = new DataTable();
        DataSet ds2 = new DataSet();
        public FormAva(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private void Update1()
        {
            String sql = "Select advances.ID,advances.date_,advances.amount,employees.name_em,advances.balance FROM advances JOIN employees ON advances.employee_id=employees.ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["date_"].HeaderText = "Дата выдачи";
            dataGridView1.Columns["amount"].HeaderText = "Выданная сумма";
            dataGridView1.Columns["name_em"].HeaderText = "Сотрудник";
            dataGridView1.Columns["balance"].HeaderText = "Остаток";
        }
        private void Update2(int advanceId)
        {
            String sql = "SELECT expenses.ID, expenses.date_, categories.name_cat, expenses.quantity, expenses.amount " +
                 "FROM expenses JOIN categories ON expenses.category_id = categories.ID " +
                 "WHERE expenses.advance_id = @advance_id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("advance_id", advanceId);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds1.Reset();
            da.Fill(ds1);
            dt1 = ds1.Tables[0];
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns["id"].HeaderText = "ID";
            dataGridView2.Columns["date_"].HeaderText = "Дата затраты";
            dataGridView2.Columns["name_cat"].HeaderText = "Категория расхода";
            dataGridView2.Columns["quantity"].HeaderText = "Количество";
            dataGridView2.Columns["amount"].HeaderText = "Потраченная сумма";
        }
        private void Update2()
        {
            String sql = "Select expenses.ID,expenses.date_,categories.name_cat,expenses.quantity,expenses.amount FROM expenses JOIN categories ON expenses.category_id=categories.ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds1.Reset();
            da.Fill(ds1);
            dt1 = ds1.Tables[0];
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns["id"].HeaderText = "ID";
            dataGridView2.Columns["date_"].HeaderText = "Дата затраты";
            dataGridView2.Columns["name_cat"].HeaderText = "Категория расхода";
            dataGridView2.Columns["quantity"].HeaderText = "Количество";
            dataGridView2.Columns["amount"].HeaderText = "Потраченная сумма";
        }
        private void UpdateA()
        {
            string sql = "SELECT id, name_em FROM employees";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds2.Reset();
            da.Fill(ds2);

            dt2 = ds2.Tables[0];

            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "name_em";
            comboBox1.ValueMember = "id";
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAva_Load(object sender, EventArgs e)
        {
            Update1();
            Update2();
            UpdateA();
        }

        private void авансовыйОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAvaForm2 f = new AddAvaForm2(con);
            f.ShowDialog();
            Update1();
        }

        private void расходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            AddExForm f = new AddExForm(con, id);
            f.ShowDialog();
            Update2();
            Update1();
        }

        private void расходыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Хотите удалить?",
               "Подтверждение",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridView2.CurrentRow.Cells["ID"].Value;
                NpgsqlCommand command = new NpgsqlCommand("Delete from expenses where ID=:id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                Update2();
                Update1();
            }
            else if (result == DialogResult.No) { }
        }

        private void авансовыйОтчетToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Хотите удалить?",
               "Подтверждение",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                NpgsqlCommand command = new NpgsqlCommand("Delete from advances where ID=:id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                Update1();
                Update2();
            }
            else if (result == DialogResult.No) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int advanceId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                Update2(advanceId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel CSV|*.csv";
            saveFileDialog.Title = "Сохранить отчет";
            saveFileDialog.FileName = "Авансовые_отчеты.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    sw.WriteLine("АВАНСОВЫЙ ОТЧЕТ");

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                            sw.Write(";");
                    }

                    sw.WriteLine();

                    DataGridViewRow row = dataGridView1.CurrentRow;

                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        sw.Write(row.Cells[j].Value);
                        if (j < dataGridView1.Columns.Count - 1)
                            sw.Write(";");
                    }

                    sw.WriteLine();

                    sw.WriteLine();
                    sw.WriteLine("РАСХОДЫ ПО ВЫБРАННОМУ ОТЧЕТУ");

                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        sw.Write(dataGridView2.Columns[i].HeaderText);
                        if (i < dataGridView2.Columns.Count - 1)
                            sw.Write(";");
                    }

                    sw.WriteLine();

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (!dataGridView2.Rows[i].IsNewRow)
                        {
                            for (int j = 0; j < dataGridView2.Columns.Count; j++)
                            {
                                sw.Write(dataGridView2.Rows[i].Cells[j].Value);
                                if (j < dataGridView2.Columns.Count - 1)
                                    sw.Write(";");
                            }

                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Данные выгружены в Excel");
            }

        }
        private void ReportByEmployees(DateTime date1, DateTime date2)
        {
            string sql =
                "SELECT e.name_em AS \"Сотрудник\", " +
                "COALESCE(SUM(a.amount), 0) AS \"Выдано\", " +
                "COALESCE((SELECT SUM(ex.amount) " +
                "FROM expenses ex " +
                "JOIN advances ad ON ex.advance_id = ad.id " +
                "WHERE ad.employee_id = e.id " +
                "AND ad.date_ BETWEEN @date1 AND @date2), 0) AS \"Потрачено\", " +
                "COALESCE(SUM(a.amount), 0) - " +
                "COALESCE((SELECT SUM(ex.amount) " +
                "FROM expenses ex " +
                "JOIN advances ad ON ex.advance_id = ad.id " +
                "WHERE ad.employee_id = e.id " +
                "AND ad.date_ BETWEEN @date1 AND @date2), 0) AS \"Остаток\" " +
                "FROM employees e " +
                "JOIN advances a ON a.employee_id = e.id " +
                "WHERE a.date_ BETWEEN @date1 AND @date2 " +
                "GROUP BY e.id, e.name_em";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("date1", DateOnly.FromDateTime(date1));
            cmd.Parameters.AddWithValue("date2", DateOnly.FromDateTime(date2));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView3.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("За выбранный период данных нет");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            ReportByEmployees(date1, date2);
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV файл|*.csv";
                saveFileDialog.FileName = "Отчет_за_месяц.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Заголовки
                        for (int i = 0; i < dataGridView3.Columns.Count; i++)
                        {
                            sw.Write(dataGridView3.Columns[i].HeaderText);
                            if (i < dataGridView3.Columns.Count - 1)
                                sw.Write(";");
                        }

                        sw.WriteLine();

                        // Данные
                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                        {
                            if (!dataGridView3.Rows[i].IsNewRow)
                            {
                                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                                {
                                    sw.Write(dataGridView3.Rows[i].Cells[j].Value?.ToString());
                                    if (j < dataGridView3.Columns.Count - 1)
                                        sw.Write(";");
                                }

                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Отчет выгружен в Excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowChart()
        {
            int employeeId = Convert.ToInt32(comboBox1.SelectedValue);

            DateTime startDateTime = new DateTime(dateTimePicker3.Value.Year, dateTimePicker3.Value.Month, 1);
            DateTime endDateTime = dateTimePicker4.Value.Date;

            DateOnly start = DateOnly.FromDateTime(startDateTime);
            DateOnly end = DateOnly.FromDateTime(endDateTime);

            string sql =
                "SELECT d.day::date, " +
                "COALESCE((SELECT SUM(a.amount) FROM advances a " +
                "WHERE a.employee_id = @employee_id " +
                "AND a.date_ BETWEEN @date1 AND d.day::date), 0) - " +
                "COALESCE((SELECT SUM(e.amount) FROM expenses e " +
                "JOIN advances a ON e.advance_id = a.id " +
                "WHERE a.employee_id = @employee_id " +
                "AND e.date_ BETWEEN @date1 AND d.day::date), 0) AS ostatok " +
                "FROM generate_series(@date1::date, @date2::date, interval '1 day') AS d(day) " +
                "ORDER BY d.day::date";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("employee_id", employeeId);
            cmd.Parameters.AddWithValue("date1", start);
            cmd.Parameters.AddWithValue("date2", end);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ChartValues<double> values = new ChartValues<double>();
            List<string> dates = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                DateOnly date = (DateOnly)row[0];
                dates.Add(date.ToString("dd.MM"));

                values.Add(Math.Round(Convert.ToDouble(row[1]), 2));
            }

            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

            cartesianChart1.Series = new SeriesCollection
    {
        new LineSeries
        {
            Title = "Неотчитанные деньги",
            Values = values
        }
    };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Дата",
                Labels = dates
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Сумма",
                LabelFormatter = value => value.ToString("N2")
            });
            cartesianChart1.DisableAnimations = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ShowChart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV файл|*.csv";
                saveFileDialog.FileName = "График_неотчитанные_деньги.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("Дата;Сумма");

                        var series = cartesianChart1.Series[0];
                        var values = series.Values;

                        for (int i = 0; i < values.Count; i++)
                        {
                            string date = cartesianChart1.AxisX[0].Labels[i];
                            string sum = values[i].ToString();

                            sw.WriteLine(date + ";" + sum);
                        }
                    }

                    MessageBox.Show("Данные графика выгружены в Excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    


}
