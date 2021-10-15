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
    public partial class FormTambah : Form
    {
        Config db = new Config();
        public FormTambah()
        {
            InitializeComponent();
            db.Connect("db_userdata");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO `tbl_user_info` (`id`,`name`, `username` , `password`) VALUES (NULL,'" + txtBox_Username.Text + "','" + txtBox_name.Text + "', '" + txtBox_Pass.Text + "')");

            MessageBox.Show("Data has been insert !");
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();
        }

        private void FormTambah_Load(object sender, EventArgs e)
        {

        }
    }
}
