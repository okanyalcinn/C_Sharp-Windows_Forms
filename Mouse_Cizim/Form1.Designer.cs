namespace Mouse_Cizim
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
            this._lblX = new System.Windows.Forms.Label();
            this._lblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblX
            // 
            this._lblX.AutoSize = true;
            this._lblX.Location = new System.Drawing.Point(13, 425);
            this._lblX.Name = "_lblX";
            this._lblX.Size = new System.Drawing.Size(12, 13);
            this._lblX.TabIndex = 0;
            this._lblX.Text = "x";
            // 
            // _lblY
            // 
            this._lblY.AutoSize = true;
            this._lblY.Location = new System.Drawing.Point(66, 425);
            this._lblY.Name = "_lblY";
            this._lblY.Size = new System.Drawing.Size(12, 13);
            this._lblY.TabIndex = 1;
            this._lblY.Text = "y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblY);
            this.Controls.Add(this._lblX);
            this.Name = "Form1";
            this.Text = "Çizim Alanı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblX;
        private System.Windows.Forms.Label _lblY;
    }
}

