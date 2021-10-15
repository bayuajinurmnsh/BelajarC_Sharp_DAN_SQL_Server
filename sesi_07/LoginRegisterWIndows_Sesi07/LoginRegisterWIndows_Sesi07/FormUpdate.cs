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
    public partial class FormUpdate : Form
    {
        Config db = new Config();
        public FormUpdate()
        {
            InitializeComponent();
            db.Connect("db_userdata");
        }

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            db.Execute("UPDATE `tbl_user_info` SET username='" + txtBox_Username.Text + "', name='" + txtBox_name.Text + "', password='" + txtBox_Pass.Text + "' WHERE id='"+ txtBoxID.Text+"'");                
            
            MessageBox.Show("Data has been updated !");
            FormIndex fi = new FormIndex();
            fi.Show();
            this.Close();

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
    }
}
