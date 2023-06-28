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
    public partial class workessForm : Form
    {
        public workessForm()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select * from workerss where  TNB ='" + TNBTEXTBOX.Text + "' OR  id_cehe='" + TNBTEXTBOX.Text + "'";
            var select1 = "select * from workerss where FIO ='" + TNBTEXTBOX.Text + "'";
            var dataAdapter = new SqlDataAdapter(select, con);
            var dataAdapter1 = new SqlDataAdapter(select1, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void workessForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.comp". При необходимости она может быть перемещена или удалена.
            this.compTableAdapter.Fill(this.zavidDataSet1.comp);
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select * from workerss";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "";
            if (FIOTEXTBOX.Text != "")
            {
                select += "select * from workerss where  FIO Like '%" + FIOTEXTBOX.Text + "%'";
            }
            if (TNBTEXTBOX.Text != ""){
                select += "select * from workerss where  TNB ='" + TNBTEXTBOX.Text + "'";
            }
            if (CEHETXTBOX.Text != "")
            {
                select += "select * from workerss where  id_cehe='" + CEHETXTBOX.Text + "'";
            }
         
            var dataAdapter = new SqlDataAdapter(select, con);
           


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
           
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
