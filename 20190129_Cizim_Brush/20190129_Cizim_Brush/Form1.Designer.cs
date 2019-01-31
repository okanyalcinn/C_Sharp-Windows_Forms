namespace _20190129_Cizim_Brush
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
            this._btnDikdortgen = new System.Windows.Forms.Button();
            this._btnElips = new System.Windows.Forms.Button();
            this._btnYaziEkle = new System.Windows.Forms.Button();
            this._cmbSecim = new System.Windows.Forms.ComboBox();
            this._btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnDikdortgen
            // 
            this._btnDikdortgen.Location = new System.Drawing.Point(675, 45);
            this._btnDikdortgen.Name = "_btnDikdortgen";
            this._btnDikdortgen.Size = new System.Drawing.Size(75, 28);
            this._btnDikdortgen.TabIndex = 0;
            this._btnDikdortgen.Text = "Dikdörtgen";
            this._btnDikdortgen.UseVisualStyleBackColor = true;
            this._btnDikdortgen.Click += new System.EventHandler(this._btnDikdortgen_Click);
            // 
            // _btnElips
            // 
            this._btnElips.Location = new System.Drawing.Point(675, 84);
            this._btnElips.Name = "_btnElips";
            this._btnElips.Size = new System.Drawing.Size(75, 28);
            this._btnElips.TabIndex = 1;
            this._btnElips.Text = "Elips";
            this._btnElips.UseVisualStyleBackColor = true;
            this._btnElips.Click += new System.EventHandler(this._btnElips_Click);
            // 
            // _btnYaziEkle
            // 
            this._btnYaziEkle.Location = new System.Drawing.Point(675, 122);
            this._btnYaziEkle.Name = "_btnYaziEkle";
            this._btnYaziEkle.Size = new System.Drawing.Size(75, 28);
            this._btnYaziEkle.TabIndex = 2;
            this._btnYaziEkle.Text = "Yazı Ekle";
            this._btnYaziEkle.UseVisualStyleBackColor = true;
            this._btnYaziEkle.Click += new System.EventHandler(this._btnYaziEkle_Click);
            // 
            // _cmbSecim
            // 
            this._cmbSecim.FormattingEnabled = true;
            this._cmbSecim.Location = new System.Drawing.Point(629, 204);
            this._cmbSecim.Name = "_cmbSecim";
            this._cmbSecim.Size = new System.Drawing.Size(121, 21);
            this._cmbSecim.TabIndex = 3;
            this._cmbSecim.SelectedIndexChanged += new System.EventHandler(this._cmbSecim_SelectedIndexChanged);
            // 
            // _btnTemizle
            // 
            this._btnTemizle.Location = new System.Drawing.Point(675, 159);
            this._btnTemizle.Name = "_btnTemizle";
            this._btnTemizle.Size = new System.Drawing.Size(75, 24);
            this._btnTemizle.TabIndex = 4;
            this._btnTemizle.Text = "Temizle";
            this._btnTemizle.UseVisualStyleBackColor = true;
            this._btnTemizle.Click += new System.EventHandler(this._btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnTemizle);
            this.Controls.Add(this._cmbSecim);
            this.Controls.Add(this._btnYaziEkle);
            this.Controls.Add(this._btnElips);
            this.Controls.Add(this._btnDikdortgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnDikdortgen;
        private System.Windows.Forms.Button _btnElips;
        private System.Windows.Forms.Button _btnYaziEkle;
        private System.Windows.Forms.ComboBox _cmbSecim;
        private System.Windows.Forms.Button _btnTemizle;
    }
}

