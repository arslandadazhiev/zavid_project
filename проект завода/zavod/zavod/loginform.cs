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
    public partial class loginform : Form
    {
        public int title_id_res = 0;
        public int ID_Cehe_res = 0;


        DataBase dataBase = new DataBase();
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }


        private void enterbutton_Click(object sender, EventArgs e)
        {
            

            var loginUser = logintextbox.Text;
            var passUser = passtextbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string quertyString = $"select title from workerss where logins='{loginUser}'and pass='{passUser}'";

            SqlCommand command = new SqlCommand(quertyString, dataBase.GetConnection());

            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
           

            SqlCommand cmd = new SqlCommand(quertyString, con);//добавить пароль 






            string quertyString1 = $"select id_cehe from workerss where logins='{loginUser}'and pass='{passUser}'";

            SqlCommand command1 = new SqlCommand(quertyString1, dataBase.GetConnection());

            SqlConnection con1 = new SqlConnection("Data Source = (local); Initial Catalog = zavid; Integrated Security = True");
            con.Open();

            SqlCommand cmd1 = new SqlCommand(quertyString1, con);//добавить пароль 



            DATABANK.yearrr = DateTime.Today.Year.ToString();





            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                title_id_res = Convert.ToInt32(cmd.ExecuteScalar());//записывает результат запроса в переменную
                ID_Cehe_res = Convert.ToInt32(cmd1.ExecuteScalar());
                //MessageBox.Show("Вы успешно вошли");
                if (title_id_res == 1)
                {
                     
                    MessageBox.Show("Вы вошли как начальник");
                    DATABANK.id_ceheDATA = Convert.ToString(ID_Cehe_res);
                    DATABANK.title_id_res1 = Convert.ToString(title_id_res);
                    //nac_Celi_Form nacForm = new nac_Celi_Form();
                    //nacForm.Show();

                    nac_Celi_Form nacceli = new nac_Celi_Form();
                    nacceli.Show();

                     


                }
                else if (title_id_res == 2)

                {
                    MessageBox.Show("Вы вошли как ответствекнный");
                    DATABANK.id_ceheDATA = Convert.ToString(ID_Cehe_res);
                    DATABANK.title_id_res1 = Convert.ToString(title_id_res);
                    celilist celi = new celilist();
                    celi.Show();
                }
                else if (title_id_res == 3)
                {
                    MessageBox.Show("Вы вошли как работник ");
                    DATABANK.id_ceheDATA = Convert.ToString(ID_Cehe_res);
                    DATABANK.title_id_res1 = Convert.ToString(title_id_res);
                    Worker_Comp_Form worker = new Worker_Comp_Form();
                    worker.Show();

                }
                 
            }
            else
            {
                MessageBox.Show("Вы ввели неверный Логин/Пароль");
            }

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
