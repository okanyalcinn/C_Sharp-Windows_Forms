namespace _20190129_Rss_Api
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
            this._lstBaslik = new System.Windows.Forms.ListBox();
            this._btnHaberlerCek = new System.Windows.Forms.Button();
            this._lblBasliklar = new System.Windows.Forms.Label();
            this._lblHbrDty = new System.Windows.Forms.Label();
            this._txtDetay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lstBaslik
            // 
            this._lstBaslik.FormattingEnabled = true;
            this._lstBaslik.Location = new System.Drawing.Point(15, 39);
            this._lstBaslik.Name = "_lstBaslik";
            this._lstBaslik.Size = new System.Drawing.Size(242, 212);
            this._lstBaslik.TabIndex = 0;
            this._lstBaslik.SelectedIndexChanged += new System.EventHandler(this._lstBaslik_SelectedIndexChanged);
            // 
            // _btnHaberlerCek
            // 
            this._btnHaberlerCek.Location = new System.Drawing.Point(15, 274);
            this._btnHaberlerCek.Name = "_btnHaberlerCek";
            this._btnHaberlerCek.Size = new System.Drawing.Size(242, 27);
            this._btnHaberlerCek.TabIndex = 2;
            this._btnHaberlerCek.Text = "Haberleri Çek";
            this._btnHaberlerCek.UseVisualStyleBackColor = true;
            this._btnHaberlerCek.Click += new System.EventHandler(this._btnHaberlerCek_Click);
            // 
            // _lblBasliklar
            // 
            this._lblBasliklar.AutoSize = true;
            this._lblBasliklar.Location = new System.Drawing.Point(12, 9);
            this._lblBasliklar.Name = "_lblBasliklar";
            this._lblBasliklar.Size = new System.Drawing.Size(46, 13);
            this._lblBasliklar.TabIndex = 3;
            this._lblBasliklar.Text = "Başlıklar";
            // 
            // _lblHbrDty
            // 
            this._lblHbrDty.AutoSize = true;
            this._lblHbrDty.Location = new System.Drawing.Point(271, 9);
            this._lblHbrDty.Name = "_lblHbrDty";
            this._lblHbrDty.Size = new System.Drawing.Size(67, 13);
            this._lblHbrDty.TabIndex = 4;
            this._lblHbrDty.Text = "Haber Detay";
            // 
            // _txtDetay
            // 
            this._txtDetay.Location = new System.Drawing.Point(274, 39);
            this._txtDetay.Multiline = true;
            this._txtDetay.Name = "_txtDetay";
            this._txtDetay.Size = new System.Drawing.Size(255, 212);
            this._txtDetay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 334);
            this.Controls.Add(this._txtDetay);
            this.Controls.Add(this._lblHbrDty);
            this.Controls.Add(this._lblBasliklar);
            this.Controls.Add(this._btnHaberlerCek);
            this.Controls.Add(this._lstBaslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstBaslik;
        private System.Windows.Forms.Button _btnHaberlerCek;
        private System.Windows.Forms.Label _lblBasliklar;
        private System.Windows.Forms.Label _lblHbrDty;
        private System.Windows.Forms.TextBox _txtDetay;
    }
}

