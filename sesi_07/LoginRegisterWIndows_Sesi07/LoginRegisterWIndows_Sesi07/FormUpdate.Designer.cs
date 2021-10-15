
namespace LoginRegisterWIndows_Sesi07
{
    partial class FormUpdate
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(136, 139);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 32);
            this.lbl_Name.TabIndex = 24;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(93, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(387, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 40);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(274, 128);
            this.txtBox_name.Multiline = true;
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(350, 43);
            this.txtBox_name.TabIndex = 25;
            this.txtBox_name.TextChanged += new System.EventHandler(this.txtBox_name_TextChanged);
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(274, 196);
            this.txtBox_Username.Multiline = true;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(350, 43);
            this.txtBox_Username.TabIndex = 20;
            this.txtBox_Username.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Location = new System.Drawing.Point(274, 270);
            this.txtBox_Pass.Multiline = true;
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.Size = new System.Drawing.Size(350, 43);
            this.txtBox_Pass.TabIndex = 21;
            this.txtBox_Pass.TextChanged += new System.EventHandler(this.txtBox_Pass_TextChanged);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(136, 270);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(116, 32);
            this.lbl_pass.TabIndex = 19;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(136, 207);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(123, 32);
            this.lbl_username.TabIndex = 18;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(274, 64);
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(350, 43);
            this.txtBoxID.TabIndex = 27;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Name = "FormUpdate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxID;
    }
}