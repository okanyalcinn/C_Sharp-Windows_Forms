namespace FareHareketleri
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
            this._txtAd1 = new System.Windows.Forms.TextBox();
            this._txtAd2 = new System.Windows.Forms.TextBox();
            this._txtAd3 = new System.Windows.Forms.TextBox();
            this._btnGonder = new System.Windows.Forms.Button();
            this._btnGonder2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtAd1
            // 
            this._txtAd1.Location = new System.Drawing.Point(51, 36);
            this._txtAd1.Name = "_txtAd1";
            this._txtAd1.Size = new System.Drawing.Size(100, 20);
            this._txtAd1.TabIndex = 0;
            this._txtAd1.MouseEnter += new System.EventHandler(this._txtAd1_MouseEnter);
            this._txtAd1.MouseLeave += new System.EventHandler(this._txtAd1_MouseLeave);
            // 
            // _txtAd2
            // 
            this._txtAd2.Location = new System.Drawing.Point(51, 78);
            this._txtAd2.Name = "_txtAd2";
            this._txtAd2.Size = new System.Drawing.Size(100, 20);
            this._txtAd2.TabIndex = 1;
            // 
            // _txtAd3
            // 
            this._txtAd3.Location = new System.Drawing.Point(51, 119);
            this._txtAd3.Name = "_txtAd3";
            this._txtAd3.Size = new System.Drawing.Size(100, 20);
            this._txtAd3.TabIndex = 2;
            // 
            // _btnGonder
            // 
            this._btnGonder.Location = new System.Drawing.Point(51, 165);
            this._btnGonder.Name = "_btnGonder";
            this._btnGonder.Size = new System.Drawing.Size(100, 23);
            this._btnGonder.TabIndex = 3;
            this._btnGonder.Text = "Gönder";
            this._btnGonder.UseVisualStyleBackColor = true;
            this._btnGonder.Click += new System.EventHandler(this._btnGonder_Click);
            // 
            // _btnGonder2
            // 
            this._btnGonder2.Location = new System.Drawing.Point(51, 194);
            this._btnGonder2.Name = "_btnGonder2";
            this._btnGonder2.Size = new System.Drawing.Size(100, 23);
            this._btnGonder2.TabIndex = 4;
            this._btnGonder2.Text = "Gönder";
            this._btnGonder2.UseVisualStyleBackColor = true;
            this._btnGonder2.Click += new System.EventHandler(this._btnGonder2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 238);
            this.Controls.Add(this._btnGonder2);
            this.Controls.Add(this._btnGonder);
            this.Controls.Add(this._txtAd3);
            this.Controls.Add(this._txtAd2);
            this.Controls.Add(this._txtAd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtAd1;
        private System.Windows.Forms.TextBox _txtAd2;
        private System.Windows.Forms.TextBox _txtAd3;
        private System.Windows.Forms.Button _btnGonder;
        private System.Windows.Forms.Button _btnGonder2;
    }
}

