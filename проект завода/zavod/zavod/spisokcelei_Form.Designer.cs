
namespace zavod
{
    partial class spisokcelei_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.number_celi_textbox = new System.Windows.Forms.TextBox();
            this.name_celi_textbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refresh_upd_but = new System.Windows.Forms.Button();
            this.new_numb_txt = new System.Windows.Forms.TextBox();
            this.new_name_txt = new System.Windows.Forms.TextBox();
            this.txtid_cellist = new System.Windows.Forms.TextBox();
            this.txtot_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del_text_box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ceheTableAdapter = new zavod.zavidDataSetTableAdapters.ceheTableAdapter();
            this.compTableAdapter = new zavod.zavidDataSetTableAdapters.compTableAdapter();
            this.zavidDataSet1 = new zavod.zavidDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(427, 58);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 250);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.number_celi_textbox);
            this.tabPage1.Controls.Add(this.name_celi_textbox);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(177, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // number_celi_textbox
            // 
            this.number_celi_textbox.Location = new System.Drawing.Point(32, 90);
            this.number_celi_textbox.Name = "number_celi_textbox";
            this.number_celi_textbox.Size = new System.Drawing.Size(100, 20);
            this.number_celi_textbox.TabIndex = 6;
            this.number_celi_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_celi_textbox
            // 
            this.name_celi_textbox.Location = new System.Drawing.Point(32, 22);
            this.name_celi_textbox.Name = "name_celi_textbox";
            this.name_celi_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_celi_textbox.TabIndex = 5;
            this.name_celi_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(748, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refresh_upd_but);
            this.tabPage2.Controls.Add(this.new_numb_txt);
            this.tabPage2.Controls.Add(this.new_name_txt);
            this.tabPage2.Controls.Add(this.txtid_cellist);
            this.tabPage2.Controls.Add(this.txtot_id);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(177, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refresh_upd_but
            // 
            this.refresh_upd_but.Location = new System.Drawing.Point(54, 182);
            this.refresh_upd_but.Name = "refresh_upd_but";
            this.refresh_upd_but.Size = new System.Drawing.Size(75, 23);
            this.refresh_upd_but.TabIndex = 44;
            this.refresh_upd_but.Text = "обновить";
            this.refresh_upd_but.UseVisualStyleBackColor = true;
            this.refresh_upd_but.Click += new System.EventHandler(this.refresh_upd_but_Click);
            // 
            // new_numb_txt
            // 
            this.new_numb_txt.Location = new System.Drawing.Point(38, 88);
            this.new_numb_txt.Name = "new_numb_txt";
            this.new_numb_txt.Size = new System.Drawing.Size(100, 20);
            this.new_numb_txt.TabIndex = 43;
            this.new_numb_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_name_txt
            // 
            this.new_name_txt.Location = new System.Drawing.Point(38, 20);
            this.new_name_txt.Name = "new_name_txt";
            this.new_name_txt.Size = new System.Drawing.Size(100, 20);
            this.new_name_txt.TabIndex = 42;
            this.new_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtid_cellist
            // 
            this.txtid_cellist.Location = new System.Drawing.Point(552, 66);
            this.txtid_cellist.Name = "txtid_cellist";
            this.txtid_cellist.Size = new System.Drawing.Size(100, 20);
            this.txtid_cellist.TabIndex = 39;
            // 
            // txtot_id
            // 
            this.txtot_id.Location = new System.Drawing.Point(411, 66);
            this.txtot_id.Name = "txtot_id";
            this.txtot_id.Size = new System.Drawing.Size(100, 20);
            this.txtot_id.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "ot_id";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(759, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 36);
            this.button5.TabIndex = 41;
            this.button5.Text = "сохранить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "id_celi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "id_cellist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "введите id";
            // 
            // del_text_box
            // 
            this.del_text_box.Location = new System.Drawing.Point(463, 327);
            this.del_text_box.Name = "del_text_box";
            this.del_text_box.Size = new System.Drawing.Size(100, 20);
            this.del_text_box.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 31;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 300);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // ceheTableAdapter
            // 
            this.ceheTableAdapter.ClearBeforeFill = true;
            // 
            // compTableAdapter
            // 
            this.compTableAdapter.ClearBeforeFill = true;
            // 
            // zavidDataSet1
            // 
            this.zavidDataSet1.DataSetName = "zavidDataSet";
            this.zavidDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 36;
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
            this.сотрудникиToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.справочникToolStripMenuItem.Text = "справочник";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.сотрудникиToolStripMenuItem.Text = "сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // spisokcelei_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del_text_box);
            this.Controls.Add(this.button2);
            this.Name = "spisokcelei_Form";
            this.Text = "Список целей";
            this.Load += new System.EventHandler(this.spisokcelei_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox number_celi_textbox;
        private System.Windows.Forms.TextBox name_celi_textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button refresh_upd_but;
        private System.Windows.Forms.TextBox new_numb_txt;
        private System.Windows.Forms.TextBox new_name_txt;
        private System.Windows.Forms.TextBox txtid_cellist;
        private System.Windows.Forms.TextBox txtot_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox del_text_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zavidDataSetTableAdapters.ceheTableAdapter ceheTableAdapter;
        private zavidDataSetTableAdapters.compTableAdapter compTableAdapter;
        private zavidDataSet zavidDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}