namespace WinFormsApp1
{
    partial class FormAva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            авансовыйОтчетToolStripMenuItem = new ToolStripMenuItem();
            расходыToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            авансовыйОтчетToolStripMenuItem1 = new ToolStripMenuItem();
            расходыToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            авансовыйОтчетToolStripMenuItem2 = new ToolStripMenuItem();
            расходыToolStripMenuItem2 = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView3 = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 453);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(782, 71);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(679, 453);
            dataGridView2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авансовыйОтчетToolStripMenuItem, расходыToolStripMenuItem });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(90, 24);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // авансовыйОтчетToolStripMenuItem
            // 
            авансовыйОтчетToolStripMenuItem.Name = "авансовыйОтчетToolStripMenuItem";
            авансовыйОтчетToolStripMenuItem.Size = new Size(212, 26);
            авансовыйОтчетToolStripMenuItem.Text = "Авансовый отчет";
            авансовыйОтчетToolStripMenuItem.Click += авансовыйОтчетToolStripMenuItem_Click;
            // 
            // расходыToolStripMenuItem
            // 
            расходыToolStripMenuItem.Name = "расходыToolStripMenuItem";
            расходыToolStripMenuItem.Size = new Size(212, 26);
            расходыToolStripMenuItem.Text = "Расходы";
            расходыToolStripMenuItem.Click += расходыToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авансовыйОтчетToolStripMenuItem1, расходыToolStripMenuItem1 });
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(92, 24);
            изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // авансовыйОтчетToolStripMenuItem1
            // 
            авансовыйОтчетToolStripMenuItem1.Name = "авансовыйОтчетToolStripMenuItem1";
            авансовыйОтчетToolStripMenuItem1.Size = new Size(212, 26);
            авансовыйОтчетToolStripMenuItem1.Text = "Авансовый отчет";
            // 
            // расходыToolStripMenuItem1
            // 
            расходыToolStripMenuItem1.Name = "расходыToolStripMenuItem1";
            расходыToolStripMenuItem1.Size = new Size(212, 26);
            расходыToolStripMenuItem1.Text = "Расходы";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авансовыйОтчетToolStripMenuItem2, расходыToolStripMenuItem2 });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(79, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // авансовыйОтчетToolStripMenuItem2
            // 
            авансовыйОтчетToolStripMenuItem2.Name = "авансовыйОтчетToolStripMenuItem2";
            авансовыйОтчетToolStripMenuItem2.Size = new Size(212, 26);
            авансовыйОтчетToolStripMenuItem2.Text = "Авансовый отчет";
            авансовыйОтчетToolStripMenuItem2.Click += авансовыйОтчетToolStripMenuItem2_Click;
            // 
            // расходыToolStripMenuItem2
            // 
            расходыToolStripMenuItem2.Name = "расходыToolStripMenuItem2";
            расходыToolStripMenuItem2.Size = new Size(212, 26);
            расходыToolStripMenuItem2.Text = "Расходы";
            расходыToolStripMenuItem2.Click += расходыToolStripMenuItem2_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 37);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Авансовые отчеты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1090, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Затраты";
            // 
            // button1
            // 
            button1.Location = new Point(1493, 71);
            button1.Name = "button1";
            button1.Size = new Size(246, 118);
            button1.TabIndex = 5;
            button1.Text = "Выгрузить авансовый отчет в Excel ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(767, 662);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(767, 733);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(36, 584);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(672, 395);
            dataGridView3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(767, 791);
            button2.Name = "button2";
            button2.Size = new Size(250, 54);
            button2.TabIndex = 9;
            button2.Text = "Сформировать отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(767, 605);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 10;
            label3.Text = "Укажите период кратный месяцу";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(767, 639);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Начало:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(767, 703);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 12;
            label5.Text = "Конец:";
            // 
            // button3
            // 
            button3.Location = new Point(767, 870);
            button3.Name = "button3";
            button3.Size = new Size(250, 73);
            button3.TabIndex = 13;
            button3.Text = "Выгрузить в Excel сформированный отчет";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 551);
            label6.Name = "label6";
            label6.Size = new Size(473, 20);
            label6.TabIndex = 14;
            label6.Text = "Отчет по работникам с остатками и оборотами денежных средств";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1652, 617);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(1654, 685);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 17;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(1654, 756);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 27);
            dateTimePicker4.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(1654, 809);
            button4.Name = "button4";
            button4.Size = new Size(235, 54);
            button4.TabIndex = 19;
            button4.Text = "Нарисовать График";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1654, 584);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 20;
            label7.Text = "Сотрудник:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1654, 662);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 21;
            label8.Text = "Начало:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1654, 733);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 22;
            label9.Text = "Конец:";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(1057, 584);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(576, 395);
            cartesianChart1.TabIndex = 23;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // button5
            // 
            button5.Location = new Point(1654, 878);
            button5.Name = "button5";
            button5.Size = new Size(235, 56);
            button5.TabIndex = 24;
            button5.Text = "Выгрузить график в Excel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormAva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button5);
            Controls.Add(cartesianChart1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dataGridView3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAva";
            Text = "FormAva";
            Load += FormAva_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem авансовыйОтчетToolStripMenuItem;
        private ToolStripMenuItem расходыToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem авансовыйОтчетToolStripMenuItem1;
        private ToolStripMenuItem расходыToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem авансовыйОтчетToolStripMenuItem2;
        private ToolStripMenuItem расходыToolStripMenuItem2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView3;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label6;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button4;
        private Label label7;
        private Label label8;
        private Label label9;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Button button5;
    }
}