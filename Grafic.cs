using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace БД_Магазина
{
    public partial class Grafic : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
           "User Id={2}; Password = {3};Database = {4}", "localhost", 5432, "postgres", "5080", "BD");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        int a;
        int[] prid;
        string nl;
        public Grafic()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                dtp1.Value = DateTime.Now - TimeSpan.FromDays(60);
                dtp2.Value = DateTime.Now;
                comboBox1.Items.Add("Вся продукция");
                comboBox1.SelectedIndex = 0;
                conn.Open();
                nl = string.Format("");
                sql = @"select * from product";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                prid = new int[dt.Rows.Count]; ;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(Convert.ToString(dt.Rows[i].ItemArray.GetValue(1)));
                    prid[i] = Convert.ToInt32(dt.Rows[i].ItemArray.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Draw();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Grafic_SizeChanged(object sender, EventArgs e)
        {

        }
        private void Draw()
        {
            conn.Open();
            chart1.Series.Clear();
            chart1.Series.Add("Продано \n Всей продукции\n с " + Convert.ToString(dtp1.Value.ToShortDateString()) + "\n по " + Convert.ToString(dtp2.Value.ToShortDateString()));
            chart1.Series.Add("Продано \n" + comboBox1.SelectedItem + "\n с " + Convert.ToString(dtp1.Value.ToShortDateString()) + "\n по " + Convert.ToString(dtp2.Value.ToShortDateString()));
            chart1.Series[0].IsValueShownAsLabel = true;
            int[] dtsort = new int[8];
            sql = String.Format(@"select quant, EXTRACT(DOW FROM datesl) as DOW from sales 
where {0} datesl between '{1}' and '{2}'
order by DOW", nl, dtp1.Value, dtp2.Value);
            //MessageBox.Show(sql);
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[j].ItemArray.GetValue(1)) == i)
                    {
                        dtsort[i] = dtsort[i] + Convert.ToInt32(dt.Rows[j].ItemArray.GetValue(0));
                    }
                }
                if (a < dtsort[i])
                {
                    a = dtsort[i];
                }
            }
            dtsort[7] = dtsort[0];
            chart1.Series[1].Points.Clear();
            string[] Data = new string[7];
            Data[0] = ("Понедельник");
            Data[1] = ("Вторник");
            Data[2] = ("Cреда");
            Data[3] = ("Четверг");
            Data[4] = ("Пятница");
            Data[5] = ("Суббота");
            Data[6] = ("Воскресенье");
            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(Data[i], dtsort[i + 1]);
                chart1.Series[1].Points.AddXY(Data[i], dtsort[i + 1]);
            }
        }

        private void Grafic_Resize(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                nl = string.Format("");
            }
            else
            {
                nl = string.Format("p_id = {0} and", prid[comboBox1.SelectedIndex - 1]);
            }
            Draw();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
            dtp2.MinDate = dtp1.Value;
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
            dtp1.MaxDate = dtp2.Value;
        }

        private void сохраниьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "JPG Files (*.jpeg)|*.jpeg";
            if (svd.ShowDialog() == DialogResult.OK)
                chart1.SaveImage(svd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
