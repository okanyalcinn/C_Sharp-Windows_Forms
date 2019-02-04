namespace Geth_DosyaKaydet
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
            this._txtMetin = new System.Windows.Forms.TextBox();
            this._lblYol = new System.Windows.Forms.Label();
            this._mnthAylar = new System.Windows.Forms.MonthCalendar();
            this._nmtUpDown1 = new System.Windows.Forms.NumericUpDown();
            this._nmtUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._nmtUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmtUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtMetin
            // 
            this._txtMetin.Location = new System.Drawing.Point(13, 13);
            this._txtMetin.Multiline = true;
            this._txtMetin.Name = "_txtMetin";
            this._txtMetin.Size = new System.Drawing.Size(250, 187);
            this._txtMetin.TabIndex = 0;
            // 
            // _lblYol
            // 
            this._lblYol.AutoSize = true;
            this._lblYol.Location = new System.Drawing.Point(28, 239);
            this._lblYol.Name = "_lblYol";
            this._lblYol.Size = new System.Drawing.Size(35, 13);
            this._lblYol.TabIndex = 1;
            this._lblYol.Text = "label1";
            // 
            // _mnthAylar
            // 
            this._mnthAylar.Location = new System.Drawing.Point(275, 38);
            this._mnthAylar.Name = "_mnthAylar";
            this._mnthAylar.TabIndex = 2;
            // 
            // _nmtUpDown1
            // 
            this._nmtUpDown1.Location = new System.Drawing.Point(415, 12);
            this._nmtUpDown1.Name = "_nmtUpDown1";
            this._nmtUpDown1.Size = new System.Drawing.Size(44, 20);
            this._nmtUpDown1.TabIndex = 3;
            this._nmtUpDown1.ValueChanged += new System.EventHandler(this._nmtUpDown1_ValueChanged);
            // 
            // _nmtUpDown2
            // 
            this._nmtUpDown2.Location = new System.Drawing.Point(465, 12);
            this._nmtUpDown2.Name = "_nmtUpDown2";
            this._nmtUpDown2.Size = new System.Drawing.Size(44, 20);
            this._nmtUpDown2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Takvim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._nmtUpDown2);
            this.Controls.Add(this._nmtUpDown1);
            this.Controls.Add(this._mnthAylar);
            this.Controls.Add(this._lblYol);
            this.Controls.Add(this._txtMetin);
            this.Name = "Form1";
            this.Text = "Dat Kaydet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nmtUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmtUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtMetin;
        private System.Windows.Forms.Label _lblYol;
        private System.Windows.Forms.MonthCalendar _mnthAylar;
        private System.Windows.Forms.NumericUpDown _nmtUpDown1;
        private System.Windows.Forms.NumericUpDown _nmtUpDown2;
        private System.Windows.Forms.Label label1;
    }
}

