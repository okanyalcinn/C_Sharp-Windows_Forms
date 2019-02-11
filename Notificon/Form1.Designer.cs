namespace Notificon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this._txtDosyaAdi = new System.Windows.Forms.TextBox();
            this._listeProgram = new System.Windows.Forms.ListBox();
            this._listeAdi = new System.Windows.Forms.ListBox();
            this._txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnEkle = new System.Windows.Forms.Button();
            this._btnGozat = new System.Windows.Forms.Button();
            this._btnSil = new System.Windows.Forms.Button();
            this._btnGizle = new System.Windows.Forms.Button();
            this._mstripUstMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskıÖnizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this._dialogDosyaAc = new System.Windows.Forms.OpenFileDialog();
            this._ntifyTepsiMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this._cntxtMenuTepsi = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this._mstripUstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Dosyası";
            // 
            // _txtDosyaAdi
            // 
            this._txtDosyaAdi.Location = new System.Drawing.Point(15, 53);
            this._txtDosyaAdi.Name = "_txtDosyaAdi";
            this._txtDosyaAdi.Size = new System.Drawing.Size(120, 20);
            this._txtDosyaAdi.TabIndex = 1;
            // 
            // _listeProgram
            // 
            this._listeProgram.FormattingEnabled = true;
            this._listeProgram.Location = new System.Drawing.Point(15, 90);
            this._listeProgram.Name = "_listeProgram";
            this._listeProgram.Size = new System.Drawing.Size(120, 95);
            this._listeProgram.TabIndex = 2;
            // 
            // _listeAdi
            // 
            this._listeAdi.FormattingEnabled = true;
            this._listeAdi.Location = new System.Drawing.Point(189, 90);
            this._listeAdi.Name = "_listeAdi";
            this._listeAdi.Size = new System.Drawing.Size(120, 95);
            this._listeAdi.TabIndex = 5;
            // 
            // _txtDosyaYolu
            // 
            this._txtDosyaYolu.Location = new System.Drawing.Point(189, 53);
            this._txtDosyaYolu.Name = "_txtDosyaYolu";
            this._txtDosyaYolu.Size = new System.Drawing.Size(120, 20);
            this._txtDosyaYolu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program Adı";
            // 
            // _btnEkle
            // 
            this._btnEkle.Location = new System.Drawing.Point(353, 53);
            this._btnEkle.Name = "_btnEkle";
            this._btnEkle.Size = new System.Drawing.Size(75, 23);
            this._btnEkle.TabIndex = 6;
            this._btnEkle.Text = "Listeye Ekle";
            this._btnEkle.UseVisualStyleBackColor = true;
            this._btnEkle.Click += new System.EventHandler(this._btnEkle_Click);
            // 
            // _btnGozat
            // 
            this._btnGozat.Location = new System.Drawing.Point(353, 82);
            this._btnGozat.Name = "_btnGozat";
            this._btnGozat.Size = new System.Drawing.Size(75, 23);
            this._btnGozat.TabIndex = 7;
            this._btnGozat.Text = "Gözat";
            this._btnGozat.UseVisualStyleBackColor = true;
            this._btnGozat.Click += new System.EventHandler(this._btnGozat_Click);
            // 
            // _btnSil
            // 
            this._btnSil.Location = new System.Drawing.Point(353, 111);
            this._btnSil.Name = "_btnSil";
            this._btnSil.Size = new System.Drawing.Size(75, 23);
            this._btnSil.TabIndex = 8;
            this._btnSil.Text = "Sil";
            this._btnSil.UseVisualStyleBackColor = true;
            this._btnSil.Click += new System.EventHandler(this._btnSil_Click);
            // 
            // _btnGizle
            // 
            this._btnGizle.Location = new System.Drawing.Point(353, 162);
            this._btnGizle.Name = "_btnGizle";
            this._btnGizle.Size = new System.Drawing.Size(75, 23);
            this._btnGizle.TabIndex = 9;
            this._btnGizle.Text = "Gizle";
            this._btnGizle.UseVisualStyleBackColor = true;
            this._btnGizle.Click += new System.EventHandler(this._btnGizle_Click);
            // 
            // _mstripUstMenu
            // 
            this._mstripUstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this._mstripUstMenu.Location = new System.Drawing.Point(0, 0);
            this._mstripUstMenu.Name = "_mstripUstMenu";
            this._mstripUstMenu.Size = new System.Drawing.Size(459, 24);
            this._mstripUstMenu.TabIndex = 11;
            this._mstripUstMenu.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yazdırToolStripMenuItem,
            this.baskıÖnizlemeToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yeniToolStripMenuItem.Text = "Y&eni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripMenuItem.Image")));
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.farklıKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yazdırToolStripMenuItem.Text = "Y&azdır";
            // 
            // baskıÖnizlemeToolStripMenuItem
            // 
            this.baskıÖnizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baskıÖnizlemeToolStripMenuItem.Image")));
            this.baskıÖnizlemeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baskıÖnizlemeToolStripMenuItem.Name = "baskıÖnizlemeToolStripMenuItem";
            this.baskıÖnizlemeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.baskıÖnizlemeToolStripMenuItem.Text = "&Baskı Önizleme";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.çıkışToolStripMenuItem.Text = "Çı&kış";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripSeparator4,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.geriAlToolStripMenuItem.Text = "&Geri Al";
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yineleToolStripMenuItem.Text = "Yi&nele";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "&Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripMenuItem.Image")));
            this.yapıştırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "&Yapıştır";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüSeçToolStripMenuItem.Text = "&Tümünü Seç";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelleştirToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "&Araçlar";
            // 
            // özelleştirToolStripMenuItem
            // 
            this.özelleştirToolStripMenuItem.Name = "özelleştirToolStripMenuItem";
            this.özelleştirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.özelleştirToolStripMenuItem.Text = "&Özelleştir";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.seçeneklerToolStripMenuItem.Text = "&Seçenekler";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerToolStripMenuItem,
            this.dizinToolStripMenuItem,
            this.araToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // içindekilerToolStripMenuItem
            // 
            this.içindekilerToolStripMenuItem.Name = "içindekilerToolStripMenuItem";
            this.içindekilerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.içindekilerToolStripMenuItem.Text = "İçi&ndekiler";
            // 
            // dizinToolStripMenuItem
            // 
            this.dizinToolStripMenuItem.Name = "dizinToolStripMenuItem";
            this.dizinToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dizinToolStripMenuItem.Text = "Di&zin";
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.araToolStripMenuItem.Text = "A&ra";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında...";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 219);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.Size = new System.Drawing.Size(459, 22);
            this.statusBar1.TabIndex = 12;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Notificon V1.0";
            this.statusBarPanel1.Width = 150;
            // 
            // _dialogDosyaAc
            // 
            this._dialogDosyaAc.FileName = "openFileDialog1";
            // 
            // _ntifyTepsiMenu
            // 
            this._ntifyTepsiMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("_ntifyTepsiMenu.Icon")));
            this._ntifyTepsiMenu.Text = "notifyIcon1";
            this._ntifyTepsiMenu.Visible = true;
            this._ntifyTepsiMenu.DoubleClick += new System.EventHandler(this._ntifyTepsiMenu_DoubleClick);
            // 
            // _cntxtMenuTepsi
            // 
            this._cntxtMenuTepsi.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this._cntxtMenuTepsi.Popup += new System.EventHandler(this._cntxtMenuTepsi_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Ayarlar";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Çıkış";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 241);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this._mstripUstMenu);
            this.Controls.Add(this._btnGizle);
            this.Controls.Add(this._btnSil);
            this.Controls.Add(this._btnGozat);
            this.Controls.Add(this._btnEkle);
            this.Controls.Add(this._listeAdi);
            this.Controls.Add(this._txtDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._listeProgram);
            this.Controls.Add(this._txtDosyaAdi);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this._mstripUstMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this._mstripUstMenu.ResumeLayout(false);
            this._mstripUstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtDosyaAdi;
        private System.Windows.Forms.ListBox _listeProgram;
        private System.Windows.Forms.ListBox _listeAdi;
        private System.Windows.Forms.TextBox _txtDosyaYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnEkle;
        private System.Windows.Forms.Button _btnGozat;
        private System.Windows.Forms.Button _btnSil;
        private System.Windows.Forms.Button _btnGizle;
        private System.Windows.Forms.MenuStrip _mstripUstMenu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskıÖnizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelleştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.OpenFileDialog _dialogDosyaAc;
        private System.Windows.Forms.NotifyIcon _ntifyTepsiMenu;
        private System.Windows.Forms.ContextMenu _cntxtMenuTepsi;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

