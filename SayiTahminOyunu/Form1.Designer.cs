namespace SayiTahminOyunu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblDurum = new System.Windows.Forms.Label();
            this._lblTahmisSayisi = new System.Windows.Forms.Label();
            this._lblPuan = new System.Windows.Forms.Label();
            this._txtSayi = new System.Windows.Forms.TextBox();
            this._btnTahmin = new System.Windows.Forms.Button();
            this._btnBasla = new System.Windows.Forms.Button();
            this._tmrOyunSuresi = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this._lblSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 - 100 arası gir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tahmin Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puan :";
            // 
            // _lblDurum
            // 
            this._lblDurum.AutoSize = true;
            this._lblDurum.Location = new System.Drawing.Point(130, 62);
            this._lblDurum.Name = "_lblDurum";
            this._lblDurum.Size = new System.Drawing.Size(16, 13);
            this._lblDurum.TabIndex = 4;
            this._lblDurum.Text = "...";
            // 
            // _lblTahmisSayisi
            // 
            this._lblTahmisSayisi.AutoSize = true;
            this._lblTahmisSayisi.Location = new System.Drawing.Point(130, 96);
            this._lblTahmisSayisi.Name = "_lblTahmisSayisi";
            this._lblTahmisSayisi.Size = new System.Drawing.Size(16, 13);
            this._lblTahmisSayisi.TabIndex = 5;
            this._lblTahmisSayisi.Text = "...";
            // 
            // _lblPuan
            // 
            this._lblPuan.AutoSize = true;
            this._lblPuan.Location = new System.Drawing.Point(130, 125);
            this._lblPuan.Name = "_lblPuan";
            this._lblPuan.Size = new System.Drawing.Size(16, 13);
            this._lblPuan.TabIndex = 6;
            this._lblPuan.Text = "...";
            // 
            // _txtSayi
            // 
            this._txtSayi.Location = new System.Drawing.Point(133, 28);
            this._txtSayi.Name = "_txtSayi";
            this._txtSayi.Size = new System.Drawing.Size(100, 20);
            this._txtSayi.TabIndex = 7;
            // 
            // _btnTahmin
            // 
            this._btnTahmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btnTahmin.Location = new System.Drawing.Point(262, 31);
            this._btnTahmin.Name = "_btnTahmin";
            this._btnTahmin.Size = new System.Drawing.Size(91, 53);
            this._btnTahmin.TabIndex = 8;
            this._btnTahmin.Text = "Tahmin Et";
            this._btnTahmin.UseVisualStyleBackColor = true;
            this._btnTahmin.Click += new System.EventHandler(this._btnTahmin_Click);
            // 
            // _btnBasla
            // 
            this._btnBasla.Location = new System.Drawing.Point(262, 90);
            this._btnBasla.Name = "_btnBasla";
            this._btnBasla.Size = new System.Drawing.Size(91, 53);
            this._btnBasla.TabIndex = 9;
            this._btnBasla.Text = "Başla";
            this._btnBasla.UseVisualStyleBackColor = true;
            this._btnBasla.Click += new System.EventHandler(this._btnBasla_Click);
            // 
            // _tmrOyunSuresi
            // 
            this._tmrOyunSuresi.Tick += new System.EventHandler(this._tmrOyunSuresi_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Süre :";
            // 
            // _lblSure
            // 
            this._lblSure.AutoSize = true;
            this._lblSure.Location = new System.Drawing.Point(130, 154);
            this._lblSure.Name = "_lblSure";
            this._lblSure.Size = new System.Drawing.Size(16, 13);
            this._lblSure.TabIndex = 11;
            this._lblSure.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 243);
            this.Controls.Add(this._lblSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._btnBasla);
            this.Controls.Add(this._btnTahmin);
            this.Controls.Add(this._txtSayi);
            this.Controls.Add(this._lblPuan);
            this.Controls.Add(this._lblTahmisSayisi);
            this.Controls.Add(this._lblDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblDurum;
        private System.Windows.Forms.Label _lblTahmisSayisi;
        private System.Windows.Forms.Label _lblPuan;
        private System.Windows.Forms.TextBox _txtSayi;
        private System.Windows.Forms.Button _btnTahmin;
        private System.Windows.Forms.Button _btnBasla;
        private System.Windows.Forms.Timer _tmrOyunSuresi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblSure;
    }
}

