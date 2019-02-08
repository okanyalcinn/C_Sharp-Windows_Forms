namespace Scale_Uyum
{
    partial class ScaleUyum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleUyum));
            this._stsbarYeni = new System.Windows.Forms.StatusBar();
            this._tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
            this.SuspendLayout();
            // 
            // _stsbarYeni
            // 
            this._stsbarYeni.Location = new System.Drawing.Point(0, 267);
            this._stsbarYeni.Name = "_stsbarYeni";
            this._stsbarYeni.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3,
            this.statusBarPanel4});
            this._stsbarYeni.ShowPanels = true;
            this._stsbarYeni.Size = new System.Drawing.Size(782, 22);
            this._stsbarYeni.TabIndex = 0;
            this._stsbarYeni.Text = "statusBar1";
            // 
            // _tmrSaat
            // 
            this._tmrSaat.Tick += new System.EventHandler(this._tmrSaat_Tick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "disk Kapasite";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "çözünürlük";
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Text = "Tuş dinleme";
            // 
            // statusBarPanel4
            // 
            this.statusBarPanel4.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel4.Icon")));
            this.statusBarPanel4.Name = "statusBarPanel4";
            this.statusBarPanel4.Text = "saat";
            // 
            // ScaleUyum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 289);
            this.Controls.Add(this._stsbarYeni);
            this.Name = "ScaleUyum";
            this.Text = "ScaleUyum";
            this.Load += new System.EventHandler(this.ScaleUyum_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScaleUyum_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar _stsbarYeni;
        private System.Windows.Forms.Timer _tmrSaat;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private System.Windows.Forms.StatusBarPanel statusBarPanel4;
    }
}

