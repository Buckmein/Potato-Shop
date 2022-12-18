
namespace БД_Магазина
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbslpr = new System.Windows.Forms.ComboBox();
            this.sluptd = new System.Windows.Forms.Button();
            this.cbs = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updt = new System.Windows.Forms.Button();
            this.dgpr = new System.Windows.Forms.DataGridView();
            this.inssl = new System.Windows.Forms.Button();
            this.lb4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbprdel = new System.Windows.Forms.TextBox();
            this.deluptd = new System.Windows.Forms.Button();
            this.cbd = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.deludt = new System.Windows.Forms.Button();
            this.insdel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chbd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dgdel = new System.Windows.Forms.DataGridView();
            this.cbprdel = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tbc1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpr)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::БД_Магазина.Properties.Resources.g;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.графикиToolStripMenuItem,
            this.статистикаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Таблица продукции";
            this.работаСТаблицамиToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.статистикаToolStripMenuItem.Text = "Добавить пользователя";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.СтатистикаToolStripMenuItem_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.графикиToolStripMenuItem.Text = "Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem1
            // 
            this.статистикаToolStripMenuItem1.Name = "статистикаToolStripMenuItem1";
            this.статистикаToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem1.Text = "Статистика";
            this.статистикаToolStripMenuItem1.Click += new System.EventHandler(this.статистикаToolStripMenuItem1_Click);
            // 
            // tbc1
            // 
            this.tbc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc1.Controls.Add(this.tp1);
            this.tbc1.Controls.Add(this.tp2);
            this.tbc1.Location = new System.Drawing.Point(0, 23);
            this.tbc1.Name = "tbc1";
            this.tbc1.SelectedIndex = 0;
            this.tbc1.Size = new System.Drawing.Size(623, 461);
            this.tbc1.TabIndex = 2;
            this.tbc1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbc1_Selected);
            // 
            // tp1
            // 
            this.tp1.BackgroundImage = global::БД_Магазина.Properties.Resources.g;
            this.tp1.Controls.Add(this.button1);
            this.tp1.Controls.Add(this.cbslpr);
            this.tp1.Controls.Add(this.sluptd);
            this.tp1.Controls.Add(this.cbs);
            this.tp1.Controls.Add(this.button4);
            this.tp1.Controls.Add(this.label5);
            this.tp1.Controls.Add(this.dateTimePicker1);
            this.tp1.Controls.Add(this.updt);
            this.tp1.Controls.Add(this.dgpr);
            this.tp1.Controls.Add(this.inssl);
            this.tp1.Controls.Add(this.lb4);
            this.tp1.Controls.Add(this.textBox4);
            this.tp1.Controls.Add(this.lb3);
            this.tp1.Controls.Add(this.lb1);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(615, 435);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Продажи";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(244, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить таблицу ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbslpr
            // 
            this.cbslpr.FormattingEnabled = true;
            this.cbslpr.Location = new System.Drawing.Point(113, 24);
            this.cbslpr.Name = "cbslpr";
            this.cbslpr.Size = new System.Drawing.Size(100, 21);
            this.cbslpr.TabIndex = 1;
            this.cbslpr.SelectedIndexChanged += new System.EventHandler(this.cbslpr_SelectedIndexChanged);
            // 
            // sluptd
            // 
            this.sluptd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sluptd.Location = new System.Drawing.Point(536, 23);
            this.sluptd.Name = "sluptd";
            this.sluptd.Size = new System.Drawing.Size(72, 23);
            this.sluptd.TabIndex = 5;
            this.sluptd.Text = "Заменить";
            this.sluptd.UseVisualStyleBackColor = true;
            this.sluptd.Click += new System.EventHandler(this.sluptd_Click);
            // 
            // cbs
            // 
            this.cbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbs.FormattingEnabled = true;
            this.cbs.Location = new System.Drawing.Point(7, 24);
            this.cbs.Name = "cbs";
            this.cbs.Size = new System.Drawing.Size(100, 21);
            this.cbs.TabIndex = 0;
            this.cbs.SelectedIndexChanged += new System.EventHandler(this.cbs_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(545, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 25, 14, 11, 16, 0);
            // 
            // updt
            // 
            this.updt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updt.Location = new System.Drawing.Point(6, 406);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(72, 23);
            this.updt.TabIndex = 7;
            this.updt.Text = "Обновить";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // dgpr
            // 
            this.dgpr.AllowUserToAddRows = false;
            this.dgpr.AllowUserToDeleteRows = false;
            this.dgpr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpr.Location = new System.Drawing.Point(7, 49);
            this.dgpr.MultiSelect = false;
            this.dgpr.Name = "dgpr";
            this.dgpr.ReadOnly = true;
            this.dgpr.RowHeadersVisible = false;
            this.dgpr.RowTemplate.Height = 25;
            this.dgpr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgpr.Size = new System.Drawing.Size(602, 351);
            this.dgpr.TabIndex = 9;
            this.dgpr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpr_CellClick);
            this.dgpr.Sorted += new System.EventHandler(this.dgpr_Sorted);
            // 
            // inssl
            // 
            this.inssl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inssl.Location = new System.Drawing.Point(431, 23);
            this.inssl.Name = "inssl";
            this.inssl.Size = new System.Drawing.Size(72, 23);
            this.inssl.TabIndex = 4;
            this.inssl.Text = "Ввести";
            this.inssl.UseVisualStyleBackColor = true;
            this.inssl.Click += new System.EventHandler(this.inssl_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(216, 9);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(85, 13);
            this.lb4.TabIndex = 7;
            this.lb4.Text = "Количество, КГ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(219, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(113, 9);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(62, 13);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Продукция";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(7, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(80, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Пользователь";
            // 
            // tp2
            // 
            this.tp2.BackgroundImage = global::БД_Магазина.Properties.Resources.g;
            this.tp2.Controls.Add(this.button2);
            this.tp2.Controls.Add(this.tbprdel);
            this.tp2.Controls.Add(this.deluptd);
            this.tp2.Controls.Add(this.cbd);
            this.tp2.Controls.Add(this.button5);
            this.tp2.Controls.Add(this.deludt);
            this.tp2.Controls.Add(this.insdel);
            this.tp2.Controls.Add(this.label6);
            this.tp2.Controls.Add(this.dateTimePicker2);
            this.tp2.Controls.Add(this.chbd);
            this.tp2.Controls.Add(this.label4);
            this.tp2.Controls.Add(this.label3);
            this.tp2.Controls.Add(this.label1);
            this.tp2.Controls.Add(this.textBox8);
            this.tp2.Controls.Add(this.dgdel);
            this.tp2.Controls.Add(this.cbprdel);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(615, 435);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Поставки";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(235, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbprdel
            // 
            this.tbprdel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbprdel.Location = new System.Drawing.Point(113, 25);
            this.tbprdel.Name = "tbprdel";
            this.tbprdel.Size = new System.Drawing.Size(100, 20);
            this.tbprdel.TabIndex = 1;
            this.tbprdel.Visible = false;
            // 
            // deluptd
            // 
            this.deluptd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deluptd.Location = new System.Drawing.Point(536, 23);
            this.deluptd.Name = "deluptd";
            this.deluptd.Size = new System.Drawing.Size(72, 23);
            this.deluptd.TabIndex = 5;
            this.deluptd.Text = "Заменить";
            this.deluptd.UseVisualStyleBackColor = true;
            this.deluptd.Click += new System.EventHandler(this.deluptd_Click);
            // 
            // cbd
            // 
            this.cbd.FormattingEnabled = true;
            this.cbd.Location = new System.Drawing.Point(7, 24);
            this.cbd.Name = "cbd";
            this.cbd.Size = new System.Drawing.Size(100, 21);
            this.cbd.TabIndex = 0;
            this.cbd.SelectedIndexChanged += new System.EventHandler(this.cbd_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(536, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deludt
            // 
            this.deludt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deludt.Location = new System.Drawing.Point(6, 406);
            this.deludt.Name = "deludt";
            this.deludt.Size = new System.Drawing.Size(72, 23);
            this.deludt.TabIndex = 8;
            this.deludt.Text = "Обновить";
            this.deludt.UseVisualStyleBackColor = true;
            this.deludt.Click += new System.EventHandler(this.deludt_Click);
            // 
            // insdel
            // 
            this.insdel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insdel.Location = new System.Drawing.Point(431, 23);
            this.insdel.Name = "insdel";
            this.insdel.Size = new System.Drawing.Size(72, 23);
            this.insdel.TabIndex = 4;
            this.insdel.Text = "Ввести";
            this.insdel.UseVisualStyleBackColor = true;
            this.insdel.Click += new System.EventHandler(this.insdel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(325, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // chbd
            // 
            this.chbd.AutoSize = true;
            this.chbd.Location = new System.Drawing.Point(113, 51);
            this.chbd.Name = "chbd";
            this.chbd.Size = new System.Drawing.Size(114, 17);
            this.chbd.TabIndex = 6;
            this.chbd.Text = "Новая продукция";
            this.chbd.UseVisualStyleBackColor = true;
            this.chbd.CheckedChanged += new System.EventHandler(this.Chbd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество, КГ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Продукция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пользователь";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(219, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 2;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // dgdel
            // 
            this.dgdel.AllowUserToAddRows = false;
            this.dgdel.AllowUserToDeleteRows = false;
            this.dgdel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdel.Location = new System.Drawing.Point(7, 71);
            this.dgdel.MultiSelect = false;
            this.dgdel.Name = "dgdel";
            this.dgdel.ReadOnly = true;
            this.dgdel.RowHeadersVisible = false;
            this.dgdel.RowTemplate.Height = 25;
            this.dgdel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdel.Size = new System.Drawing.Size(602, 329);
            this.dgdel.TabIndex = 0;
            this.dgdel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdel_CellClick);
            this.dgdel.Sorted += new System.EventHandler(this.dgdel_Sorted);
            // 
            // cbprdel
            // 
            this.cbprdel.FormattingEnabled = true;
            this.cbprdel.Location = new System.Drawing.Point(113, 24);
            this.cbprdel.Name = "cbprdel";
            this.cbprdel.Size = new System.Drawing.Size(100, 21);
            this.cbprdel.TabIndex = 16;
            this.cbprdel.SelectedIndexChanged += new System.EventHandler(this.cbprdel_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::БД_Магазина.Properties.Resources.g;
            this.ClientSize = new System.Drawing.Size(624, 486);
            this.Controls.Add(this.tbc1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpr)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.TabControl tbc1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button updt;
        private System.Windows.Forms.DataGridView dgpr;
        private System.Windows.Forms.Button inssl;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbprdel;
        private System.Windows.Forms.DataGridView dgdel;
        private System.Windows.Forms.CheckBox chbd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button deludt;
        private System.Windows.Forms.Button insdel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbs;
        private System.Windows.Forms.ComboBox cbprdel;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbd;
        private System.Windows.Forms.Button sluptd;
        private System.Windows.Forms.Button deluptd;
        private System.Windows.Forms.ComboBox cbslpr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

