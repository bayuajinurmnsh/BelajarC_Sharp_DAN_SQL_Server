﻿using System;
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
    public partial class FormLogin : Form
    {
        Config db = new Config();
        public FormLogin()
        {
            InitializeComponent();
            db.Connect("db_userdata");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `tbl_user_info` where username='" + txtbox_username.Text +"' and password ='" +txtbox_pass.Text +"'");

            if (db.Count() != 0)
            {
                MessageBox.Show("Success You will Login as" + db.Results(0, "name"));
            }
            else
            {
                MessageBox.Show("Wrong username or password combination");
            }
        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            
            register.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
