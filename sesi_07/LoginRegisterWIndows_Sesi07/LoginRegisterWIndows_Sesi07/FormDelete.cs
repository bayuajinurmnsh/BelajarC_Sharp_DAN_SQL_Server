using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWIndows_Sesi07
{
    public partial class FormDelete : Form
    {
        Config db = new Config();
        public FormDelete()
        {
            InitializeComponent();
            db.Connect("db_userdata");
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("DELETE FROM `tbl_user_info` where id='" + txtBoxDLT.Text +"'");
            MessageBox.Show("Data has been deleted !");
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();
        }
    }
}
