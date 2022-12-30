namespace küytüphane_otomasyonu
{
    partial class Emanet_Kitap
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn_nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rafno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cevirmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_personel = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.Alici = new System.Windows.Forms.Label();
            this.AliciTc = new System.Windows.Forms.Label();
            this.AliciTel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Teslim Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAdi,
            this.isbn_nu,
            this.Yazar,
            this.YayinEvi,
            this.Turu,
            this.Rafno,
            this.Cevirmen});
            this.dataGridView1.Location = new System.Drawing.Point(294, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 315);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap ADI";
            this.KitapAdi.MinimumWidth = 6;
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            // 
            // isbn_nu
            // 
            this.isbn_nu.DataPropertyName = "isbn_nu";
            this.isbn_nu.HeaderText = "İSBN";
            this.isbn_nu.MinimumWidth = 6;
            this.isbn_nu.Name = "isbn_nu";
            this.isbn_nu.ReadOnly = true;
            // 
            // Yazar
            // 
            this.Yazar.DataPropertyName = "Yazar";
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.MinimumWidth = 6;
            this.Yazar.Name = "Yazar";
            this.Yazar.ReadOnly = true;
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "YayinEvi";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.MinimumWidth = 6;
            this.YayinEvi.Name = "YayinEvi";
            this.YayinEvi.ReadOnly = true;
            // 
            // Turu
            // 
            this.Turu.DataPropertyName = "Turu";
            this.Turu.HeaderText = "Türü";
            this.Turu.MinimumWidth = 6;
            this.Turu.Name = "Turu";
            this.Turu.ReadOnly = true;
            // 
            // Rafno
            // 
            this.Rafno.DataPropertyName = "Rafno";
            this.Rafno.HeaderText = "Raf";
            this.Rafno.MinimumWidth = 6;
            this.Rafno.Name = "Rafno";
            this.Rafno.ReadOnly = true;
            // 
            // Cevirmen
            // 
            this.Cevirmen.DataPropertyName = "Cevirmen";
            this.Cevirmen.HeaderText = "Çevirmen";
            this.Cevirmen.MinimumWidth = 6;
            this.Cevirmen.Name = "Cevirmen";
            this.Cevirmen.ReadOnly = true;
            // 
            // txt_personel
            // 
            this.txt_personel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_personel.Location = new System.Drawing.Point(294, 30);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.Size = new System.Drawing.Size(100, 15);
            this.txt_personel.TabIndex = 38;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(161, 79);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txt_AdSoyad.TabIndex = 39;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(161, 117);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 22);
            this.txt_tc.TabIndex = 40;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(161, 155);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 22);
            this.txt_tel.TabIndex = 41;
            // 
            // Alici
            // 
            this.Alici.AutoSize = true;
            this.Alici.Location = new System.Drawing.Point(26, 85);
            this.Alici.Name = "Alici";
            this.Alici.Size = new System.Drawing.Size(55, 16);
            this.Alici.TabIndex = 42;
            this.Alici.Text = "Alıcı Adı";
            // 
            // AliciTc
            // 
            this.AliciTc.AutoSize = true;
            this.AliciTc.Location = new System.Drawing.Point(26, 123);
            this.AliciTc.Name = "AliciTc";
            this.AliciTc.Size = new System.Drawing.Size(51, 16);
            this.AliciTc.TabIndex = 43;
            this.AliciTc.Text = "Alıcı Tc";
            // 
            // AliciTel
            // 
            this.AliciTel.AutoSize = true;
            this.AliciTel.Location = new System.Drawing.Point(26, 161);
            this.AliciTel.Name = "AliciTel";
            this.AliciTel.Size = new System.Drawing.Size(55, 16);
            this.AliciTel.TabIndex = 44;
            this.AliciTel.Text = "Alıcı Tel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Kitap adı ara";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(897, 23);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(186, 22);
            this.txt_ara.TabIndex = 45;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // Emanet_Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1161, 413);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.AliciTel);
            this.Controls.Add(this.AliciTc);
            this.Controls.Add(this.Alici);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_personel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Emanet_Kitap";
            this.Text = "Emanet_Kitap";
            this.Load += new System.EventHandler(this.Emanet_Kitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_personel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn_nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rafno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cevirmen;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label Alici;
        private System.Windows.Forms.Label AliciTc;
        private System.Windows.Forms.Label AliciTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ara;
    }
}