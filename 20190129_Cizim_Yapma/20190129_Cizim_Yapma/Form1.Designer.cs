namespace _20190129_Cizim_Yapma
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
            this._btnCiz = new System.Windows.Forms.Button();
            this._btnKaydet = new System.Windows.Forms.Button();
            this._btnAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnCiz
            // 
            this._btnCiz.Location = new System.Drawing.Point(694, 61);
            this._btnCiz.Name = "_btnCiz";
            this._btnCiz.Size = new System.Drawing.Size(75, 23);
            this._btnCiz.TabIndex = 0;
            this._btnCiz.Text = "Çiz";
            this._btnCiz.UseVisualStyleBackColor = true;
            this._btnCiz.Click += new System.EventHandler(this._btnCiz_Click);
            // 
            // _btnKaydet
            // 
            this._btnKaydet.Location = new System.Drawing.Point(694, 90);
            this._btnKaydet.Name = "_btnKaydet";
            this._btnKaydet.Size = new System.Drawing.Size(75, 23);
            this._btnKaydet.TabIndex = 1;
            this._btnKaydet.Text = "Kaydet";
            this._btnKaydet.UseVisualStyleBackColor = true;
            this._btnKaydet.Click += new System.EventHandler(this._btnKaydet_Click);
            // 
            // _btnAc
            // 
            this._btnAc.Location = new System.Drawing.Point(694, 119);
            this._btnAc.Name = "_btnAc";
            this._btnAc.Size = new System.Drawing.Size(75, 23);
            this._btnAc.TabIndex = 2;
            this._btnAc.Text = "Aç";
            this._btnAc.UseVisualStyleBackColor = true;
            this._btnAc.Click += new System.EventHandler(this._btnAc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnAc);
            this.Controls.Add(this._btnKaydet);
            this.Controls.Add(this._btnCiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnCiz;
        private System.Windows.Forms.Button _btnKaydet;
        private System.Windows.Forms.Button _btnAc;
    }
}

