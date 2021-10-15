
namespace LoginRegisterWIndows_Sesi07
{
    partial class FormTambah
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
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(279, 89);
            this.txtBox_name.Multiline = true;
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(350, 43);
            this.txtBox_name.TabIndex = 17;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(141, 100);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 32);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(98, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(392, 280);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(134, 40);
            this.btnTambah.TabIndex = 14;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Location = new System.Drawing.Point(279, 231);
            this.txtBox_Pass.Multiline = true;
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.Size = new System.Drawing.Size(350, 43);
            this.txtBox_Pass.TabIndex = 13;
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(279, 157);
            this.txtBox_Username.Multiline = true;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(350, 43);
            this.txtBox_Username.TabIndex = 12;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(141, 231);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(116, 32);
            this.lbl_pass.TabIndex = 11;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(141, 168);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(123, 32);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username";
            // 
            // FormTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Name = "FormTambah";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTambah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_username;
    }
}