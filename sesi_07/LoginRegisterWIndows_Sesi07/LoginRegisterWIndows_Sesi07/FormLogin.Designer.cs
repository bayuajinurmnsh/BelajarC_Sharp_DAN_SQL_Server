
namespace LoginRegisterWIndows_Sesi07
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_belumPunyaAkun = new System.Windows.Forms.Label();
            this.btn_daftar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(56, 152);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(95, 45);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(56, 210);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(90, 45);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Login.Location = new System.Drawing.Point(307, 256);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(82, 32);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(170, 159);
            this.txtbox_username.Multiline = true;
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(363, 34);
            this.txtbox_username.TabIndex = 3;
            this.txtbox_username.TextChanged += new System.EventHandler(this.txtbox_username_TextChanged);
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Location = new System.Drawing.Point(170, 216);
            this.txtbox_pass.Multiline = true;
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.Size = new System.Drawing.Size(363, 34);
            this.txtbox_pass.TabIndex = 4;
            this.txtbox_pass.TextChanged += new System.EventHandler(this.txtbox_pass_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Brown;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1, 362);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 32);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_belumPunyaAkun
            // 
            this.lbl_belumPunyaAkun.AutoSize = true;
            this.lbl_belumPunyaAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_belumPunyaAkun.Location = new System.Drawing.Point(61, 325);
            this.lbl_belumPunyaAkun.Name = "lbl_belumPunyaAkun";
            this.lbl_belumPunyaAkun.Size = new System.Drawing.Size(338, 18);
            this.lbl_belumPunyaAkun.TabIndex = 6;
            this.lbl_belumPunyaAkun.Text = "Belum punya akun ? silahkan daftar terlebih dahulu";
            this.lbl_belumPunyaAkun.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_daftar
            // 
            this.btn_daftar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_daftar.ForeColor = System.Drawing.Color.Black;
            this.btn_daftar.Location = new System.Drawing.Point(460, 318);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(85, 34);
            this.btn_daftar.TabIndex = 7;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.UseVisualStyleBackColor = false;
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 140);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_daftar);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_belumPunyaAkun);
            this.Controls.Add(this.lbl_username);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_belumPunyaAkun;
        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

