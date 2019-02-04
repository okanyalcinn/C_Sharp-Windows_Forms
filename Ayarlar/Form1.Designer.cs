namespace Ayarlar
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
            this._txtKullanici = new System.Windows.Forms.TextBox();
            this._txtSifre = new System.Windows.Forms.TextBox();
            this._chkHatirla = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnGiris
            // 
            this._btnGiris.Location = new System.Drawing.Point(27, 165);
            this._btnGiris.Name = "_btnGiris";
            this._btnGiris.Size = new System.Drawing.Size(139, 36);
            this._btnGiris.TabIndex = 0;
            this._btnGiris.Text = "Giriş";
            this._btnGiris.UseVisualStyleBackColor = true;
            this._btnGiris.Click += new System.EventHandler(this._btnGiris_Click);
            // 
            // _txtKullanici
            // 
            this._txtKullanici.Location = new System.Drawing.Point(27, 37);
            this._txtKullanici.Name = "_txtKullanici";
            this._txtKullanici.Size = new System.Drawing.Size(139, 20);
            this._txtKullanici.TabIndex = 1;
            // 
            // _txtSifre
            // 
            this._txtSifre.Location = new System.Drawing.Point(27, 89);
            this._txtSifre.Name = "_txtSifre";
            this._txtSifre.Size = new System.Drawing.Size(139, 20);
            this._txtSifre.TabIndex = 2;
            // 
            // _chkHatirla
            // 
            this._chkHatirla.AutoSize = true;
            this._chkHatirla.Location = new System.Drawing.Point(27, 127);
            this._chkHatirla.Name = "_chkHatirla";
            this._chkHatirla.Size = new System.Drawing.Size(80, 17);
            this._chkHatirla.TabIndex = 3;
            this._chkHatirla.Text = "Beni Hatırla";
            this._chkHatirla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanici Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chkHatirla);
            this.Controls.Add(this._txtSifre);
            this.Controls.Add(this._txtKullanici);
            this.Controls.Add(this._btnGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnGiris;
        private System.Windows.Forms.TextBox _txtKullanici;
        private System.Windows.Forms.TextBox _txtSifre;
        private System.Windows.Forms.CheckBox _chkHatirla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

