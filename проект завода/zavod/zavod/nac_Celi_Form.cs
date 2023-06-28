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
    public partial class nac_Celi_Form : Form
    {
        public nac_Celi_Form()
        {
            InitializeComponent();
        }

        private void nac_Celi_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zavidDataSet1.cehe". При необходимости она может быть перемещена или удалена.
            this.ceheTableAdapter.Fill(this.zavidDataSet1.cehe);

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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            plan_comp_ plan = new plan_comp_();
            plan.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nac_Celi_Form nacceli = new nac_Celi_Form();
            nacceli.Show();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
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
           
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
