using Npgsql;
using System;
using System.Windows.Forms;

namespace БД_Магазина
{
    public partial class Pr_add : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        int result = 0;
        public Pr_add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = String.Format(@"select * from pr_insert('{0}', {1})", textBox1.Text, 0);
            cmd = new NpgsqlCommand(sql, conn);
            result = (int)cmd.ExecuteScalar();
            if (result == 1)
            {
                MessageBox.Show("Продукция успешно добавлена");
                result = 0;
                conn.Close();
            }
            else
            {
                MessageBox.Show("При добавлении произошла ошибка");
                conn.Close();
            }
        }

        private void Pr_add_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring); //https://www.youtube.com/watch?v=U_v1dSglNjE
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
