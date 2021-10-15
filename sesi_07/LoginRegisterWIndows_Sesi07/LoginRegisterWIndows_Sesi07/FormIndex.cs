using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginRegisterWIndows_Sesi07
{
    public partial class FormIndex : Form
    {
        Config db = new Config();

        
        public FormIndex()
        {
            InitializeComponent();
            db.Connect("db_userdata");

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambah ft = new FormTambah();
            ft.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDelete df = new FormDelete();
            df.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdate fu = new FormUpdate();
            fu.Show();
            this.Hide();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT * FROM tbl_user_info", "server = localhost; database = db_userdata; UID = root; password = root");
            DataSet ds = new DataSet();
            da2.Fill(ds, "tbl_user_info");
            dataGridView1.DataSource = ds.Tables["tbl_user_info"].DefaultView;

            lbl_welcome.Text = UserDetails.Username;
        }
    }
}
