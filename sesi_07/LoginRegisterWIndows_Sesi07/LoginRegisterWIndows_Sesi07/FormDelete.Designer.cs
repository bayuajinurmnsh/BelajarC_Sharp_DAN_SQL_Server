
namespace LoginRegisterWIndows_Sesi07
{
    partial class FormDelete
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtBoxDLT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(152, 149);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(37, 32);
            this.lbl_Name.TabIndex = 24;
            this.lbl_Name.Text = "Id";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(109, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(394, 265);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 40);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Delete Data";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtBoxDLT
            // 
            this.txtBoxDLT.Location = new System.Drawing.Point(290, 149);
            this.txtBoxDLT.Multiline = true;
            this.txtBoxDLT.Name = "txtBoxDLT";
            this.txtBoxDLT.Size = new System.Drawing.Size(350, 43);
            this.txtBoxDLT.TabIndex = 25;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtBoxDLT);
            this.Name = "FormDelete";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtBoxDLT;
    }
}