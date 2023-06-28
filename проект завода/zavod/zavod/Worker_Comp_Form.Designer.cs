
namespace zavod
{
    partial class Worker_Comp_Form
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavidDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavidDataSet1 = new zavod.zavidDataSet();
            this.refresh_but = new System.Windows.Forms.Button();
            this.ceheTableAdapter = new zavod.zavidDataSetTableAdapters.ceheTableAdapter();
            this.compTableAdapter = new zavod.zavidDataSetTableAdapters.compTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.назадToolStripMenuItem.Text = "главная";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ceheBindingSource
            // 
            this.ceheBindingSource.DataMember = "cehe";
            this.ceheBindingSource.DataSource = this.zavidDataSet1BindingSource;
            // 
            // zavidDataSet1BindingSource
            // 
            this.zavidDataSet1BindingSource.DataSource = this.zavidDataSet1;
            this.zavidDataSet1BindingSource.Position = 0;
            // 
            // zavidDataSet1
            // 
            this.zavidDataSet1.DataSetName = "zavidDataSet";
            this.zavidDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh_but
            // 
            this.refresh_but.Location = new System.Drawing.Point(897, 40);
            this.refresh_but.Name = "refresh_but";
            this.refresh_but.Size = new System.Drawing.Size(104, 32);
            this.refresh_but.TabIndex = 0;
            this.refresh_but.Text = "обновить";
            this.refresh_but.UseVisualStyleBackColor = true;
            this.refresh_but.Click += new System.EventHandler(this.refresh_but_Click);
            // 
            // ceheTableAdapter
            // 
            this.ceheTableAdapter.ClearBeforeFill = true;
            // 
            // compTableAdapter
            // 
            this.compTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 64);
            this.button1.TabIndex = 54;
            this.button1.Text = "процент выполнения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(984, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(931, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 56;
            this.textBox2.Visible = false;
            // 
            // Worker_Comp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.refresh_but);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Worker_Comp_Form";
            this.Text = "Форма для работника";
            this.Load += new System.EventHandler(this.Worker_Comp_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavidDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button refresh_but;
        private zavidDataSet zavidDataSet1;
        private System.Windows.Forms.BindingSource zavidDataSet1BindingSource;
        private zavidDataSetTableAdapters.ceheTableAdapter ceheTableAdapter;
        private zavidDataSetTableAdapters.compTableAdapter compTableAdapter;
        private System.Windows.Forms.BindingSource ceheBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}