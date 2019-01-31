namespace _20190128_Dizi_islemler
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
            this._txtAdSoyad = new System.Windows.Forms.TextBox();
            this._btnDiziEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._btnSirala = new System.Windows.Forms.Button();
            this._btnTersCevir = new System.Windows.Forms.Button();
            this._btnAra = new System.Windows.Forms.Button();
            this._txtAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnDiziGoster = new System.Windows.Forms.Button();
            this._lstAdlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _txtAdSoyad
            // 
            this._txtAdSoyad.Location = new System.Drawing.Point(81, 23);
            this._txtAdSoyad.Name = "_txtAdSoyad";
            this._txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this._txtAdSoyad.TabIndex = 0;
            // 
            // _btnDiziEkle
            // 
            this._btnDiziEkle.Location = new System.Drawing.Point(209, 21);
            this._btnDiziEkle.Name = "_btnDiziEkle";
            this._btnDiziEkle.Size = new System.Drawing.Size(75, 23);
            this._btnDiziEkle.TabIndex = 1;
            this._btnDiziEkle.Text = "Diziye Ekle";
            this._btnDiziEkle.UseVisualStyleBackColor = true;
            this._btnDiziEkle.Click += new System.EventHandler(this._btnDiziEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad :";
            // 
            // _btnSirala
            // 
            this._btnSirala.Location = new System.Drawing.Point(290, 21);
            this._btnSirala.Name = "_btnSirala";
            this._btnSirala.Size = new System.Drawing.Size(75, 23);
            this._btnSirala.TabIndex = 1;
            this._btnSirala.Text = "Sırala";
            this._btnSirala.UseVisualStyleBackColor = true;
            this._btnSirala.Click += new System.EventHandler(this._btnSirala_Click);
            // 
            // _btnTersCevir
            // 
            this._btnTersCevir.Location = new System.Drawing.Point(290, 193);
            this._btnTersCevir.Name = "_btnTersCevir";
            this._btnTersCevir.Size = new System.Drawing.Size(75, 23);
            this._btnTersCevir.TabIndex = 3;
            this._btnTersCevir.Text = "Ters Çevir";
            this._btnTersCevir.UseVisualStyleBackColor = true;
            this._btnTersCevir.Click += new System.EventHandler(this._btnTersCevir_Click);
            // 
            // _btnAra
            // 
            this._btnAra.Location = new System.Drawing.Point(209, 193);
            this._btnAra.Name = "_btnAra";
            this._btnAra.Size = new System.Drawing.Size(75, 23);
            this._btnAra.TabIndex = 4;
            this._btnAra.Text = "Ara";
            this._btnAra.UseVisualStyleBackColor = true;
            this._btnAra.Click += new System.EventHandler(this._btnAra_Click);
            // 
            // _txtAra
            // 
            this._txtAra.Location = new System.Drawing.Point(81, 195);
            this._txtAra.Name = "_txtAra";
            this._txtAra.Size = new System.Drawing.Size(100, 20);
            this._txtAra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arama :";
            // 
            // _btnDiziGoster
            // 
            this._btnDiziGoster.Location = new System.Drawing.Point(209, 145);
            this._btnDiziGoster.Name = "_btnDiziGoster";
            this._btnDiziGoster.Size = new System.Drawing.Size(156, 31);
            this._btnDiziGoster.TabIndex = 7;
            this._btnDiziGoster.Text = "Dizi elemanlarını göster";
            this._btnDiziGoster.UseVisualStyleBackColor = true;
            this._btnDiziGoster.Click += new System.EventHandler(this._btnDiziGoster_Click);
            // 
            // _lstAdlar
            // 
            this._lstAdlar.FormattingEnabled = true;
            this._lstAdlar.Location = new System.Drawing.Point(19, 68);
            this._lstAdlar.Name = "_lstAdlar";
            this._lstAdlar.Size = new System.Drawing.Size(162, 108);
            this._lstAdlar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this._lstAdlar);
            this.Controls.Add(this._btnDiziGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtAra);
            this.Controls.Add(this._btnAra);
            this.Controls.Add(this._btnTersCevir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnSirala);
            this.Controls.Add(this._btnDiziEkle);
            this.Controls.Add(this._txtAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtAdSoyad;
        private System.Windows.Forms.Button _btnDiziEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSirala;
        private System.Windows.Forms.Button _btnTersCevir;
        private System.Windows.Forms.Button _btnAra;
        private System.Windows.Forms.TextBox _txtAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnDiziGoster;
        private System.Windows.Forms.ListBox _lstAdlar;
    }
}

