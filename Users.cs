using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace БД_Магазина
{
    public partial class Users : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
           "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        int prindx;
        int result = 0;
        bool un = true;
        public Users()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Uselect();
        }
        private void Uselect()
        {
            conn.Open();
            sql = @"select * from us_select()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dg.DataSource = null;
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            conn.Close();
            dg.ClearSelection();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prindx = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                tb.Text = Convert.ToString(dg.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void dg_Sorted(object sender, EventArgs e)
        {
            dg.ClearSelection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (tb.Text == Convert.ToString(dg[1, i].Value))
                {
                    un = false;
                }
            }
            if (tb.Text == "")
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (un)
                {
                    conn.Open();
                    sql = String.Format(@"select * from us_insert('{0}')", tb.Text);
                    cmd = new NpgsqlCommand(sql, conn);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Пользователь успешно добавлен");
                        Uselect();
                        result = 0;
                    }
                    else
                    {
                        MessageBox.Show("При добавлении произошла ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем уже есть");
                    un = true;
                }
            }
        }

        private void updt_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберете пользователя для замены");
            }
            else if (tb.Text == "")
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                conn.Open();
                sql = String.Format(@"select * from us_update({0}, '{1}')", dg[0, prindx].Value, tb.Text);
                cmd = new NpgsqlCommand(sql, conn);
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Пользователь успешно заменен");
                    Uselect();
                    result = 0;
                }
                else
                {
                    MessageBox.Show("При замене произошла ошибка");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберете пользователя для удаления");
                }
                else
                {
                    conn.Open();
                    sql = String.Format(@"select * from us_delete({0})", dg[0, prindx].Value);
                    cmd = new NpgsqlCommand(sql, conn);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Пользователь успешно удален");
                        Uselect();
                        result = 0;
                    }
                    else
                    {
                        MessageBox.Show("При удалении произошла ошибка");
                    }
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Ошибка!!! Пользователя нельзя удалить потому что, он оформлял поставки или продажи");
                conn.Close();
            }
        }

        private void obnow_Click(object sender, EventArgs e)
        {
            Uselect();
        }
    }
}
