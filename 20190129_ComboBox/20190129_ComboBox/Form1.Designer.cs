namespace _20190129_ComboBox
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
            this._cmbFont = new System.Windows.Forms.ComboBox();
            this._cmbPunto = new System.Windows.Forms.ComboBox();
            this._txtMetinArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _cmbFont
            // 
            this._cmbFont.FormattingEnabled = true;
            this._cmbFont.Location = new System.Drawing.Point(13, 13);
            this._cmbFont.Name = "_cmbFont";
            this._cmbFont.Size = new System.Drawing.Size(121, 21);
            this._cmbFont.TabIndex = 0;
            this._cmbFont.Text = "Yazı Tipi Seç";
            this._cmbFont.SelectedIndexChanged += new System.EventHandler(this._cmbFont_SelectedIndexChanged);
            // 
            // _cmbPunto
            // 
            this._cmbPunto.FormattingEnabled = true;
            this._cmbPunto.Location = new System.Drawing.Point(140, 13);
            this._cmbPunto.Name = "_cmbPunto";
            this._cmbPunto.Size = new System.Drawing.Size(121, 21);
            this._cmbPunto.TabIndex = 1;
            // 
            // _txtMetinArea
            // 
            this._txtMetinArea.Location = new System.Drawing.Point(13, 40);
            this._txtMetinArea.Multiline = true;
            this._txtMetinArea.Name = "_txtMetinArea";
            this._txtMetinArea.Size = new System.Drawing.Size(248, 152);
            this._txtMetinArea.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 205);
            this.Controls.Add(this._txtMetinArea);
            this.Controls.Add(this._cmbPunto);
            this.Controls.Add(this._cmbFont);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cmbFont;
        private System.Windows.Forms.ComboBox _cmbPunto;
        private System.Windows.Forms.TextBox _txtMetinArea;
    }
}

