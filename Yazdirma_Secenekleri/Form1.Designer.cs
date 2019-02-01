namespace Yazdirma_Secenekleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._btnYazdir = new System.Windows.Forms.Button();
            this._printSayfa = new System.Drawing.Printing.PrintDocument();
            this._btnBaskiOniz = new System.Windows.Forms.Button();
            this._btnSayfaAyarlari = new System.Windows.Forms.Button();
            this._printDialog = new System.Windows.Forms.PrintPreviewDialog();
            this._pageSayfaAyar = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // _btnYazdir
            // 
            this._btnYazdir.Location = new System.Drawing.Point(650, 12);
            this._btnYazdir.Name = "_btnYazdir";
            this._btnYazdir.Size = new System.Drawing.Size(115, 32);
            this._btnYazdir.TabIndex = 0;
            this._btnYazdir.Text = "Yazdır";
            this._btnYazdir.UseVisualStyleBackColor = true;
            this._btnYazdir.Click += new System.EventHandler(this._btnYazdir_Click);
            // 
            // _printSayfa
            // 
            this._printSayfa.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this._printSayfa_PrintPage);
            // 
            // _btnBaskiOniz
            // 
            this._btnBaskiOniz.Location = new System.Drawing.Point(651, 52);
            this._btnBaskiOniz.Name = "_btnBaskiOniz";
            this._btnBaskiOniz.Size = new System.Drawing.Size(115, 32);
            this._btnBaskiOniz.TabIndex = 1;
            this._btnBaskiOniz.Text = "Baskı Önizleme";
            this._btnBaskiOniz.UseVisualStyleBackColor = true;
            this._btnBaskiOniz.Click += new System.EventHandler(this._btnBaskiOniz_Click);
            // 
            // _btnSayfaAyarlari
            // 
            this._btnSayfaAyarlari.Location = new System.Drawing.Point(651, 91);
            this._btnSayfaAyarlari.Name = "_btnSayfaAyarlari";
            this._btnSayfaAyarlari.Size = new System.Drawing.Size(115, 32);
            this._btnSayfaAyarlari.TabIndex = 2;
            this._btnSayfaAyarlari.Text = "Sayfa Ayarları";
            this._btnSayfaAyarlari.UseVisualStyleBackColor = true;
            this._btnSayfaAyarlari.Click += new System.EventHandler(this._btnSayfaAyarlari_Click);
            // 
            // _printDialog
            // 
            this._printDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this._printDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._printDialog.ClientSize = new System.Drawing.Size(400, 300);
            this._printDialog.Enabled = true;
            this._printDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("_printDialog.Icon")));
            this._printDialog.Name = "_printDialog";
            this._printDialog.Text = "Baskı önizleme";
            this._printDialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 393);
            this.Controls.Add(this._btnSayfaAyarlari);
            this.Controls.Add(this._btnBaskiOniz);
            this.Controls.Add(this._btnYazdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnYazdir;
        private System.Drawing.Printing.PrintDocument _printSayfa;
        private System.Windows.Forms.Button _btnBaskiOniz;
        private System.Windows.Forms.Button _btnSayfaAyarlari;
        private System.Windows.Forms.PrintPreviewDialog _printDialog;
        private System.Windows.Forms.PageSetupDialog _pageSayfaAyar;
    }
}

