using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace БД_Магазина
{
    public partial class Product : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        //int prindx;
        //int result = 0;
        //bool un = true;
        public Product()
        {
            InitializeComponent();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                PrSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message);
            }

        }
        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void PrSelect()
        {
            conn.Open();
            sql = @"select pr_id, наименование as ""Продукция"", coalesce((select * from sl_sum(pr_id)),0) as ""Всего кг продано"",
coalesce((select * from del_sum(pr_id)), 0) as ""Всего кг поставлено"", 
(coalesce(qua, 0)
 - coalesce((select * from sl_sum(pr_id)), 0)
 + coalesce((select * from del_sum(pr_id)), 0)) as ""Всего кг на складе"" from product";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgpr.DataSource = null;
            dgpr.DataSource = dt;
            dgpr.Columns[0].Visible = false;
            conn.Close();
            dgpr.ClearSelection();
        }
        private void dgpr_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgpr_Sorted(object sender, EventArgs e)
        {
            dgpr.ClearSelection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PrSelect();
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
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form pradd = new Pr_add();
            pradd.ShowDialog();
        }
    }
}
