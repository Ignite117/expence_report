using Npgsql;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NpgsqlConnection con;
        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=YOUR_PASSWORD_HERE; Database=kirbd");
            con.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee fp = new FormEmployee(con);
            fp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRasxod fp = new FormRasxod(con);
            fp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAva fp = new FormAva(con);
            fp.ShowDialog();
        }
    }
}
