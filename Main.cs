using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace БД_Магазина
{
    public partial class Main : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private DataTable dtu;
        private DataTable dtp;
        int idu;
        int idp;
        int idu1;
        int idp1;
        int idp2;
        int result = 0;
        int slindx = 0;
        int dlindx = 0;
        int sidu = 0;
        public Main() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring); //https://www.youtube.com/watch?v=U_v1dSglNjE
                SlSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pr = new Product();
            pr.ShowDialog();
        }

        private void Chbd_CheckedChanged(object sender, EventArgs e)
        {
            if (chbd.Checked == true)
                tbprdel.Visible = true;
            else
                tbprdel.Visible = false;

        }

        private void СтатистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Users();
            us.ShowDialog();
        }
        public void SlSelect()
        {
            try
            {
                conn.Open();
                sql = @"select * from sl_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgpr.DataSource = null;
                dgpr.DataSource = dt;
                dgpr.Columns[0].Visible = false;
                dgpr.Columns[1].Visible = false;
                dgpr.Columns[3].Visible = false;
                cbs.DataSource = null;
                sql = @"select * from users";
                cmd = new NpgsqlCommand(sql, conn);
                dtu = new DataTable();
                dtu.Load(cmd.ExecuteReader());
                cbs.Items.Clear();
                for (int i = 0; i < dtu.Rows.Count; i++)
                {
                    cbs.Items.Add(Convert.ToString(dtu.Rows[i].ItemArray.GetValue(1)));
                }
                sidu = dtu.Rows.Count;
                sql = @"select * from product";
                cmd = new NpgsqlCommand(sql, conn);
                dtp = new DataTable();
                dtp.Load(cmd.ExecuteReader());
                cbslpr.Items.Clear(); ;
                for (int i = 0; i < dtp.Rows.Count; i++)
                {
                    cbslpr.Items.Add(Convert.ToString(dtp.Rows[i].ItemArray.GetValue(1)));
                }
                dgpr.ClearSelection();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void DlSelect()
        {
            try
            {
                conn.Open();
                sql = @"select * from dl_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgdel.DataSource = null;
                dgdel.DataSource = dt;
                dgdel.Columns[0].Visible = false;
                dgdel.Columns[1].Visible = false;
                dgdel.Columns[3].Visible = false;
                cbs.DataSource = null;
                sql = @"select * from users";
                cmd = new NpgsqlCommand(sql, conn);
                dtu = new DataTable();
                dtu.Load(cmd.ExecuteReader());
                cbd.Items.Clear();
                for (int i = 0; i < dtu.Rows.Count; i++)
                {
                    cbd.Items.Add(Convert.ToString(dtu.Rows[i].ItemArray.GetValue(1)));
                }
                sql = @"select * from product";
                cmd = new NpgsqlCommand(sql, conn);
                dtp = new DataTable();
                dtp.Load(cmd.ExecuteReader());
                cbprdel.Items.Clear(); ;
                for (int i = 0; i < dtp.Rows.Count; i++)
                {
                    cbprdel.Items.Add(Convert.ToString(dtp.Rows[i].ItemArray.GetValue(1)));
                    idp2 = Convert.ToInt32(dtp.Rows[i].ItemArray.GetValue(0)) + 1;
                }
                dgdel.ClearSelection();
                conn.Close();
                dgdel.ClearSelection();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void updt_Click(object sender, EventArgs e)
        {
            SlSelect();
        }

        private void inssl_Click(object sender, EventArgs e)
        {
            if (idu == 0 | idp == 0 | textBox4.Text == "" | cbslpr.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {

                conn.Open();
                sql = String.Format(@"select * from sl_insert({0}, {1}, {2}, '{3}')", idu, idp, textBox4.Text, dateTimePicker1.Value);
                cmd = new NpgsqlCommand(sql, conn);
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Продажа успешно добавлена");
                    SlSelect();
                    result = 0;
                }
                else
                {
                    MessageBox.Show("При добавлении произошла ошибка");
                }
            }
        }

        private void tbc1_Selected(object sender, TabControlEventArgs e)
        {
            SlSelect();
            DlSelect();
        }

        private void cbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtu.Rows.Count; i++)
            {
                if (cbs.SelectedItem == dtu.Rows[i].ItemArray.GetValue(1))
                {
                    idu = Convert.ToInt32(dtu.Rows[i].ItemArray.GetValue(0));
                }
            }
        }

        private void cbslpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtp.Rows.Count; i++)
            {
                if (cbslpr.SelectedItem == dtp.Rows[i].ItemArray.GetValue(1))
                {
                    idp = Convert.ToInt32(dtp.Rows[i].ItemArray.GetValue(0));
                }
            }
        }

        private void dgpr_Sorted(object sender, EventArgs e)
        {
            dgpr.ClearSelection();
        }

        private void dgpr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slindx = e.RowIndex;
            if (slindx >= 0)
            {
                for (int i = 0; i < cbs.Items.Count; i++)
                {
                    if (cbs.Items[i].ToString() == dgpr.Rows[slindx].Cells[2].Value.ToString())
                    {
                        cbs.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbslpr.Items.Count; i++)
                {
                    if (cbslpr.Items[i].ToString() == dgpr.Rows[slindx].Cells[4].Value.ToString())
                    {
                        cbslpr.SelectedIndex = i;
                    }
                }
                textBox4.Text = Convert.ToString(dgpr.Rows[e.RowIndex].Cells[5].Value);
                dateTimePicker1.Value = Convert.ToDateTime(dgpr.Rows[e.RowIndex].Cells[6].Value);
            }

        }

        private void sluptd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgpr.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберете строку для замены");
                }
                else
                {
                    conn.Open();
                    sql = String.Format(@"select * from sl_update({0}, {1}, {2}, {3}, '{4}')", dgpr[0, slindx].Value, idu, idp, textBox4.Text, dateTimePicker1.Value);
                    cmd = new NpgsqlCommand(sql, conn);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Строка успешно заменена");
                        SlSelect();
                        result = 0;
                    }
                    else
                    {
                        MessageBox.Show("При замене произошла ошибка");
                        conn.Close();
                    }
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Выберете строку для замены");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgpr.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберете строку для удаления");
            }
            else
            {
                conn.Open();
                sql = String.Format(@"select * from sl_delete({0})", dgpr[0, slindx].Value);
                cmd = new NpgsqlCommand(sql, conn);
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Строка успешно удалена");
                    SlSelect();
                    result = 0;
                }
                else
                {
                    MessageBox.Show("При удалении произошла ошибка");
                }
            }
        }

        private void insdel_Click(object sender, EventArgs e)
        {
            if (idu1 == 0 | (idp1 == 0 & tbprdel.Text == "") | textBox8.Text == "")
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {

                conn.Open();
                if (chbd.Checked)
                {
                    sql = String.Format(@"select * from pr_insert('{0}', {1})", tbprdel.Text, 0);
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    sql = String.Format(@"select * from dl_insert({0}, {1}, {2}, '{3}')", idu1, idp2, textBox8.Text, dateTimePicker2.Value);
                    cmd = new NpgsqlCommand(sql, conn);
                }
                else
                {
                    sql = String.Format(@"select * from dl_insert({0}, {1}, {2}, '{3}')", idu1, idp1, textBox8.Text, dateTimePicker2.Value);
                    cmd = new NpgsqlCommand(sql, conn);
                }
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Поставка успешно добавлена");
                    DlSelect();
                    result = 0;
                }
                else
                {
                    MessageBox.Show("При добавлении произошла ошибка");
                }
            }
        }

        private void cbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtu.Rows.Count; i++)
            {
                if (cbd.SelectedItem == dtu.Rows[i].ItemArray.GetValue(1))
                {
                    idu1 = Convert.ToInt32(dtu.Rows[i].ItemArray.GetValue(0));
                }
            }
        }

        private void cbprdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtp.Rows.Count; i++)
            {
                if (cbprdel.SelectedItem == dtp.Rows[i].ItemArray.GetValue(1))
                {
                    idp1 = Convert.ToInt32(dtp.Rows[i].ItemArray.GetValue(0));
                }
            }
        }

        private void deludt_Click(object sender, EventArgs e)
        {
            DlSelect();
        }

        private void deluptd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdel.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберете строку для замены");
                }
                else
                {
                    conn.Open();
                    if (chbd.Checked)
                    {
                        sql = String.Format(@"select * from pr_insert('{0}', {1})", tbprdel.Text, 0);
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        sql = String.Format(@"select * from dl_update({0}, {1}, {2}, {3}, '{4}')", dgdel[0, dlindx].Value, idu1, idp2, textBox8.Text, dateTimePicker2.Value);
                        cmd = new NpgsqlCommand(sql, conn);
                    }
                    else
                    {
                        sql = String.Format(@"select * from dl_update({0}, {1}, {2}, {3}, '{4}')", dgdel[0, dlindx].Value, idu1, idp1, textBox8.Text, dateTimePicker2.Value);
                        cmd = new NpgsqlCommand(sql, conn);
                    }
                    result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show("Строка успешно заменена");
                        conn.Close();
                        DlSelect();
                        result = 0;
                    }
                    else
                    {
                        MessageBox.Show("При замене произошла ошибка");
                        conn.Close();
                        conn.Close();
                    }
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Выберете строку для замены");
            }
        }

        private void dgdel_Sorted(object sender, EventArgs e)
        {
            dgdel.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgdel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберете строку для удаления");
            }
            else
            {
                conn.Open();
                sql = String.Format(@"select * from dl_delete({0})", dgdel[0, dlindx].Value);
                cmd = new NpgsqlCommand(sql, conn);
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Строка успешно удалена");
                    DlSelect();
                    result = 0;
                }
                else
                {
                    MessageBox.Show("При удалении произошла ошибка");
                }
            }
        }

        private void dgdel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dlindx = e.RowIndex;
            if (dlindx >= 0)
            {
                for (int i = 0; i < cbd.Items.Count; i++)
                {
                    if (cbd.Items[i].ToString() == dgdel.Rows[dlindx].Cells[2].Value.ToString())
                    {
                        cbd.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbprdel.Items.Count; i++)
                {
                    if (cbprdel.Items[i].ToString() == dgdel.Rows[dlindx].Cells[4].Value.ToString())
                    {
                        cbprdel.SelectedIndex = i;
                    }
                }
                textBox8.Text = Convert.ToString(dgdel.Rows[e.RowIndex].Cells[5].Value);
                dateTimePicker2.Value = Convert.ToDateTime(dgdel.Rows[e.RowIndex].Cells[6].Value);
            }
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gr = new Grafic();
            gr.ShowDialog();
        }

        private void статистикаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form st = new Statistic();
            st.ShowDialog();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xlsx Files (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                for (int i = 1; i < dgpr.RowCount + 1; i++)
                {
                    for (int j = 1; j < dgpr.ColumnCount + 1; j++)
                    {
                        worksheet.Rows[i].Columns[j] = dgpr.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(sfd.FileName);
                excelapp.Quit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xlsx Files (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                for (int i = 1; i < dgdel.RowCount + 1; i++)
                {
                    for (int j = 1; j < dgdel.ColumnCount + 1; j++)
                    {
                        worksheet.Rows[i].Columns[j] = dgdel.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(sfd.FileName);
                excelapp.Quit();
            }
        }
    }
}
