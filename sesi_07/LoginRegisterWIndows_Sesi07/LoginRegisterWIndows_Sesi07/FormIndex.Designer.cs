
namespace LoginRegisterWIndows_Sesi07
{
    partial class FormIndex
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbl_SelamatDatang = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(486, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbl_SelamatDatang
            // 
            this.lbl_SelamatDatang.AutoSize = true;
            this.lbl_SelamatDatang.Location = new System.Drawing.Point(12, 21);
            this.lbl_SelamatDatang.Name = "lbl_SelamatDatang";
            this.lbl_SelamatDatang.Size = new System.Drawing.Size(109, 17);
            this.lbl_SelamatDatang.TabIndex = 3;
            this.lbl_SelamatDatang.Text = "Selamat Datang";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_welcome.Location = new System.Drawing.Point(128, 18);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(24, 32);
            this.lbl_welcome.TabIndex = 4;
            this.lbl_welcome.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambah Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hapus Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_SelamatDatang);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIndex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbl_SelamatDatang;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}