namespace küytüphane_otomasyonu
{
    partial class Emanet_Dergi
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
            this.AliciTel = new System.Windows.Forms.Label();
            this.AliciTc = new System.Windows.Forms.Label();
            this.Alici = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.btn_ver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 161);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AliciTel
            // 
            this.AliciTel.AutoSize = true;
            this.AliciTel.Location = new System.Drawing.Point(30, 127);
            this.AliciTel.Name = "AliciTel";
            this.AliciTel.Size = new System.Drawing.Size(55, 16);
            this.AliciTel.TabIndex = 50;
            this.AliciTel.Text = "Alıcı Tel";
            // 
            // AliciTc
            // 
            this.AliciTc.AutoSize = true;
            this.AliciTc.Location = new System.Drawing.Point(30, 89);
            this.AliciTc.Name = "AliciTc";
            this.AliciTc.Size = new System.Drawing.Size(51, 16);
            this.AliciTc.TabIndex = 49;
            this.AliciTc.Text = "Alıcı Tc";
            // 
            // Alici
            // 
            this.Alici.AutoSize = true;
            this.Alici.Location = new System.Drawing.Point(30, 51);
            this.Alici.Name = "Alici";
            this.Alici.Size = new System.Drawing.Size(55, 16);
            this.Alici.TabIndex = 48;
            this.Alici.Text = "Alıcı Adı";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(172, 127);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 22);
            this.txt_tel.TabIndex = 47;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(172, 89);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 22);
            this.txt_tc.TabIndex = 46;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(172, 51);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txt_AdSoyad.TabIndex = 45;
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(900, 223);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 51;
            this.btn_ver.Text = "Teslim Et";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "label4";
            // 
            // Emanet_Dergi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.AliciTel);
            this.Controls.Add(this.AliciTc);
            this.Controls.Add(this.Alici);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Emanet_Dergi";
            this.Text = "Emanet_Dergi";
            this.Load += new System.EventHandler(this.Emanet_Dergi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AliciTel;
        private System.Windows.Forms.Label AliciTc;
        private System.Windows.Forms.Label Alici;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Label label4;
    }
}