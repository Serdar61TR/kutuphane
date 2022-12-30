namespace küytüphane_otomasyonu
{
    partial class SifremiUnuttum
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
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.SifreAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(198, 70);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(163, 22);
            this.txt_eposta.TabIndex = 0;
            // 
            // SifreAl
            // 
            this.SifreAl.Location = new System.Drawing.Point(198, 136);
            this.SifreAl.Name = "SifreAl";
            this.SifreAl.Size = new System.Drawing.Size(111, 23);
            this.SifreAl.TabIndex = 1;
            this.SifreAl.Text = "Yeni Şifre Al";
            this.SifreAl.UseVisualStyleBackColor = true;
            this.SifreAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eposta:";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreAl);
            this.Controls.Add(this.txt_eposta);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Button SifreAl;
        private System.Windows.Forms.Label label1;
    }
}