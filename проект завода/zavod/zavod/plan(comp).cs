using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zavod
{

        public partial class plan_comp_ : Form
    {
      

        private string id_up_mer;

        public plan_comp_()
        {
            InitializeComponent();
            
        }

        private void plan_comp__Load(object sender, EventArgs e)
        {
            if (DATABANK.title_id_res1=="1")
            {
                this.groupBox1.Visible = false;
            }
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet.workerss". При необходимости она может быть перемещена или удалена.
            this.workerssTableAdapter.Fill(this.zavidDataSet.workerss);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.celii". При необходимости она может быть перемещена или удалена.
            this.celiiTableAdapter.Fill(this.zavidDataSet1.celii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.celilistt". При необходимости она может быть перемещена или удалена.
            this.celilisttTableAdapter.Fill(this.zavidDataSet1.celilistt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.workerss". При необходимости она может быть перемещена или удалена.
            this.workerssTableAdapter.Fill(this.zavidDataSet1.workerss);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.celii". При необходимости она может быть перемещена или удалена.
            this.celiiTableAdapter.Fill(this.zavidDataSet1.celii);



            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.comp". При необходимости она может быть перемещена или удалена.
            this.compTableAdapter.Fill(this.zavidDataSet1.comp);



           
            

            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select   a.ot_id ,a.id_cellist as 'id Номер цели', c.number, a.comp_id, a.name as 'Название' ,b.TNB as 'Табельный #' ,b.FIO as 'Ф.И.О.' ,a.createdate as  'Дата создания' ,a.startdate as 'Дата начала',a.enddate as 'Дата Конца',l.id as id_cells, a.percentt as 'Процент выполнения',a.mark as 'отметка' from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + comboBox1.SelectedValue + "' and year_cel ='"+DATABANK.yearrr+"' order by c.number ";

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
        


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var select = "select   a.ot_id ,a.id_cellist as 'id Номер цели', c.number, a.comp_id, a.name as 'Название' ,b.TNB as 'Табельный #' ,b.FIO as 'Ф.И.О.' ,a.createdate as  'Дата создания' ,a.startdate as 'Дата начала',a.enddate as 'Дата Конца',l.id as id_cells, a.percentt as 'Процент выполнения',a.mark as 'отметка'  from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + comboBox1.SelectedValue + "'order by c.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public string[] clientid;
        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            string theDate = txtstart.Value.ToShortDateString();
            string theend = txtstart.Value.ToShortDateString();

            SqlCommand cmd = new SqlCommand("exec createcomp '" + CompNameTXT.Text + "','" + txtstart.Value + "','" + enddatetxt.Value + "','" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + idcelilisttxt.SelectedValue+"'", con) ;
            

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

   

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            var delete = "Delete from comp where comp_id='" + textBox1.Text + "'";

            var dataAdapter = new SqlDataAdapter(delete, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            
            con.Close();
            



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            com_id_txtb.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();

            Comp_name_txtb.Text = dataGridView1["Название", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            startdate_dtp.Text = dataGridView1["Дата начала", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            endtime_pick.Text = dataGridView1["Дата Конца", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            idceliCombo.Text = dataGridView1["id_cells", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            otvCombo.Text = dataGridView1["Табельный #", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            idcelilistCombo.Text = dataGridView1["id_cells", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            idcelilisttxt.Text = dataGridView1["id Номер цели", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            markID.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1["comp_id", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            loginform Logfrm = new loginform();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

           


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["comp_id"].Visible = false;
            //this.dataGridView1.Columns["Табельный #"].Visible =false;
            this.dataGridView1.Columns["id_cells"].Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            workessForm workerss = new workessForm();

            workerss.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workessForm workerss = new workessForm();

            workerss.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celilist celiForm = new celilist();
            celiForm.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec createcomp '" + CompNameTXT.Text + "','" + txtstart.Text + "','" + enddatetxt.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + idcelilisttxt.Text + "'", con);
            cmd.ExecuteNonQuery();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("готово");
            }
            else
            {
                MessageBox.Show("error");
            }

            var select = "select c.number, a.comp_id, a.name,b.TNB,b.FIO,a.createdate,a.enddate,l.id as id_cells,a.percentt,a.mark  from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + comboBox1.SelectedValue + "'order by c.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];





            con.Close();
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            //worker_Celi_precent_form Percentss = new worker_Celi_precent_form();
            //Percentss.Show();
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updmark '" + markID.Text + "','" + txtmarkbox.Text + "'", con);
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

        private void update_comp_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();

            SqlCommand cmd = new SqlCommand("exec updatecomp '"+ com_id_txtb.Text+ "','"+Comp_name_txtb.Text+"','"+startdate_dtp.Value+ "','"+endtime_pick.Value+ "','"+idcelilisttxt.SelectedValue+ "','"+otvCombo.SelectedValue+ "','"+idcelilistCombo.SelectedValue+"' ", con);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("готово");
            }
            else
            {
                MessageBox.Show("error");
            }

            var select = "select c.number, a.comp_id, a.name,b.TNB,b.FIO,a.createdate,a.enddate,l.id as id_cells,a.percentt,a.mark  from dbo.comp a left join dbo.workerss b on b.TNB = a.ot_id left join dbo.celii c on a.id_celi=c.celi_id  left join dbo.celilistt l on l.id=a.id_cellist where l.cehe_id = '" + comboBox1.SelectedValue + "'order by c.number ";

            var dataAdapter = new SqlDataAdapter(select, con);


            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];




            con.Close();


        }

        private void idcelilistCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void otvCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
