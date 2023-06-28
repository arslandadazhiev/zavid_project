
namespace zavod
{
    partial class celilist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zavidDataSet = new zavod.zavidDataSet();
            this.zavidDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compTableAdapter = new zavod.zavidDataSetTableAdapters.compTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.compBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.celilisttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celiiTableAdapter = new zavod.zavidDataSetTableAdapters.celiiTableAdapter();
            this.celilisttTableAdapter = new zavod.zavidDataSetTableAdapters.celilisttTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ceheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ceheTableAdapter = new zavod.zavidDataSetTableAdapters.ceheTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЦелейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ceheBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.celiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ceheBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celilisttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celiiBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zavidDataSet
            // 
            this.zavidDataSet.DataSetName = "zavidDataSet";
            this.zavidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zavidDataSetBindingSource
            // 
            this.zavidDataSetBindingSource.DataSource = this.zavidDataSet;
            this.zavidDataSetBindingSource.Position = 0;
            // 
            // compBindingSource
            // 
            this.compBindingSource.DataMember = "comp";
            this.compBindingSource.DataSource = this.zavidDataSetBindingSource;
            // 
            // compTableAdapter
            // 
            this.compTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр целей по цехам";
            // 
            // compBindingSource1
            // 
            this.compBindingSource1.DataMember = "comp";
            this.compBindingSource1.DataSource = this.zavidDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 319);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // celilisttBindingSource
            // 
            this.celilisttBindingSource.DataMember = "celilistt";
            this.celilisttBindingSource.DataSource = this.zavidDataSet;
            // 
            // celiiBindingSource
            // 
            this.celiiBindingSource.DataMember = "celii";
            this.celiiBindingSource.DataSource = this.zavidDataSetBindingSource;
            // 
            // celiiTableAdapter
            // 
            this.celiiTableAdapter.ClearBeforeFill = true;
            // 
            // celilisttTableAdapter
            // 
            this.celilisttTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "план(мероприятия)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ceheBindingSource
            // 
            this.ceheBindingSource.DataMember = "cehe";
            this.ceheBindingSource.DataSource = this.zavidDataSetBindingSource;
            // 
            // ceheTableAdapter
            // 
            this.ceheTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.назадToolStripMenuItem.Text = "главная";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникиToolStripMenuItem,
            this.списокЦелейToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.справочникToolStripMenuItem.Text = "справочник";
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.работникиToolStripMenuItem.Text = "работники";
            this.работникиToolStripMenuItem.Click += new System.EventHandler(this.работникиToolStripMenuItem_Click);
            // 
            // списокЦелейToolStripMenuItem
            // 
            this.списокЦелейToolStripMenuItem.Name = "списокЦелейToolStripMenuItem";
            this.списокЦелейToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.списокЦелейToolStripMenuItem.Text = "список целей";
            this.списокЦелейToolStripMenuItem.Click += new System.EventHandler(this.списокЦелейToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.выходToolStripMenuItem.Text = "выход";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ceheBindingSource2;
            this.comboBox1.DisplayMember = "cehe_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "cehe_id";
            // 
            // ceheBindingSource2
            // 
            this.ceheBindingSource2.DataMember = "cehe";
            this.ceheBindingSource2.DataSource = this.zavidDataSetBindingSource;
            // 
            // celiiBindingSource1
            // 
            this.celiiBindingSource1.DataMember = "celii";
            this.celiiBindingSource1.DataSource = this.zavidDataSetBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ceheBindingSource1
            // 
            this.ceheBindingSource1.DataMember = "cehe";
            this.ceheBindingSource1.DataSource = this.zavidDataSetBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(496, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.celilisttBindingSource;
            this.comboBox2.DisplayMember = "cehe_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.ValueMember = "cehe_id";
            // 
            // celilist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "celilist";
            this.Text = "Цели";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celilisttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celiiBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private zavidDataSet zavidDataSet;
        private System.Windows.Forms.BindingSource zavidDataSetBindingSource;
        private System.Windows.Forms.BindingSource compBindingSource;
        private zavidDataSetTableAdapters.compTableAdapter compTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource compBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource celiiBindingSource;
        private zavidDataSetTableAdapters.celiiTableAdapter celiiTableAdapter;
        private System.Windows.Forms.BindingSource celilisttBindingSource;
        private zavidDataSetTableAdapters.celilisttTableAdapter celilisttTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ceheBindingSource;
        private zavidDataSetTableAdapters.ceheTableAdapter ceheTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЦелейToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource celiiBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource ceheBindingSource1;
        private System.Windows.Forms.BindingSource ceheBindingSource2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

