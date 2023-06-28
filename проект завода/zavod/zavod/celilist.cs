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
   
    public partial class celilist : Form
    {
        public int cmdresult = 0;
        public int create = 0;
        public string id_meropr = "0";


        //public int Txt
        //{
        //    //get { return (int)comboBox21.SelectedValue; }
        //    //set { comboBox21.SelectedValue = listBox21.SelectedValue; }

        //}
        DataBase dataBase = new DataBase();
        public celilist()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet.cehe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet.celilistt". При необходимости она может быть перемещена или удалена.
            this.celilisttTableAdapter.Fill(this.zavidDataSet.celilistt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet.celii". При необходимости она может быть перемещена или удалена.
            this.celiiTableAdapter.Fill(this.zavidDataSet.celii);
            this.compTableAdapter.Fill(this.zavidDataSet.comp);
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            var select = "select c.number as '№', c.name as 'Наименование', Avg(a.percentt) as 'Средний процент выполнения Цели', COUNT(a.comp_id) as 'Количество мероприятий' from dbo.comp a left join dbo.celii c on a.id_celi=c.celi_id left join dbo.celilistt l on l.id=a.id_cellist  where l.cehe_id='" + DATABANK.id_ceheDATA + "' group by c.number, c.name Order by c.number ";




            var dataAdapter = new SqlDataAdapter(select, con);
            con.Open();

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


        }


        private void joinbutton_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            var select = "select c.number as '№', c.name as 'Наименование', Avg(a.percentt) as 'Средний процент выполнения Цели', COUNT(a.comp_id) as 'Количество мероприятий' from dbo.comp a left join dbo.celii c on a.id_celi=c.celi_id left join dbo.celilistt l on l.id=a.id_cellist  where l.cehe_id='" + DATABANK.id_ceheDATA + "' group by c.number, c.name Order by c.number ";




            var dataAdapter = new SqlDataAdapter(select, con);
            con.Open();

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_meropr = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //loginform Logfrm = new loginform();
            //textBox1.Text = Convert.ToString(Logfrm.title_id);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            plan_comp_ planeForm = new plan_comp_();
            planeForm.Show();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workessForm workerss = new workessForm();

            workerss.Show();
        }



        private void name_celi_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_celi_textbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void списокЦелейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spisokcelei_Form spisok = new spisokcelei_Form();
            spisok.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string quertyString1 = $"select * from celilistt where year_cel='"+DATABANK.yearrr+"'and cehe_id='"+comboBox1.SelectedValue+"'";

            SqlCommand command1 = new SqlCommand(quertyString1, dataBase.GetConnection());

            SqlConnection con1 = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con1.Open();

            SqlCommand cmd1 = new SqlCommand(quertyString1, con1);//добавить пароль 


            DATABANK.yearrr = DateTime.Today.Year.ToString();

             
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            con1.Close();
            if (table.Rows.Count == 1)
            {
                
                MessageBox.Show("Уже есть запись с 2022 для этого цеха");


            }
            else
            {
               
                MessageBox.Show("нет записи д");
                SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
                con.Open();
                

                SqlCommand cmd = new SqlCommand("insert into celilistt values('"+comboBox1.SelectedValue+"','"+DATABANK.yearrr+"') ", con);


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

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            if (DATABANK.title_id_res1 != "2")
            {
                groupBox1.Visible = false;
            }
            else
            {

                groupBox1.Visible = true;
            }
             
            
                var select = "select c.number as '№', c.name as 'Наименование', Avg(a.percentt) as 'Средний процент выполнения Цели', COUNT(a.comp_id) as 'Количество мероприятий' from dbo.comp a left join dbo.celii c on a.id_celi=c.celi_id left join dbo.celilistt l on l.id=a.id_cellist  where l.cehe_id='" + comboBox2.SelectedValue + "' group by c.number, c.name Order by c.number ";
            



            var dataAdapter = new SqlDataAdapter(select, con);
            con.Open();

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            if (DATABANK.title_id_res1 != "2")
            {
                groupBox1.Visible = false;
            }
            else
            {

                groupBox1.Visible = true;
            }


            var select = "select c.number as '№', c.name as 'Наименование', Avg(a.percentt) as 'Средний процент выполнения Цели', COUNT(a.comp_id) as 'Количество мероприятий' from dbo.comp a left join dbo.celii c on a.id_celi=c.celi_id left join dbo.celilistt l on l.id=a.id_cellist  where l.cehe_id='" + comboBox1.SelectedValue + "' group by c.number, c.name Order by c.number ";




            var dataAdapter = new SqlDataAdapter(select, con);
            con.Open();

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
