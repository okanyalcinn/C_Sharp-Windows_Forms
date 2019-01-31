namespace _20190129_ComboBox_ornek2
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
            this._cmbiller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblAdi = new System.Windows.Forms.Label();
            this._lblKodu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmbiller
            // 
            this._cmbiller.FormattingEnabled = true;
            this._cmbiller.Location = new System.Drawing.Point(66, 16);
            this._cmbiller.Name = "_cmbiller";
            this._cmbiller.Size = new System.Drawing.Size(121, 21);
            this._cmbiller.TabIndex = 0;
            this._cmbiller.SelectedIndexChanged += new System.EventHandler(this._cmbiller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İl seç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seçtiğin il adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaka Kodu :";
            // 
            // _lblAdi
            // 
            this._lblAdi.AutoSize = true;
            this._lblAdi.Location = new System.Drawing.Point(160, 67);
            this._lblAdi.Name = "_lblAdi";
            this._lblAdi.Size = new System.Drawing.Size(10, 13);
            this._lblAdi.TabIndex = 5;
            this._lblAdi.Text = ".";
            // 
            // _lblKodu
            // 
            this._lblKodu.AutoSize = true;
            this._lblKodu.Location = new System.Drawing.Point(160, 106);
            this._lblKodu.Name = "_lblKodu";
            this._lblKodu.Size = new System.Drawing.Size(10, 13);
            this._lblKodu.TabIndex = 6;
            this._lblKodu.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 175);
            this.Controls.Add(this._lblKodu);
            this.Controls.Add(this._lblAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbiller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cmbiller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblAdi;
        private System.Windows.Forms.Label _lblKodu;
    }
}

