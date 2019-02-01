namespace Yazdirma_liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtOgrenci = new System.Windows.Forms.TextBox();
            this._txtSinav = new System.Windows.Forms.TextBox();
            this._listOgrenci = new System.Windows.Forms.ListBox();
            this._listSinav = new System.Windows.Forms.ListBox();
            this._listSonuc = new System.Windows.Forms.ListBox();
            this._textRaporBaslik = new System.Windows.Forms.TextBox();
            this._btnEkle = new System.Windows.Forms.Button();
            this._btnYazdir = new System.Windows.Forms.Button();
            this._btnBaskiOnizleme = new System.Windows.Forms.Button();
            this._btnSayfaYapisi = new System.Windows.Forms.Button();
            this._btnRandomSayi = new System.Windows.Forms.Button();
            this._printOnizleme = new System.Windows.Forms.PrintPreviewDialog();
            this._printSayfa = new System.Drawing.Printing.PrintDocument();
            this._pageAyar = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınav Notu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rapor Başlık";
            // 
            // _txtOgrenci
            // 
            this._txtOgrenci.Location = new System.Drawing.Point(38, 91);
            this._txtOgrenci.Name = "_txtOgrenci";
            this._txtOgrenci.Size = new System.Drawing.Size(100, 20);
            this._txtOgrenci.TabIndex = 4;
            // 
            // _txtSinav
            // 
            this._txtSinav.Location = new System.Drawing.Point(164, 91);
            this._txtSinav.Name = "_txtSinav";
            this._txtSinav.Size = new System.Drawing.Size(100, 20);
            this._txtSinav.TabIndex = 5;
            // 
            // _listOgrenci
            // 
            this._listOgrenci.FormattingEnabled = true;
            this._listOgrenci.Location = new System.Drawing.Point(38, 134);
            this._listOgrenci.Name = "_listOgrenci";
            this._listOgrenci.Size = new System.Drawing.Size(120, 95);
            this._listOgrenci.TabIndex = 7;
            // 
            // _listSinav
            // 
            this._listSinav.FormattingEnabled = true;
            this._listSinav.Location = new System.Drawing.Point(164, 134);
            this._listSinav.Name = "_listSinav";
            this._listSinav.Size = new System.Drawing.Size(120, 95);
            this._listSinav.TabIndex = 8;
            // 
            // _listSonuc
            // 
            this._listSonuc.FormattingEnabled = true;
            this._listSonuc.Location = new System.Drawing.Point(290, 134);
            this._listSonuc.Name = "_listSonuc";
            this._listSonuc.Size = new System.Drawing.Size(120, 95);
            this._listSonuc.TabIndex = 9;
            // 
            // _textRaporBaslik
            // 
            this._textRaporBaslik.Location = new System.Drawing.Point(241, 30);
            this._textRaporBaslik.Name = "_textRaporBaslik";
            this._textRaporBaslik.Size = new System.Drawing.Size(302, 20);
            this._textRaporBaslik.TabIndex = 10;
            // 
            // _btnEkle
            // 
            this._btnEkle.Location = new System.Drawing.Point(38, 235);
            this._btnEkle.Name = "_btnEkle";
            this._btnEkle.Size = new System.Drawing.Size(372, 23);
            this._btnEkle.TabIndex = 11;
            this._btnEkle.Text = "Ekle";
            this._btnEkle.UseVisualStyleBackColor = true;
            this._btnEkle.Click += new System.EventHandler(this._btnEkle_Click);
            // 
            // _btnYazdir
            // 
            this._btnYazdir.Location = new System.Drawing.Point(433, 91);
            this._btnYazdir.Name = "_btnYazdir";
            this._btnYazdir.Size = new System.Drawing.Size(110, 23);
            this._btnYazdir.TabIndex = 12;
            this._btnYazdir.Text = "Yazdır";
            this._btnYazdir.UseVisualStyleBackColor = true;
            this._btnYazdir.Click += new System.EventHandler(this._btnYazdir_Click);
            // 
            // _btnBaskiOnizleme
            // 
            this._btnBaskiOnizleme.Location = new System.Drawing.Point(433, 120);
            this._btnBaskiOnizleme.Name = "_btnBaskiOnizleme";
            this._btnBaskiOnizleme.Size = new System.Drawing.Size(110, 23);
            this._btnBaskiOnizleme.TabIndex = 13;
            this._btnBaskiOnizleme.Text = "Baskı Önizleme";
            this._btnBaskiOnizleme.UseVisualStyleBackColor = true;
            this._btnBaskiOnizleme.Click += new System.EventHandler(this._btnBaskiOnizleme_Click);
            // 
            // _btnSayfaYapisi
            // 
            this._btnSayfaYapisi.Location = new System.Drawing.Point(433, 149);
            this._btnSayfaYapisi.Name = "_btnSayfaYapisi";
            this._btnSayfaYapisi.Size = new System.Drawing.Size(110, 23);
            this._btnSayfaYapisi.TabIndex = 14;
            this._btnSayfaYapisi.Text = "Sayfa Yapısı";
            this._btnSayfaYapisi.UseVisualStyleBackColor = true;
            this._btnSayfaYapisi.Click += new System.EventHandler(this._btnSayfaYapisi_Click);
            // 
            // _btnRandomSayi
            // 
            this._btnRandomSayi.Location = new System.Drawing.Point(433, 202);
            this._btnRandomSayi.Name = "_btnRandomSayi";
            this._btnRandomSayi.Size = new System.Drawing.Size(110, 23);
            this._btnRandomSayi.TabIndex = 15;
            this._btnRandomSayi.Text = "Random Sayı Ata";
            this._btnRandomSayi.UseVisualStyleBackColor = true;
            this._btnRandomSayi.Click += new System.EventHandler(this._btnRandomSayi_Click);
            // 
            // _printOnizleme
            // 
            this._printOnizleme.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this._printOnizleme.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._printOnizleme.ClientSize = new System.Drawing.Size(400, 300);
            this._printOnizleme.Enabled = true;
            this._printOnizleme.Icon = ((System.Drawing.Icon)(resources.GetObject("_printOnizleme.Icon")));
            this._printOnizleme.Name = "_printOnizleme";
            this._printOnizleme.Text = "Baskı önizleme";
            this._printOnizleme.Visible = false;
            // 
            // _printSayfa
            // 
            this._printSayfa.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this._printSayfa_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this._btnRandomSayi);
            this.Controls.Add(this._btnSayfaYapisi);
            this.Controls.Add(this._btnBaskiOnizleme);
            this.Controls.Add(this._btnYazdir);
            this.Controls.Add(this._btnEkle);
            this.Controls.Add(this._textRaporBaslik);
            this.Controls.Add(this._listSonuc);
            this.Controls.Add(this._listSinav);
            this.Controls.Add(this._listOgrenci);
            this.Controls.Add(this._txtSinav);
            this.Controls.Add(this._txtOgrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtOgrenci;
        private System.Windows.Forms.TextBox _txtSinav;
        private System.Windows.Forms.ListBox _listOgrenci;
        private System.Windows.Forms.ListBox _listSinav;
        private System.Windows.Forms.ListBox _listSonuc;
        private System.Windows.Forms.TextBox _textRaporBaslik;
        private System.Windows.Forms.Button _btnEkle;
        private System.Windows.Forms.Button _btnYazdir;
        private System.Windows.Forms.Button _btnBaskiOnizleme;
        private System.Windows.Forms.Button _btnSayfaYapisi;
        private System.Windows.Forms.Button _btnRandomSayi;
        private System.Windows.Forms.PrintPreviewDialog _printOnizleme;
        private System.Drawing.Printing.PrintDocument _printSayfa;
        private System.Windows.Forms.PageSetupDialog _pageAyar;
    }
}

