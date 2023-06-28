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
    public partial class NAC_create_compForm : Form
    {
        private string id_up_mer;
        public NAC_create_compForm()
        {
            InitializeComponent();
        }

        private void NAC_create_compForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.celilistt". При необходимости она может быть перемещена или удалена.
            this.celilisttTableAdapter.Fill(this.zavidDataSet1.celilistt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.workerss". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.celii". При необходимости она может быть перемещена или удалена.
            this.celiiTableAdapter.Fill(this.zavidDataSet1.celii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.comp". При необходимости она может быть перемещена или удалена.
            this.compTableAdapter.Fill(this.zavidDataSet1.comp);
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select c.number, a.comp_id, a.name as 'Название' ,b.TNB as 'Табельный #' ,b.FIO as 'Ф.И.О.' ,a.createdate as  'Дата создания' ,a.enddate as 'Дата Конца',l.id as id_cells, a.percentt as 'Процент выполнения',a.mark as 'отметка' from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + DATABANK.id_ceheDATA + "'order by c.number ";

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



        private void update_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();

            SqlCommand cmd = new SqlCommand("exec updatecomp '" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker3.Value + "','" + dateTimePicker2.Value + "','" + idcelilisttxt.SelectedValue + "','" + comboBox5.SelectedValue + "','" + comboBox4.SelectedValue + "' ", con);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("готово");
            }
            else
            {
                MessageBox.Show("error");
            }

            var select = "select c.number, a.comp_id, a.name,b.TNB,b.FIO,a.createdate,a.enddate,l.id as id_cells,a.percentt,a.mark  from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist  order by c.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];




            con.Close();
        }

        

        private void nacdeletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var delete = "Delete from comp where comp_id='" + iddelete.Text + "'";

            var dataAdapter = new SqlDataAdapter(delete, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;

            con.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celilist celiForm = new celilist();
            celiForm.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workessForm workerss = new workessForm();

            workerss.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            string theDate = txtstart.Value.ToShortDateString();
            string theend = txtstart.Value.ToShortDateString();

            SqlCommand cmd = new SqlCommand("exec createcomp '" + CompNameTXT.Text + "','" + txtstart.Value + "','" + enddatetxt.Value + "','" + comboBox5.SelectedValue + "','" + comboBox2.SelectedValue + "','" + idcelilisttxt.SelectedValue + "'", con);


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

        

        private void button3_Click(object sender, EventArgs e)
        {
            //worker_Celi_precent_form Percentss = new worker_Celi_precent_form();
            //Percentss.Show();
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updmark '" + markID.Text + "','" + textBox4.Text + "'", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();

            textBox3.Text = dataGridView1["name", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            dateTimePicker3.Text = dataGridView1["createdate", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            dateTimePicker2.Text = dataGridView1["enddate", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox6.Text = dataGridView1["id_cells", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox5.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox4.Text = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();

            markID.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox4.Text = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();

            markID.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["comp_id"].Visible = false;
            this.dataGridView1.Columns["TNB"].Visible = false;
            this.dataGridView1.Columns["id_cells"].Visible = false;
        }

        private void workerssBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void celiiBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void celiiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void workerssBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void celilisttBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void celiiBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void workerssBindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void zavidDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ceheBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ceheBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void celilisttBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
