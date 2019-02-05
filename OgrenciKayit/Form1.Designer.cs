namespace OgrenciKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this._txtSifre = new System.Windows.Forms.TextBox();
            this._chckHatirla = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnGiris
            // 
            this._btnGiris.Location = new System.Drawing.Point(32, 173);
            this._btnGiris.Name = "_btnGiris";
            this._btnGiris.Size = new System.Drawing.Size(75, 42);
            this._btnGiris.TabIndex = 0;
            this._btnGiris.Text = "Giriş";
            this._btnGiris.UseVisualStyleBackColor = true;
            this._btnGiris.Click += new System.EventHandler(this._btnGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._chckHatirla);
            this.groupBox1.Controls.Add(this._txtSifre);
            this.groupBox1.Controls.Add(this._txtKullaniciAdi);
            this.groupBox1.Controls.Add(this._btnGiris);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // _txtKullaniciAdi
            // 
            this._txtKullaniciAdi.Location = new System.Drawing.Point(21, 32);
            this._txtKullaniciAdi.Name = "_txtKullaniciAdi";
            this._txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this._txtKullaniciAdi.TabIndex = 1;
            // 
            // _txtSifre
            // 
            this._txtSifre.Location = new System.Drawing.Point(21, 91);
            this._txtSifre.Name = "_txtSifre";
            this._txtSifre.Size = new System.Drawing.Size(100, 20);
            this._txtSifre.TabIndex = 2;
            // 
            // _chckHatirla
            // 
            this._chckHatirla.AutoSize = true;
            this._chckHatirla.Location = new System.Drawing.Point(29, 134);
            this._chckHatirla.Name = "_chckHatirla";
            this._chckHatirla.Size = new System.Drawing.Size(80, 17);
            this._chckHatirla.TabIndex = 3;
            this._chckHatirla.Text = "Beni Hatırla";
            this._chckHatirla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(169, 246);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _chckHatirla;
        private System.Windows.Forms.TextBox _txtSifre;
        private System.Windows.Forms.TextBox _txtKullaniciAdi;
    }
}

