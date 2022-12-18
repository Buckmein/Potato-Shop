using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace БД_Магазина
{
    public partial class Statistic : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public Statistic()
        {
            InitializeComponent();
            try
            {
                conn = new NpgsqlConnection(connstring); //https://www.youtube.com/watch?v=U_v1dSglNjE
                comboBox1.SelectedIndex = 0;
                sSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message);
            }
        }
        private void sSelect()
        {
            conn.Open();
            sql = string.Format(@"select наименование as Продукция, qw as Продажи from statistic('{0}','{1}') as stat, product
where _id = pr_id
order by qw DESC", dateTimePicker1.Value, dateTimePicker2.Value);
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dg1.DataSource = null;
            dg1.DataSource = dt;
            conn.Close();
            for (int i = 0; (i <= (dg1.Rows.Count - 1)); i++)
            {
                dg1.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Value = dateTimePicker2.Value - TimeSpan.FromDays(7);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Value = dateTimePicker2.Value - TimeSpan.FromDays(30);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Value = dateTimePicker2.Value - TimeSpan.FromDays(365);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sSelect();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            sSelect();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {

        }
    }
}
