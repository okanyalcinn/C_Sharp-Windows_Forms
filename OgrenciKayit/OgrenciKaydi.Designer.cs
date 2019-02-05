namespace OgrenciKayit
{
    partial class OgrenciKaydi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtAd = new System.Windows.Forms.TextBox();
            this._txtSoyad = new System.Windows.Forms.TextBox();
            this._txtDers = new System.Windows.Forms.TextBox();
            this._btnEkle = new System.Windows.Forms.Button();
            this._btnListele = new System.Windows.Forms.Button();
            this._cmbBolum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders:";
            // 
            // _txtAd
            // 
            this._txtAd.Location = new System.Drawing.Point(85, 25);
            this._txtAd.Name = "_txtAd";
            this._txtAd.Size = new System.Drawing.Size(100, 20);
            this._txtAd.TabIndex = 4;
            // 
            // _txtSoyad
            // 
            this._txtSoyad.Location = new System.Drawing.Point(85, 63);
            this._txtSoyad.Name = "_txtSoyad";
            this._txtSoyad.Size = new System.Drawing.Size(100, 20);
            this._txtSoyad.TabIndex = 5;
            // 
            // _txtDers
            // 
            this._txtDers.Location = new System.Drawing.Point(84, 137);
            this._txtDers.Name = "_txtDers";
            this._txtDers.Size = new System.Drawing.Size(100, 20);
            this._txtDers.TabIndex = 7;
            // 
            // _btnEkle
            // 
            this._btnEkle.Location = new System.Drawing.Point(6, 180);
            this._btnEkle.Name = "_btnEkle";
            this._btnEkle.Size = new System.Drawing.Size(75, 23);
            this._btnEkle.TabIndex = 8;
            this._btnEkle.Text = "Ekle";
            this._btnEkle.UseVisualStyleBackColor = true;
            this._btnEkle.Click += new System.EventHandler(this._btnEkle_Click);
            // 
            // _btnListele
            // 
            this._btnListele.Location = new System.Drawing.Point(110, 180);
            this._btnListele.Name = "_btnListele";
            this._btnListele.Size = new System.Drawing.Size(75, 23);
            this._btnListele.TabIndex = 9;
            this._btnListele.Text = "Listele";
            this._btnListele.UseVisualStyleBackColor = true;
            // 
            // _cmbBolum
            // 
            this._cmbBolum.FormattingEnabled = true;
            this._cmbBolum.Location = new System.Drawing.Point(85, 100);
            this._cmbBolum.Name = "_cmbBolum";
            this._cmbBolum.Size = new System.Drawing.Size(100, 21);
            this._cmbBolum.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._cmbBolum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._btnListele);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._btnEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtDers);
            this.groupBox1.Controls.Add(this._txtAd);
            this.groupBox1.Controls.Add(this._txtSoyad);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // OgrenciKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 257);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciKaydi";
            this.Text = "Öğrenci Kaydı";
            this.Load += new System.EventHandler(this.OgrenciKaydi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtAd;
        private System.Windows.Forms.TextBox _txtSoyad;
        private System.Windows.Forms.TextBox _txtDers;
        private System.Windows.Forms.Button _btnEkle;
        private System.Windows.Forms.Button _btnListele;
        private System.Windows.Forms.ComboBox _cmbBolum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}