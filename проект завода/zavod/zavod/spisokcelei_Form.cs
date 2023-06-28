using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavod
{
    public partial class spisokcelei_Form : Form
    {
        public spisokcelei_Form()
        {
            InitializeComponent();
        }

        private void spisokcelei_Form_Load(object sender, EventArgs e)
        {
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.comp". При необходимости она может быть перемещена или удалена.
            this.compTableAdapter.Fill(this.zavidDataSet1.comp);
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "Select * From dbo.celii a   Order by a.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            //foreach(DataTable dt in ds.Tables){
            //    foreach (DataColumn column  in dt.Columns)
            //    {
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            var cells = row.ItemArray;

            //        }
            //    }
            //}

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var delete = "Delete from celii where celi_id='" + del_text_box.Text + "'";
             
            var dataAdapter = new SqlDataAdapter(delete, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;

            con.Close();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec createceli '" + name_celi_textbox.Text + "'," + number_celi_textbox.Text + "", con);
            //cmd.ExecuteNonQuery();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("готово");
            }
            else
            {
                MessageBox.Show("error");
            }

            con.Close();
        }

        private void refresh_upd_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var delete = "exec update ('" + new_name_txt.Text + "','" + new_numb_txt.Text + "')";

            var dataAdapter = new SqlDataAdapter(delete, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;

            con.Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workessForm workerss = new workessForm();

            workerss.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            del_text_box.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            new_name_txt.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            new_numb_txt.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["celi_id"].Visible = false;
        }
    }
}
