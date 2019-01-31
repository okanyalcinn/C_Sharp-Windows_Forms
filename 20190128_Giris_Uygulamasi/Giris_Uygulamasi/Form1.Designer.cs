namespace Giris_Uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnGiris = new System.Windows.Forms.Button();
            this._btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this._txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnGiris
            // 
            this._btnGiris.Location = new System.Drawing.Point(18, 97);
            this._btnGiris.Name = "_btnGiris";
            this._btnGiris.Size = new System.Drawing.Size(75, 23);
            this._btnGiris.TabIndex = 0;
            this._btnGiris.Text = "Giriş";
            this._btnGiris.UseVisualStyleBackColor = true;
            this._btnGiris.Click += new System.EventHandler(this._btnGiris_Click);
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(129, 97);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(75, 23);
            this._btnReset.TabIndex = 1;
            this._btnReset.Text = "Resetle";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this._btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // _txtKullaniciAdi
            // 
            this._txtKullaniciAdi.Location = new System.Drawing.Point(104, 13);
            this._txtKullaniciAdi.Name = "_txtKullaniciAdi";
            this._txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this._txtKullaniciAdi.TabIndex = 3;
            // 
            // _txtSifre
            // 
            this._txtSifre.Location = new System.Drawing.Point(104, 45);
            this._txtSifre.Name = "_txtSifre";
            this._txtSifre.Size = new System.Drawing.Size(100, 20);
            this._txtSifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtSifre);
            this.groupBox1.Controls.Add(this._btnGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._btnReset);
            this.groupBox1.Controls.Add(this._txtKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Ekranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 206);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnGiris;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtKullaniciAdi;
        private System.Windows.Forms.TextBox _txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

