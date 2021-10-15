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
    public partial class FormRegister : Form
    {
        Config db = new Config();
        public FormRegister()
        {
            InitializeComponent();
            db.Connect("db_userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Register_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO `tbl_user_info` (`id`,`name`, `username` , `password`) VALUES (NULL,'" + txtBox_Username.Text+ "','" + txtBox_name.Text + "', '"+ txtBox_Pass.Text +"')");

            MessageBox.Show("Data has been insert !");
            FormLogin lgin = new FormLogin();
            lgin.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin lgin = new FormLogin();
            lgin.Show();
            this.Close();
        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
