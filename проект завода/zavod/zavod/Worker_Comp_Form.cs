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
    public partial class Worker_Comp_Form : Form
    {
        public Worker_Comp_Form()
        {
            InitializeComponent();
        }
   private void Worker_Comp_Form_Load(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.comp". При необходимости она может быть перемещена или удалена.
            this.compTableAdapter.Fill(this.zavidDataSet1.comp);
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select c.number, a.comp_id, a.name,b.TNB,b.FIO,a.createdate,a.enddate,l.id as id_cells, a.percentt,a.mark from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + DATABANK.id_ceheDATA + "' and year_cel = "+ Convert.ToInt32(DATABANK.yearrr)+" order by c.number ";

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

            this.dataGridView1.Columns["comp_id"].Visible = false;

        }
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worker_Comp_Form workermain = new Worker_Comp_Form();
            workermain.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select c.number, a.comp_id, a.name,b.TNB,b.FIO,a.createdate,a.enddate,l.id as id_cells,a.percentt,a.mark  from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + DATABANK.id_ceheDATA + "'order by c.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //worker_Celi_precent_form Percentss = new worker_Celi_precent_form();
            //Percentss.Show();
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updpercent '" + textBox2.Text + "'," + textBox1.Text + "", con);
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

    }
}
