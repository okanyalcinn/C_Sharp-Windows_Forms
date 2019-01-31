namespace _20190128_DataGridViewKullanimi
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
            this._DBGridListele = new System.Windows.Forms.DataGridView();
            this._xmlKaydet = new System.Windows.Forms.SaveFileDialog();
            this._btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DBGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // _DBGridListele
            // 
            this._DBGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DBGridListele.Location = new System.Drawing.Point(12, 12);
            this._DBGridListele.Name = "_DBGridListele";
            this._DBGridListele.Size = new System.Drawing.Size(649, 179);
            this._DBGridListele.TabIndex = 0;
            // 
            // _btnKaydet
            // 
            this._btnKaydet.Location = new System.Drawing.Point(586, 197);
            this._btnKaydet.Name = "_btnKaydet";
            this._btnKaydet.Size = new System.Drawing.Size(75, 23);
            this._btnKaydet.TabIndex = 1;
            this._btnKaydet.Text = "Kaydet";
            this._btnKaydet.UseVisualStyleBackColor = true;
            this._btnKaydet.Click += new System.EventHandler(this._btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 243);
            this.Controls.Add(this._btnKaydet);
            this.Controls.Add(this._DBGridListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DBGridListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DBGridListele;
        private System.Windows.Forms.SaveFileDialog _xmlKaydet;
        private System.Windows.Forms.Button _btnKaydet;
    }
}

